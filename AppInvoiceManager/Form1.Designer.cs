namespace AppInvoiceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            btn_FindByName = new Button();
            txtbx_FindByName = new TextBox();
            label1 = new Label();
            pnl_Register = new Panel();
            btn_FindAll = new Button();
            btn_Payment = new Button();
            label7 = new Label();
            lbl_Month = new Label();
            cb_status = new ComboBox();
            txtb_Delete = new TextBox();
            btn_Delete = new Button();
            label8 = new Label();
            txtb_Recovery = new TextBox();
            cb_Recovery = new ComboBox();
            btn_Recovery = new Button();
            lbl_TotalSpentValue = new Label();
            btn_GetTotalValue = new Button();
            label2 = new Label();
            label3 = new Label();
            lbl_TotalByName = new Label();
            txtb_ValueTotalName = new TextBox();
            btn_SearchByName = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(844, 528);
            dataGridView1.TabIndex = 0;
            // 
            // btn_FindByName
            // 
            btn_FindByName.Location = new Point(271, 214);
            btn_FindByName.Name = "btn_FindByName";
            btn_FindByName.Size = new Size(67, 23);
            btn_FindByName.TabIndex = 2;
            btn_FindByName.Text = "Buscar";
            btn_FindByName.UseVisualStyleBackColor = true;
            btn_FindByName.Click += btn_FindByName_Click;
            // 
            // txtbx_FindByName
            // 
            txtbx_FindByName.Location = new Point(12, 214);
            txtbx_FindByName.Name = "txtbx_FindByName";
            txtbx_FindByName.PlaceholderText = "NOME";
            txtbx_FindByName.Size = new Size(150, 23);
            txtbx_FindByName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 196);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 4;
            label1.Text = "BUSCAR POR PAGADOR";
            // 
            // pnl_Register
            // 
            pnl_Register.BackColor = SystemColors.ControlLight;
            pnl_Register.Location = new Point(12, 338);
            pnl_Register.Name = "pnl_Register";
            pnl_Register.Size = new Size(308, 248);
            pnl_Register.TabIndex = 5;
            // 
            // btn_FindAll
            // 
            btn_FindAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_FindAll.ForeColor = Color.FromArgb(192, 0, 0);
            btn_FindAll.Location = new Point(12, 12);
            btn_FindAll.Name = "btn_FindAll";
            btn_FindAll.Size = new Size(141, 45);
            btn_FindAll.TabIndex = 6;
            btn_FindAll.Text = "BUSCAR PENDENCIAS";
            btn_FindAll.UseVisualStyleBackColor = true;
            btn_FindAll.Click += btn_FindAll_Click;
            // 
            // btn_Payment
            // 
            btn_Payment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Payment.ForeColor = Color.Green;
            btn_Payment.Location = new Point(179, 12);
            btn_Payment.Name = "btn_Payment";
            btn_Payment.Size = new Size(141, 45);
            btn_Payment.TabIndex = 7;
            btn_Payment.Text = "PAGAR FATURA";
            btn_Payment.UseVisualStyleBackColor = true;
            btn_Payment.Click += btn_Payment_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(12, 284);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 10;
            label7.Text = "DELETAR POR ID";
            // 
            // lbl_Month
            // 
            lbl_Month.AutoSize = true;
            lbl_Month.Font = new Font("Candara", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Month.Location = new Point(674, 6);
            lbl_Month.Name = "lbl_Month";
            lbl_Month.Size = new Size(0, 49);
            lbl_Month.TabIndex = 11;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "ATIVOS", "PAGOS", "DELETADOS", "TODOS" });
            cb_status.Location = new Point(168, 214);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(97, 23);
            cb_status.TabIndex = 12;
            cb_status.Text = "STATUS";
            // 
            // txtb_Delete
            // 
            txtb_Delete.Location = new Point(12, 307);
            txtb_Delete.Name = "txtb_Delete";
            txtb_Delete.PlaceholderText = "ID";
            txtb_Delete.Size = new Size(150, 23);
            txtb_Delete.TabIndex = 13;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(168, 307);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 14;
            btn_Delete.Text = "Deletar";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(12, 240);
            label8.Name = "label8";
            label8.Size = new Size(118, 15);
            label8.TabIndex = 15;
            label8.Text = "RESTAURAR POR ID";
            // 
            // txtb_Recovery
            // 
            txtb_Recovery.Location = new Point(12, 258);
            txtb_Recovery.Name = "txtb_Recovery";
            txtb_Recovery.PlaceholderText = "ID";
            txtb_Recovery.Size = new Size(150, 23);
            txtb_Recovery.TabIndex = 16;
            // 
            // cb_Recovery
            // 
            cb_Recovery.FormattingEnabled = true;
            cb_Recovery.Items.AddRange(new object[] { "ATIVO", "PAGO" });
            cb_Recovery.Location = new Point(168, 258);
            cb_Recovery.Name = "cb_Recovery";
            cb_Recovery.Size = new Size(97, 23);
            cb_Recovery.TabIndex = 17;
            cb_Recovery.Text = "STATUS";
            // 
            // btn_Recovery
            // 
            btn_Recovery.Location = new Point(271, 258);
            btn_Recovery.Name = "btn_Recovery";
            btn_Recovery.Size = new Size(67, 23);
            btn_Recovery.TabIndex = 18;
            btn_Recovery.Text = "Recuperar";
            btn_Recovery.UseVisualStyleBackColor = true;
            btn_Recovery.Click += btn_Recovery_Click;
            // 
            // lbl_TotalSpentValue
            // 
            lbl_TotalSpentValue.AutoSize = true;
            lbl_TotalSpentValue.BackColor = SystemColors.ControlLight;
            lbl_TotalSpentValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_TotalSpentValue.Location = new Point(12, 98);
            lbl_TotalSpentValue.Name = "lbl_TotalSpentValue";
            lbl_TotalSpentValue.Size = new Size(62, 15);
            lbl_TotalSpentValue.TabIndex = 19;
            lbl_TotalSpentValue.Text = "-----------";
            // 
            // btn_GetTotalValue
            // 
            btn_GetTotalValue.Location = new Point(115, 94);
            btn_GetTotalValue.Name = "btn_GetTotalValue";
            btn_GetTotalValue.Size = new Size(75, 23);
            btn_GetTotalValue.TabIndex = 20;
            btn_GetTotalValue.Text = "Buscar";
            btn_GetTotalValue.UseVisualStyleBackColor = true;
            btn_GetTotalValue.Click += btn_GetTotalValue_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 21;
            label2.Text = "VALOR TOTAL DA FATURA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(158, 15);
            label3.TabIndex = 22;
            label3.Text = "VALOR TOTAL POR PESSOA";
            // 
            // lbl_TotalByName
            // 
            lbl_TotalByName.AutoSize = true;
            lbl_TotalByName.BackColor = SystemColors.ControlLight;
            lbl_TotalByName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_TotalByName.Location = new Point(12, 165);
            lbl_TotalByName.Name = "lbl_TotalByName";
            lbl_TotalByName.Size = new Size(77, 15);
            lbl_TotalByName.TabIndex = 23;
            lbl_TotalByName.Text = "--------------";
            // 
            // txtb_ValueTotalName
            // 
            txtb_ValueTotalName.Location = new Point(179, 162);
            txtb_ValueTotalName.Name = "txtb_ValueTotalName";
            txtb_ValueTotalName.PlaceholderText = "NOME";
            txtb_ValueTotalName.Size = new Size(86, 23);
            txtb_ValueTotalName.TabIndex = 24;
            // 
            // btn_SearchByName
            // 
            btn_SearchByName.Location = new Point(271, 161);
            btn_SearchByName.Name = "btn_SearchByName";
            btn_SearchByName.Size = new Size(67, 23);
            btn_SearchByName.TabIndex = 25;
            btn_SearchByName.Text = "Buscar";
            btn_SearchByName.UseVisualStyleBackColor = true;
            btn_SearchByName.Click += btn_SearchByName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1200, 599);
            Controls.Add(btn_SearchByName);
            Controls.Add(txtb_ValueTotalName);
            Controls.Add(lbl_TotalByName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_GetTotalValue);
            Controls.Add(lbl_TotalSpentValue);
            Controls.Add(btn_Recovery);
            Controls.Add(cb_Recovery);
            Controls.Add(txtb_Recovery);
            Controls.Add(label8);
            Controls.Add(btn_Delete);
            Controls.Add(txtb_Delete);
            Controls.Add(cb_status);
            Controls.Add(lbl_Month);
            Controls.Add(label7);
            Controls.Add(btn_Payment);
            Controls.Add(btn_FindAll);
            Controls.Add(pnl_Register);
            Controls.Add(label1);
            Controls.Add(txtbx_FindByName);
            Controls.Add(btn_FindByName);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador  de Parcelas v1.0.2";
            Load += Form1_Connection;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_FindByName;
        private TextBox txtbx_FindByName;
        private Label label1;
        private Panel pnl_Register;
        private Button btn_FindAll;
        private Button btn_Payment;
        private Label label7;
        private Label lbl_Month;
        private ComboBox cb_status;
        private TextBox txtb_Delete;
        private Button btn_Delete;
        private Label label8;
        private TextBox txtb_Recovery;
        private ComboBox cb_Recovery;
        private Button btn_Recovery;
        private Label lbl_TotalSpentValue;
        private Button btn_GetTotalValue;
        private Label label2;
        private Label label3;
        private Label lbl_TotalByName;
        private TextBox txtb_ValueTotalName;
        private Button btn_SearchByName;
    }
}
