using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Escuela
{
    public class tipopago : IDBEntity
    {

        public int tipopagoId { get; set; }
        public string nombre { get; set; }

        public List<venta> ventas { get; set; }
    }
}
