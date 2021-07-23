using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Escuela
{
    public class carro : IDBEntity
    {
        public int carroId { get; set; }
        public modelo modelo { get; set; }
        public int modeloId { get; set; }

        public marca marca { get; set; }
        public int marcaId { get; set; }


        public List<venta> ventas { get; set; }

    }
}
