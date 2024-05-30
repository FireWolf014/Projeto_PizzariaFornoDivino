using PizzariaFornoDivino.Controller;
using PizzariaFornoDivino.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaFornoDivino.Views.Cadastro
{
    public partial class AlteraCliente : UserControl
    {
        private ClientesController ClientesController;
        private Clientes clientes;
        public AlteraCliente()
        {
            InitializeComponent();
            ClientesController = new ClientesController();
            clientes = new Clientes();
        }

        private async void GetClientes()
        {
            clientes = await ClientesController.GetAllClientes();

            if (clientes != null)
            {
                foreach (var cliente in clientes?.clientes!)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvClientes);

                    row.Cells[0].Value = cliente.nome;
                    row.Cells[1].Value = cliente.endereco;
                    row.Cells[2].Value = cliente.telefone;
                    row.Cells[3].Value = cliente.complemento;
                    row.Cells[4].Value = cliente.email;
                    row.Cells[5].Value = cliente.cep;
                    row.Cells[6].Value = cliente.created_at;
                    row.Cells[7].Value = cliente.updated_at;

                    dgvClientes.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel carregar os dados da api", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            GetClientes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CadastroCliente cadastro = new CadastroCliente();
            cadastro.Show();
        }
    }
}
