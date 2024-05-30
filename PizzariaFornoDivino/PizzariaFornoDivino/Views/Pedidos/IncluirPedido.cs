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
using static System.Net.Mime.MediaTypeNames;

namespace PizzariaFornoDivino.Views.Pedidos
{
    public partial class IncluirPedido : UserControl
    {
        PedidosController PedidosController;
        Model.Pedidos pedidos;
        Pedido pedido;

        public IncluirPedido()
        {
            InitializeComponent();
            PedidosController = new PedidosController();
            pedidos = new Model.Pedidos();
            pedido = new Pedido();
        }
        private int codAtendimento()
        {

            Random random = new Random();
            return random.Next(1, 1000);
        }
        private void IncluirPedido_Load(object sender, EventArgs e)
        {
            int resultado = codAtendimento();

            txtCod.Text = resultado.ToString();
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            string vlTotal = txtTotal.Text;
            string codigo = txtCod.Text;



            int codpedido = Convert.ToInt32(codigo);
            string telefone = txtCod.Text;
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            decimal vlunit = Convert.ToDecimal(vlTotal);
            string status = cbStatus.Text;
            string fpage = cbForma.Text;
            decimal vltotal = Convert.ToDecimal(vlTotal);
            string endereco = txtEndereco.Text+txtNumero.Text+txtBairro.Text;
            string complemento = txtComplemento.Text;
            string cdcard = "12312312312312";

            Pedido newPedido = new Pedido
            {
                codpedido = codpedido,
                telefone = telefone,
                nome = nome,
                descricao = descricao,
                vlunit = vlunit,
                status = status,
                fpage = fpage,
                vltotal = vltotal,
                endereco = endereco,
                complemento = complemento,
                cdcard = cdcard,
            };

            bool result = await PedidosController.AddPedido(newPedido);

            if (result)
            {
                MessageBox.Show("Pedido adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao adicionar Pedido.");
            }
        }
    }
}
