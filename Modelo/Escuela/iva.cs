using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Escuela
{
    public class iva : IDBEntity
    {

        public int im_sali_divisas { get; set; }
        public int im_val_agregado { get; set; }
        public int arancel { get; set; }
        public int imrodaje { get; set; }
        public int im_sali_divisas_isd { get; set; }

        public List<venta> ventas { get; set; }
        public int ivaId { get; set; }
    }
}
