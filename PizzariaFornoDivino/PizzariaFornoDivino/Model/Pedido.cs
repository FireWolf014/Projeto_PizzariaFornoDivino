using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaFornoDivino.Model
{

    public class Pedido
    {
        
        public int codpedido { get; set; }
        public string? telefone { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public decimal? vlunit { get; set; }
        public string? status { get; set; }
        public string? fpage { get; set; }
        public decimal? vltotal { get; set; }
        public string? endereco { get; set; }
        public string? complemento { get; set; }
        public string? cdcard { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        
    }

}
