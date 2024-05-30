using PizzariaFornoDivino.Controller;
using PizzariaFornoDivino.Model;
using PizzariaFornoDivino.Views.Cadastro;
using PizzariaFornoDivino.Views.home;
using PizzariaFornoDivino.Views.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaFornoDivino.Views
{
    public partial class Dashboard : Form
    {
        private ClientesController ClientesController;
        private Clientes clientes;


        private Boolean showPnCadastro = false;
        private Boolean showPnPedidos = false;


        Home dashboard = new Home();
        CadastroCliente cadastro = new CadastroCliente();
        AlteraCliente alterar = new AlteraCliente();
        IncluirPedido incluirPedido = new IncluirPedido();
        TodosPedidos pedidos = new TodosPedidos();

        public Dashboard()
        {

            InitializeComponent();
            tooglePanels();
            panelControler.Controls.Clear();
            panelControler.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            ClientesController = new ClientesController();
            clientes = new Clientes();
        }



        private void tooglePanels()
        {
            if (showPnCadastro)
            {
                PnCadastro.Height = 85;
            }
            else
            {
                PnCadastro.Height = 0;
            }

            if (showPnPedidos)
            {
                PnPedidos.Height = 85;
            }
            else
            {
                PnPedidos.Height = 0;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            showPnPedidos = false;

            showPnCadastro = !showPnCadastro;

            tooglePanels();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            showPnCadastro = false;

            showPnPedidos = !showPnPedidos;

            tooglePanels();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Deseja Fechar o Sistema", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            panelControler.Controls.Clear();
            panelControler.Controls.Add(cadastro);
            cadastro.Dock = DockStyle.Fill;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelControler.Controls.Clear();
            panelControler.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
        }

        private async void btnAlterarCliente_Click(object sender, EventArgs e)
        {

            panelControler.Controls.Clear();
            panelControler.Controls.Add(alterar);
            alterar.Dock = DockStyle.Fill;
        }

         private void btnIncluir_Click(object sender, EventArgs e)
        {
            panelControler.Controls.Clear();
            panelControler.Controls.Add(incluirPedido);
            incluirPedido.Dock = DockStyle.Fill;
        }

        private void btnTdPedidos_Click(object sender, EventArgs e)
        {
            panelControler.Controls.Clear();
            panelControler.Controls.Add(pedidos);
            pedidos.Dock = DockStyle.Fill;
        }

       
    }
}
