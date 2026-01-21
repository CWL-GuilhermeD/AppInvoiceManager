using InvoiceDataAccess.Configuration;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppInvoiceManager
{
    public partial class Form3 : Form
    {
        private readonly Conn _context;
        private readonly ServiceSpent _service;
        public event EventHandler? FlagUpdate;
        public Form3()
        {
            _context = new Conn();
            _service = new ServiceSpent(_context);
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private async void btn_Register_Click_1(object sender, EventArgs e)
        {
            string[] fields = { txtb_ShopName.Text, txtb_Value.Text, txtb_InitialParcel.Text, txtb_FinalParcel.Text, txtb_Name.Text };
            try
            {
                if (CheckFields.Check_Register_Fields(fields))
                {

                    SpentModel spent = new SpentModel();
                    spent.SpentName = txtb_ShopName.Text.ToUpper();
                    spent.SpentValue = Convert.ToDouble(txtb_Value.Text);
                    spent.InitialParcel = Convert.ToInt32(txtb_InitialParcel.Text);
                    spent.FinalParcel = Convert.ToInt32(txtb_FinalParcel.Text);
                    spent.NameClient = txtb_Name.Text.ToUpper();

                    await _service.SaveSpentAsync(spent);

                    txtb_ShopName.Clear();
                    txtb_Value.Clear();
                    txtb_InitialParcel.Clear();
                    txtb_FinalParcel.Clear();
                    txtb_Name.Clear();

                    MessageBox.Show("Pendencia Adicionada. Busque as Pendências novamente.");


                }
                else
                {
                    MessageBox.Show("TODOS OS CAMPOS DEVEM SER PREENCHIDOS.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btn_Clear_Click(object sender, EventArgs e)
        {
            txtb_ShopName.Clear();
            txtb_Value.Clear();
            txtb_InitialParcel.Clear();
            txtb_FinalParcel.Clear();
            txtb_Name.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            FlagUpdate?.Invoke(this, EventArgs.Empty);
        }
    }
}
