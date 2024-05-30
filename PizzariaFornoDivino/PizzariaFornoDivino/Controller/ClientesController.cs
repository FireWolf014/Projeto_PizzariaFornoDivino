using Newtonsoft.Json;
using PizzariaFornoDivino.Model;
using RestSharp;
using System.Text;
using System.Text.Json;

namespace PizzariaFornoDivino.Controller
{
    public class ClientesController
    {
        private HttpClient client;

        public ClientesController()
        {
            client = new HttpClient();
        }

        public async Task<Clientes> GetAllClientes()
        {
            try
            {
                Clientes clientes = new Clientes();
                HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:8000/api/clientes");

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                clientes = JsonConvert.DeserializeObject<Clientes>(responseJson);

                return clientes;

            }
            catch (Exception)
            {
                return null;

            }
        }

        public async Task<bool> AddCliente(Cliente newCliente)
        {
            try
            {
                Clientes clientes = new Clientes();
                string clienteJson = JsonConvert.SerializeObject(newCliente);

                StringContent content = new StringContent(clienteJson, Encoding.UTF8, "application/json");


                HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:8000/api/clientes", content);


                response.EnsureSuccessStatusCode();

                
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        //public async Task<bool> UpdateCliente(Cliente updatedCliente)
        //{
        //    try
        //    {
        //        Clientes clientes = new Clientes();
        //        // Serializa o objeto updatedCliente para JSON
        //        string clienteJson = JsonConvert.SerializeObject(updatedCliente);
        //        // Cria o conteúdo da requisição com o JSON
        //        StringContent content = new StringContent(clienteJson, Encoding.UTF8, "application/json");

        //        // Envia a requisição PUT
        //        HttpResponseMessage response = await client.PutAsync($"http://127.0.0.1:8000/api/clientes/{updatedCliente.Id}", content);

        //        // Garante que a resposta foi um sucesso
        //        response.EnsureSuccessStatusCode();

        //        // Se a resposta for bem-sucedida, retorna true
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        // Em caso de exceção, retorna false
        //        return false;
        //    }
        //}
    }
}

