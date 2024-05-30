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
using System.Text.Json;
using PizzariaFornoDivino.Controller;

namespace PizzariaFornoDivino.Views
{
    public partial class CadastroCliente : UserControl
    {
        private ClientesController ClientesController;
        private Clientes clientes;
        private Cliente cliente;

        


        public CadastroCliente()
        {
            InitializeComponent();
            ClientesController = new ClientesController();
            clientes = new Clientes();
            cliente = new Cliente();
        }

       

        private async void btnSalvar_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            string endereco = txtEndereco.Text + txtNumero + txtBairro.Text;
            string telefone = txtTelefone.Text;
            string complemento = txtComplemento.Text;
            string email = txtEmail.Text;
            string cep = txtCep.Text;

            Cliente newCliente = new Cliente
            {
                nome = nome,
                endereco = endereco,
                telefone = telefone,
                complemento = complemento,
                email = email,
                cep = cep,
            };

             bool result = await ClientesController.AddCliente(newCliente);

            if (result)
            {
                MessageBox.Show("Cliente adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao adicionar cliente.");
            }
        }
    }
}
