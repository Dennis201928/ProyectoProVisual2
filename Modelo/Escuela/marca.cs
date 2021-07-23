using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Escuela
{
    public class marca : IDBEntity
    {
        public int marcaId { get; set; }

        public List<carro> carros { get; set; }
        public string nommarca { get; set; }







    }
}
