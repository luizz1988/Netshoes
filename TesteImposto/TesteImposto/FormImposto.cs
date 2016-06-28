using Imposto.Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imposto.Core.Domain;
using TesteImposto.Properties;

namespace TesteImposto
{
    public partial class FormImposto : Form
    {
        #region Propriedades
        private Pedido pedido = new Pedido();
        private Dictionary<string, string> estados = new Dictionary<string, string>();
        #endregion

        #region Metodos Publicos
        public FormImposto()
        {
            InitializeComponent();
            dataGridViewPedidos.AutoGenerateColumns = false;
            // dataGridViewPedidos.DataSource = GetTablePedidos();
            //ResizeColumns();

            //Carrega Lista de Estados 
            this.CarregarEstados();

            //Carrega Dados dos Combos
            this.LoadComboEstados();

        }
        #endregion

        #region Metodos Privados

        //private void ResizeColumns()
        //{
        //    double mediaWidth = dataGridViewPedidos.Width / dataGridViewPedidos.Columns.GetColumnCount(DataGridViewElementStates.Visible);

        //    for (int i = dataGridViewPedidos.Columns.Count - 1; i >= 0; i--)
        //    {
        //        var coluna = dataGridViewPedidos.Columns[i];
        //        coluna.Width = Convert.ToInt32(mediaWidth);
        //    }   
        //}

        //private object GetTablePedidos()
        //{
        //    DataTable table = new DataTable("pedidos");
        //    table.Columns.Add(new DataColumn("Nome do produto", typeof(string)));
        //    table.Columns.Add(new DataColumn("Codigo do produto", typeof(string)));
        //    table.Columns.Add(new DataColumn("Valor", typeof(decimal)));
        //    table.Columns.Add(new DataColumn("Brinde", typeof(bool)));

        //    return table;
        //}

        /// <summary>
        /// Populo a lista de estados 
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> CarregarEstados()
        {
            estados.Add("SP", "SP");
            estados.Add("RJ", "RJ");
            estados.Add("PA", "PA");
            estados.Add("PB", "PB");
            estados.Add("PE", "PE");
            estados.Add("PI", "PI");
            estados.Add("PR", "PR");
            estados.Add("RO", "RO");
            estados.Add("SE", "SE");
            estados.Add("TO", "TO");
            estados.Add("MG", "MG");

            return estados;

        }

        /// <summary>
        /// Carrego os combos de Estados da tela
        /// </summary>
        private void LoadComboEstados()
        {

            //================
            cboEstadoOrigem.DataSource = estados.ToList();
            cboEstadoOrigem.ValueMember = "value";
            cboEstadoOrigem.DisplayMember = "key";


            //================
            cboEstadoDestino.DataSource = estados.ToList();
            cboEstadoDestino.ValueMember = "value";
            cboEstadoDestino.DisplayMember = "key";
        }

        private void buttonGerarNotaFiscal_Click(object sender, EventArgs e)
        {
            if (!this.ValidaGerarNota())
            {
                return;
            }

            try
            {



                NotaFiscalService service = new NotaFiscalService();
                pedido.EstadoOrigem = cboEstadoOrigem.SelectedValue.ToString();
                pedido.EstadoDestino = cboEstadoDestino.SelectedValue.ToString();
                pedido.NomeCliente = textBoxNomeCliente.Text;

                //DataTable table = (DataTable)dataGridViewPedidos.DataSource;

                foreach (DataGridViewRow row in dataGridViewPedidos.Rows)
                {
                    if (row.Cells["NomeProduto"].Value == null)
                    {
                        continue;
                    }

                    pedido.ItensDoPedido.Add(
                        new PedidoItem()
                        {
                            Brinde = row.Cells["Brinde"].Selected,
                            CodigoProduto = row.Cells["CodigoProduto"].Value.ToString(),
                            NomeProduto = row.Cells["NomeProduto"].Value.ToString(),
                            ValorItemPedido = Convert.ToDouble(row.Cells["Valor"].Value)
                        });
                }

                service.GerarNotaFiscal(pedido);
                MessageBox.Show("Operação efetuada com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); ;


            }
        }

        /// <summary>
        /// Efetua a validação da tela
        /// </summary>
        /// <returns></returns>
        private bool ValidaGerarNota()
        {

            if (string.IsNullOrEmpty(textBoxNomeCliente.Text))
            {
                MessageBox.Show(Resources.NomeBranco, Resources.Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBoxNomeCliente.Focus();
                return false;
            }


            if (cboEstadoDestino.SelectedIndex == -1)
            {
                MessageBox.Show(Resources.SelecioneEstadoDestino, Resources.Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                cboEstadoDestino.Focus();
                return false;
            }

            if (cboEstadoOrigem.SelectedIndex == -1)
            {
                MessageBox.Show(Resources.SelecioneEstadoOrigem, Resources.Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                cboEstadoOrigem.Focus();
                return false;
            }

            if (dataGridViewPedidos.RowCount < 2)
            {
                MessageBox.Show(Resources.GridVazio, Resources.Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;

            }


            return true;
        }
        #endregion

        #region Eventos
        private void dataGridViewPedidos_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewPedidos.CurrentCell.ColumnIndex == 2)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Control_KeyPress);
                }
            }
        }
       
        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
             && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'     && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }
        #endregion
       
    }


}
