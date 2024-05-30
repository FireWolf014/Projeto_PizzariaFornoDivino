using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaFornoDivino.Model
{
    internal class Pedidos
    {
        public int id { get; set; }
        public List<Pedido>? pedidos { get; set; }
    }
}
