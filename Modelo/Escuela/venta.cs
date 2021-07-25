using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Escuela
{
    public class venta : IDBEntity
    {

        public int ventaId { get; set; }
        public cliente cliente { get; set; }
        public int clienteId { get; set; }

        public carro carro { get; set; }
        public int carroId { get; set; }

        public tipopago tipopago { get; set; }

        public int tipopagoId { get; set; }

        public int precio { get; set; }
        public iva iva { get; set; }
        public int ivaId { get; set; }
     

        public float total { get; set; }

        public String Estado { get; set; }


    }
}
