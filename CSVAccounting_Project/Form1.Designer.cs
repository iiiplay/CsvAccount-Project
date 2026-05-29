namespace CSVAccounting_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            cbxIncome = new CheckBox();
            cmbCategory = new ComboBox();
            label3 = new Label();
            nudAmount = new NumericUpDown();
            label2 = new Label();
            txtNote = new TextBox();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            panel2 = new Panel();
            lblTotal = new Label();
            lbloutgoing = new Label();
            lblIncoming = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClean = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnAdd = new Button();
            dgvItems = new DataGridView();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isIncomeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            itemBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbxIncome);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nudAmount);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNote);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpDate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 43);
            panel1.TabIndex = 0;
            // 
            // cbxIncome
            // 
            cbxIncome.AutoSize = true;
            cbxIncome.Font = new Font("Microsoft JhengHei UI", 11.25F);
            cbxIncome.Location = new Point(866, 9);
            cbxIncome.Name = "cbxIncome";
            cbxIncome.Size = new Size(58, 23);
            cbxIncome.TabIndex = 7;
            cbxIncome.Text = "收入";
            cbxIncome.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Microsoft JhengHei UI", 11.25F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(706, 7);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 27);
            cmbCategory.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 11.25F);
            label3.Location = new Point(660, 11);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 5;
            label3.Text = "類別";
            // 
            // nudAmount
            // 
            nudAmount.Font = new Font("Microsoft JhengHei UI", 11.25F);
            nudAmount.Location = new Point(525, 7);
            nudAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(120, 27);
            nudAmount.TabIndex = 4;
            nudAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 11.25F);
            label2.Location = new Point(479, 11);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 3;
            label2.Text = "金額";
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Microsoft JhengHei UI", 11.25F);
            txtNote.Location = new Point(267, 7);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(197, 27);
            txtNote.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 11.25F);
            label1.Location = new Point(221, 11);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 1;
            label1.Text = "項目";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Microsoft JhengHei UI", 11.25F);
            dtpDate.Location = new Point(6, 7);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 27);
            dtpDate.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lbloutgoing);
            panel2.Controls.Add(lblIncoming);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnClean);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnLoad);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 500);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 61);
            panel2.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblTotal.ForeColor = Color.FromArgb(192, 0, 0);
            lblTotal.Location = new Point(524, 12);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(31, 35);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "0";
            // 
            // lbloutgoing
            // 
            lbloutgoing.AutoSize = true;
            lbloutgoing.ForeColor = Color.Red;
            lbloutgoing.Location = new Point(355, 36);
            lbloutgoing.Name = "lbloutgoing";
            lbloutgoing.Size = new Size(34, 15);
            lbloutgoing.TabIndex = 8;
            lbloutgoing.Text = "支出:";
            // 
            // lblIncoming
            // 
            lblIncoming.AutoSize = true;
            lblIncoming.ForeColor = Color.Blue;
            lblIncoming.Location = new Point(355, 8);
            lblIncoming.Name = "lblIncoming";
            lblIncoming.Size = new Size(34, 15);
            lblIncoming.TabIndex = 7;
            lblIncoming.Text = "收入:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 224, 192);
            btnDelete.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnDelete.Location = new Point(868, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 43);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnUpdate.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnUpdate.Location = new Point(763, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 43);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "更新";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.FromArgb(255, 224, 192);
            btnClean.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnClean.Location = new Point(658, 8);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(99, 43);
            btnClean.TabIndex = 4;
            btnClean.Text = "清除";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 224, 192);
            btnSave.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnSave.Location = new Point(122, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 43);
            btnSave.TabIndex = 3;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(255, 224, 192);
            btnLoad.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnLoad.Location = new Point(231, 8);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(99, 43);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "讀取";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 224, 192);
            btnAdd.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnAdd.Location = new Point(13, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 43);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoGenerateColumns = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { dateDataGridViewTextBoxColumn, noteDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, categoryTypeDataGridViewTextBoxColumn, isIncomeDataGridViewCheckBoxColumn });
            dgvItems.DataSource = itemBindingSource;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 43);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.Size = new Size(982, 457);
            dgvItems.TabIndex = 3;
            dgvItems.CellDoubleClick += dgvItems_CellDoubleClick;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "日期";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn.HeaderText = "事項";
            noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            noteDataGridViewTextBoxColumn.ReadOnly = true;
            noteDataGridViewTextBoxColumn.Width = 250;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "金額";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryTypeDataGridViewTextBoxColumn
            // 
            categoryTypeDataGridViewTextBoxColumn.DataPropertyName = "CategoryType";
            categoryTypeDataGridViewTextBoxColumn.HeaderText = "分類";
            categoryTypeDataGridViewTextBoxColumn.Name = "categoryTypeDataGridViewTextBoxColumn";
            categoryTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isIncomeDataGridViewCheckBoxColumn
            // 
            isIncomeDataGridViewCheckBoxColumn.DataPropertyName = "IsIncome";
            isIncomeDataGridViewCheckBoxColumn.HeaderText = "收入";
            isIncomeDataGridViewCheckBoxColumn.Name = "isIncomeDataGridViewCheckBoxColumn";
            isIncomeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Item);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 561);
            Controls.Add(dgvItems);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSV 記帳APP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtpDate;
        private Label label1;
        private TextBox txtNote;
        private Label label2;
        private NumericUpDown nudAmount;
        private Label label3;
        private ComboBox cmbCategory;
        private CheckBox cbxIncome;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClean;
        private Button btnSave;
        private Button btnLoad;
        private DataGridView dgvItems;
        private BindingSource itemBindingSource;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryTypeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isIncomeDataGridViewCheckBoxColumn;
        private Label lblIncoming;
        private Label lbloutgoing;
        private Label lblTotal;
    }
}
