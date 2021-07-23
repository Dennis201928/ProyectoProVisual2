using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Escuela
{
    public class modelo : IDBEntity
    {
        public int modeloId { get; set; }
        public string nombre_modelo { get; set; }

        public List<carro> carros { get; set; }

       


        public string color { get; set; }
        public int npuertas { get; set; }
    }
}
