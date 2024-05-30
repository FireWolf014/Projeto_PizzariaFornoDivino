using Newtonsoft.Json;
using PizzariaFornoDivino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaFornoDivino.Controller
{
    internal class PedidosController
    {

        private HttpClient client;

        public PedidosController()
        {
            client = new HttpClient();

           
        }

        public async Task<Pedidos> GetAllPedidos()
        {
            try
            {
                Pedidos pedidos = new Pedidos();
                HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:8000/api/pedidos");

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                pedidos = JsonConvert.DeserializeObject<Pedidos>(responseJson);

                return pedidos;

            }
            catch (Exception)
            {
                return null;

            }
        }

        public async Task<bool> AddPedido(Pedido newPedido)
        {
            try
            {
                // Serializa o objeto newCliente para JSON
                string clienteJson = JsonConvert.SerializeObject(newPedido);
                // Cria o conteúdo da requisição com o JSON
                StringContent content = new StringContent(clienteJson, Encoding.UTF8, "application/json");

                // Envia a requisição POST
                HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:8000/api/clientes", content);

                // Garante que a resposta foi um sucesso
                response.EnsureSuccessStatusCode();

                // Se a resposta for bem-sucedida, retorna true
                return true;
            }
            catch (Exception)
            {
                // Em caso de exceção, retorna false
                return false;
            }
        }



    }
}
