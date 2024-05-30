using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaFornoDivino.Model
{

    public class Cliente
    {
        
        public string? nome { get; set; }
        public string? endereco { get; set; }
        public string? telefone { get; set; }
        public string? complemento { get; set; }
        public string? email { get; set; }
        public string? cep { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

}
