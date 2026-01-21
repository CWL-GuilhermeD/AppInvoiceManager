namespace AppInvoiceManager
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Clear = new Button();
            btn_Update = new Button();
            label3 = new Label();
            txtb_FinalParcel = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtb_Name = new TextBox();
            txtb_InitialParcel = new TextBox();
            txtb_Value = new TextBox();
            txtb_ShopName = new TextBox();
            label2 = new Label();
            btn_Register = new Button();
            SuspendLayout();
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(110, 207);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(88, 28);
            btn_Clear.TabIndex = 26;
            btn_Clear.Text = "Limpar";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(14, 207);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(88, 28);
            btn_Update.TabIndex = 25;
            btn_Update.Text = "Atualizar";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(14, 46);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 24;
            label3.Text = "LOJA";
            // 
            // txtb_FinalParcel
            // 
            txtb_FinalParcel.Location = new Point(208, 122);
            txtb_FinalParcel.Name = "txtb_FinalParcel";
            txtb_FinalParcel.PlaceholderText = "FINAL";
            txtb_FinalParcel.Size = new Size(85, 23);
            txtb_FinalParcel.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(14, 170);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 22;
            label6.Text = "PAGADOR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(14, 125);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 21;
            label5.Text = "PARCELAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(14, 83);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 20;
            label4.Text = "VALOR";
            // 
            // txtb_Name
            // 
            txtb_Name.Location = new Point(113, 167);
            txtb_Name.Name = "txtb_Name";
            txtb_Name.PlaceholderText = "NOME";
            txtb_Name.Size = new Size(180, 23);
            txtb_Name.TabIndex = 19;
            // 
            // txtb_InitialParcel
            // 
            txtb_InitialParcel.AccessibleDescription = "";
            txtb_InitialParcel.AccessibleName = "";
            txtb_InitialParcel.Location = new Point(113, 122);
            txtb_InitialParcel.Name = "txtb_InitialParcel";
            txtb_InitialParcel.PlaceholderText = "INICIAL";
            txtb_InitialParcel.Size = new Size(85, 23);
            txtb_InitialParcel.TabIndex = 18;
            txtb_InitialParcel.Tag = "";
            // 
            // txtb_Value
            // 
            txtb_Value.Location = new Point(113, 80);
            txtb_Value.Name = "txtb_Value";
            txtb_Value.PlaceholderText = "VALOR";
            txtb_Value.Size = new Size(180, 23);
            txtb_Value.TabIndex = 17;
            // 
            // txtb_ShopName
            // 
            txtb_ShopName.Location = new Point(113, 38);
            txtb_ShopName.Name = "txtb_ShopName";
            txtb_ShopName.PlaceholderText = "LOJA";
            txtb_ShopName.Size = new Size(180, 23);
            txtb_ShopName.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(87, 11);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 14;
            label2.Text = "CADASTRAR PENDENCIA";
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(205, 207);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(88, 28);
            btn_Register.TabIndex = 15;
            btn_Register.Text = "Cadastrar";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(307, 247);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Update);
            Controls.Add(label3);
            Controls.Add(txtb_FinalParcel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtb_Name);
            Controls.Add(txtb_InitialParcel);
            Controls.Add(txtb_Value);
            Controls.Add(txtb_ShopName);
            Controls.Add(label2);
            Controls.Add(btn_Register);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Clear;
        private Button btn_Update;
        private Label label3;
        private TextBox txtb_FinalParcel;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtb_Name;
        private TextBox txtb_InitialParcel;
        private TextBox txtb_Value;
        private TextBox txtb_ShopName;
        private Label label2;
        private Button btn_Register;
    }
}