using PizzariaFornoDivino.Controller;
using PizzariaFornoDivino.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaFornoDivino.Views.Pedidos
{
    public partial class TodosPedidos : UserControl
    {
        private PedidosController PedidosController;
        private Model.Pedidos pedidos;

        public TodosPedidos()
        {
            InitializeComponent();
            PedidosController = new PedidosController();
            pedidos = new Model.Pedidos();
            
        }
        
        private async void GetPedidos()
        {
            pedidos = await PedidosController.GetAllPedidos();

            if (pedidos != null)
            {
                foreach (var pedido in pedidos?.pedidos!)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPedidos);

                    row.Cells[0].Value = pedido.codpedido;
                    row.Cells[1].Value = pedido.nome;
                    row.Cells[2].Value = pedido.telefone;
                    row.Cells[3].Value = pedido.endereco;
                    row.Cells[4].Value = pedido.complemento;
                    row.Cells[5].Value = pedido.descricao;
                    row.Cells[6].Value = pedido.fpage;
                    row.Cells[7].Value = pedido.status;
                    row.Cells[8].Value = pedido.vlunit;
                    row.Cells[9].Value = pedido.vltotal;
                    row.Cells[10].Value = pedido.created_at;
                    row.Cells[11].Value = pedido.updated_at;

                    dgvPedidos.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel carregar os dados da api", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            GetPedidos();
        }
    }
}
