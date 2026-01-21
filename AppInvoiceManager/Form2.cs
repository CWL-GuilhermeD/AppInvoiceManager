using InvoiceDataAccess.Configuration;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInvoiceManager
{
    public partial class Form2 : Form
    {
        private readonly Conn _context;
        private readonly ServiceSpent _service;
        private SpentModel? spent;

        public event EventHandler? FlagRegister;
        public Form2()
        {
            _context = new Conn();
            _service = new ServiceSpent(_context);
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            FlagRegister?.Invoke(this, EventArgs.Empty);
        }

        private async void btn_FindID_Click(object sender, EventArgs e)
        {
            try
            {
                spent = await _service.FindPayerByIdAsync(Convert.ToInt32(txtb_FindID.Text));
                
                if (spent != null)
                {
                    txtb_ShopName.Text = spent?.SpentName;
                    txtb_Value.Text = Convert.ToString(spent?.SpentValue);
                    txtb_InitialParcel.Text = Convert.ToString(spent?.InitialParcel);
                    txtb_FinalParcel.Text = Convert.ToString(spent?.FinalParcel);
                    txtb_Name.Text = spent?.NameClient;

                }
                else
                {
                    MessageBox.Show("ESSE ID NÃO EXISTE TENTE OUTRO.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao buscar o ID: " + ex.Message);
            }

        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            string[] values = { txtb_ShopName.Text, txtb_Value.Text, txtb_InitialParcel.Text, txtb_FinalParcel.Text, txtb_Name.Text };
            try
            {
                if (spent != null)
                {
                    if (CheckFields.Check_Register_Fields(values))
                    {
                        await _service.UpdatePayerByID(Convert.ToInt32(txtb_FindID.Text),
                            txtb_ShopName.Text,
                            Convert.ToDouble(txtb_Value.Text),
                            Convert.ToInt32(txtb_InitialParcel.Text),
                            Convert.ToInt32(txtb_FinalParcel.Text),
                            txtb_Name.Text
                            );
                        MessageBox.Show("PENDENCIA ATUALIZADA COM SUCESSO.");
                    }
                    else
                    {
                        MessageBox.Show("TODOS OS CAMPOS DEVEM SER PREENCHIDOS PARA A ALTERAÇÃO");
                    }
                }
                else
                {
                    MessageBox.Show("NÃO NENHUMA PENDECIA FOI ENCONTRADA TENTE VERIFICAR O ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na atualização do dados: " + ex.Message);
            }
        }
    }
}
