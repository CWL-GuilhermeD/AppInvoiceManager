using System;
using System.Windows.Forms;
using System.Linq;
using InvoiceDataAccess;
using SQLitePCL;
using InvoiceDataAccess.Configuration;
using Service;
using System.Threading.Tasks;

namespace AppInvoiceManager
{
    public partial class Form1 : Form
    {
        private readonly Conn _context;
        private readonly ServiceSpent _service;

        public Form1()
        {
            InitializeComponent();
            _context = new Conn();
            _service = new ServiceSpent(_context);
            lbl_Month.Text = Alter_Mounth.Alter();

            OpenRegister();

        }

        private void Form1_Connection(object sender, EventArgs e)
        {

        }
        private void OpenFormOnPanel(Form form)
        {
            if (pnl_Register.Controls.Count > 0)
            {
                pnl_Register.Controls.Clear();
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnl_Register.Controls.Add(form);
            form.Show();
        }

        private void OpenRegister()
        {
            var form = new Form3();
            form.FlagUpdate += (s, e) => OpenUpdate();
            OpenFormOnPanel(form);
        }

        private void OpenUpdate()
        {
            var form = new Form2();
            form.FlagRegister += (s, e) => OpenRegister();
            OpenFormOnPanel(form);
        }

        private async void btn_FindAll_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = await _service.GetAllSpentsAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão: " + ex.Message);
            }
        }

        private async void btn_Payment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Deseja realmente marcar a fatura como paga.",
                    "Confirme",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

            if (result == DialogResult.Yes)
            {
                try
                {
                    await _service.CloseSpentAsync();
                    dataGridView1.DataSource = null;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private async void btn_FindByName_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbx_FindByName.Text != string.Empty)
                {
                    string status = "ATIVO";
                    switch (cb_status.Text)
                    {
                        case "ATIVOS":
                            status = "ATIVO";
                            break;

                        case "PAGOS":
                            status = "PAGO";
                            break;

                        case "DELETADOS":
                            status = "DELETADO";
                            break;

                        case "TODOS":
                            status = "TODOS";
                            break;
                    }
                    if (status != "TODOS")
                    {
                        dataGridView1.DataSource = await _service.FindPayerAsync(txtbx_FindByName.Text.ToUpper(), status);
                    }
                    else
                    {
                        dataGridView1.DataSource = await _service.FindPayerAllAsync(txtbx_FindByName.Text.ToUpper());

                    }

                }
                else
                {
                    MessageBox.Show("O CAMPO NOME DEVE SER PREENCHIDO.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Buscar por nome: " + ex.Message);
            }
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var spent = await _service.FindPayerByIdAsync(Convert.ToInt32(txtb_Delete.Text));
                if (spent != null)
                {
                    await _service.DisableShopAsync(Convert.ToInt32(txtb_Delete.Text));
                    MessageBox.Show("A PENDENCIA FOI DELETADA COM SUCESSO.");
                    dataGridView1.DataSource = await _service.GetAllSpentsAsync();



                }
                else
                {
                    MessageBox.Show("NÃO EXISTE PENDENCIA COM ESSE ID, TENTE OUTRO.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao deletar: " + ex.Message);
            }
        }

        private async void btn_Recovery_Click(object sender, EventArgs e)
        {
            try
            {
                var spent = await _service.FindPayerByIdAsync(Convert.ToInt32(txtb_Recovery.Text));

                if (spent != null)
                {
                    if (spent.Status != "DELETADO")
                    {
                        MessageBox.Show("ESSA PENDENCIA NÃO ESTÁ DELETADA.");
                    }
                    else
                    {
                        if (cb_Recovery.Text != null)
                        {
                            if (spent.InitialParcel > spent.FinalParcel && cb_Recovery.Text.Contains("ATIVO"))
                            {
                                MessageBox.Show("ESSA PENDENCIA JA FOI PAGA ASSIM NÃO PODENDO RETORNAR PARA ATIVO TENTE MUDAR PARA PAGO.");
                            }
                            else if (spent.InitialParcel <= spent.FinalParcel && cb_Recovery.Text.Contains("PAGO"))
                            {
                                MessageBox.Show("ESSA PENDENCIA AINDA NÃO FOI PAGA ASSIM NÃO PODENDO RETORNAR PARA O STATUS PAGO");
                            }
                            else
                            {
                                await _service.RecoveryPayerAsync(Convert.ToInt32(txtb_Recovery.Text), cb_Recovery.Text);
                                MessageBox.Show("O STATUS DA PENDENCIA FOI ATUALIZADA COM SUCESSO");
                            }
                        }
                        else
                        {
                            MessageBox.Show("O STATUS DEVE SER ESCOLHIDO");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async void btn_GetTotalValue_Click(object sender, EventArgs e)
        {
            try
            {
                double? value = await _service.SumTotalInvoice();
                if (value != null || value > 0)
                {
                    lbl_TotalSpentValue.Text = "R$ " + Convert.ToString(value);
                }
                else
                {
                    MessageBox.Show("A fatura não tem valor a pagar.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao obter o valor total : " + ex.Message);
            }
        }

        private async void btn_SearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                double? value = await _service.SumTotalByName(txtb_ValueTotalName.Text);

                if (txtb_ValueTotalName.Text != string.Empty)
                {
                    if (value != null && value > 0)
                    {
                        lbl_TotalByName.Text = txtb_ValueTotalName.Text + " deve R$ " + Convert.ToString(value);
                    }
                    else
                    {
                        MessageBox.Show("Não há pendencias para esse nome, verifique o nome.");
                    }
                }
                else
                {
                    MessageBox.Show("O nome é obrigatório.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao obter o valor total: " + ex.Message);
            }
            
        }
    }
}
