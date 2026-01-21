namespace AppInvoiceManager
{
    partial class Form2
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
            btn_FindID = new Button();
            txtb_FindID = new TextBox();
            txtb_ShopName = new TextBox();
            btn_Update = new Button();
            txtb_Value = new TextBox();
            txtb_InitialParcel = new TextBox();
            txtb_FinalParcel = new TextBox();
            txtb_Name = new TextBox();
            btn_Clear = new Button();
            btn_Register = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btn_FindID
            // 
            btn_FindID.Location = new Point(220, 50);
            btn_FindID.Name = "btn_FindID";
            btn_FindID.Size = new Size(75, 23);
            btn_FindID.TabIndex = 0;
            btn_FindID.Text = "Buscar";
            btn_FindID.UseVisualStyleBackColor = true;
            btn_FindID.Click += btn_FindID_Click;
            // 
            // txtb_FindID
            // 
            txtb_FindID.Location = new Point(81, 51);
            txtb_FindID.Name = "txtb_FindID";
            txtb_FindID.PlaceholderText = "ID";
            txtb_FindID.Size = new Size(132, 23);
            txtb_FindID.TabIndex = 1;
            // 
            // txtb_ShopName
            // 
            txtb_ShopName.Location = new Point(81, 80);
            txtb_ShopName.Name = "txtb_ShopName";
            txtb_ShopName.PlaceholderText = "NOME DA LOJA";
            txtb_ShopName.Size = new Size(132, 23);
            txtb_ShopName.TabIndex = 2;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(207, 207);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(88, 28);
            btn_Update.TabIndex = 3;
            btn_Update.Text = "Atualizar";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // txtb_Value
            // 
            txtb_Value.Location = new Point(81, 109);
            txtb_Value.Name = "txtb_Value";
            txtb_Value.PlaceholderText = "VALOR DA COMPRA";
            txtb_Value.Size = new Size(132, 23);
            txtb_Value.TabIndex = 4;
            // 
            // txtb_InitialParcel
            // 
            txtb_InitialParcel.Location = new Point(81, 138);
            txtb_InitialParcel.Name = "txtb_InitialParcel";
            txtb_InitialParcel.PlaceholderText = "INICIAL";
            txtb_InitialParcel.Size = new Size(64, 23);
            txtb_InitialParcel.TabIndex = 5;
            // 
            // txtb_FinalParcel
            // 
            txtb_FinalParcel.Location = new Point(149, 138);
            txtb_FinalParcel.Name = "txtb_FinalParcel";
            txtb_FinalParcel.PlaceholderText = "FINAL";
            txtb_FinalParcel.Size = new Size(64, 23);
            txtb_FinalParcel.TabIndex = 6;
            // 
            // txtb_Name
            // 
            txtb_Name.Location = new Point(81, 169);
            txtb_Name.Name = "txtb_Name";
            txtb_Name.PlaceholderText = "NOME DO PAGADOR";
            txtb_Name.Size = new Size(132, 23);
            txtb_Name.TabIndex = 7;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(110, 207);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(88, 28);
            btn_Clear.TabIndex = 8;
            btn_Clear.Text = "Limpar";
            btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(12, 207);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(88, 28);
            btn_Register.TabIndex = 9;
            btn_Register.Text = "Cadastro";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(74, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 10;
            label1.Text = "ATUALIZAR PENDENCIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 12;
            label3.Text = "LOJA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(8, 112);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 13;
            label4.Text = "VALOR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(8, 141);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 14;
            label5.Text = "PARCELAS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(8, 172);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 15;
            label6.Text = "NOME";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(307, 247);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Register);
            Controls.Add(btn_Clear);
            Controls.Add(txtb_Name);
            Controls.Add(txtb_FinalParcel);
            Controls.Add(txtb_InitialParcel);
            Controls.Add(txtb_Value);
            Controls.Add(btn_Update);
            Controls.Add(txtb_ShopName);
            Controls.Add(txtb_FindID);
            Controls.Add(btn_FindID);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_FindID;
        private TextBox txtb_FindID;
        private TextBox txtb_ShopName;
        private Button btn_Update;
        private TextBox txtb_Value;
        private TextBox txtb_InitialParcel;
        private TextBox txtb_FinalParcel;
        private TextBox txtb_Name;
        private Button btn_Clear;
        private Button btn_Register;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}