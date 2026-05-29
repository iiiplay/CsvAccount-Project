

using System.ComponentModel;
using System.Text;

namespace CSVAccounting_Project
{
    public partial class Form1 : Form
    {
        private BindingList<Item> items = new BindingList<Item>();


        public Form1()
        {
            InitializeComponent();

            // 將enum型態轉換成combox可以讀取的型態
            cmbCategory.DataSource = Enum.GetValues(typeof(Category));
            dgvItems.DataSource = items;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNote.Text == string.Empty)
            {
                MessageBox.Show("輸入不能為空!", "警告");
                return;
            }

            if (nudAmount.Value <= 0)
            {
                MessageBox.Show("金額輸入不正確!", "警告");
                return;
            }


            Item item = new Item();
            item.Date = dtpDate.Value;
            item.Note = txtNote.Text;
            item.Amount = nudAmount.Value;
            item.IsIncome = cbxIncome.Checked;
            item.CategoryType = (Category)cmbCategory.SelectedItem!;

            items.Add(item);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null)
            {
                return;
            }

            //取得DataGridView選擇到的位置
            int index = dgvItems.CurrentRow.Index;


            if (MessageBox.Show("確定刪除?", "警告",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                items.RemoveAt(index);
            }
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Console.WriteLine(sender);
            Console.WriteLine(e);

            MessageBox.Show($"點選到第{e.RowIndex + 1}列資料，進入編輯模式");


            Item item = items[e.RowIndex];


            dtpDate.Value = item.Date;
            txtNote.Text = item.Note;
            nudAmount.Value = item.Amount;
            cbxIncome.Checked = item.IsIncome;
            cmbCategory.SelectedItem = item.CategoryType;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null)
            {
                return;
            }

            //取得DataGridView選擇到的位置
            int index = dgvItems.CurrentRow.Index;


            if (MessageBox.Show("確定更新嗎?", "警告",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Item item = new Item();
                item.Date = dtpDate.Value;
                item.Note = txtNote.Text;
                item.Amount = nudAmount.Value;
                item.IsIncome = cbxIncome.Checked;
                item.CategoryType = (Category)cmbCategory.SelectedItem!;

                items[index] = item;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV 檔案|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                items.Clear();

                this.Text = "CSV 記帳APP - " + Path.GetFileName(ofd.FileName);
                try
                {
                    string[] lines = File.ReadAllLines(
                        ofd.FileName, Encoding.UTF8);

                    // 跳過第一行標題列，從索引 1 開始
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] cols = lines[i].Split(',');
                        if (cols.Length < 5) continue;

                        Item item = new Item();

                        item.Date = DateTime.Parse(cols[0]);
                        item.Note = cols[1];
                        item.Amount = decimal.Parse(cols[2]);
                        item.IsIncome = cols[3] == "是" ? true : false;
                        item.CategoryType = (Category)Enum.Parse(typeof(Category), cols[4]);

                        items.Add(item);
                    }

                    Calculate();
                }
                catch (Exception)
                {
                    MessageBox.Show("檔案格式不正確。",
                       "錯誤",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            if (dialog.ShowDialog() != DialogResult.OK) return;


            dialog.Filter = "CSV 檔案|*.csv";
            dialog.FileName = "accounting.csv";

            //寫入檔案
            using (StreamWriter sw = new StreamWriter(
                dialog.FileName, false, Encoding.UTF8))
            {
                sw.WriteLine("日期,事項,金額,分類,收入");

                foreach (Item item in items)
                {
                    string line = string.Format(
                        "{0},{1},{2},{3},{4}",
                        item.Date.ToString("yyyy/MM/dd hh:mm"),
                        item.Note,
                        item.Amount,
                        item.CategoryType,
                        item.IsIncome ? "是" : "否"
                        );

                    sw.WriteLine(line);
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (items.Count == 0 || MessageBox.Show("確定全部清除嗎?", "警告",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            items.Clear();
        }


        private void Calculate()
        {
            double incoming = 0, outgoing = 0;
            foreach (Item item in items)
            {
                if (item.IsIncome)
                {
                    incoming += (double)item.Amount;
                }
                else
                {
                    outgoing += (double)item.Amount;
                }
            }

            lblIncoming.Text = $"| 收入:{incoming}";
            lbloutgoing.Text = $"| 支出:{outgoing}";

            lblTotal.Text = $"{incoming - outgoing}";
        }
    }
}
