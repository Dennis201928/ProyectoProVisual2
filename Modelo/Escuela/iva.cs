using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Escuela
{
    public class iva : IDBEntity
    {

        public float im_sali_divisas { get; set; }
        public float im_val_agregado { get; set; }
        public float arancel { get; set; }
        public float imrodaje { get; set; }
        public float im_sali_divisas_isd { get; set; }

        public List<venta> ventas { get; set; }
        public int ivaId { get; set; }

        float totalIva;
        
        public float TotalIva { get { return totalIva; } set { totalIva = im_sali_divisas + im_val_agregado + arancel + imrodaje + im_sali_divisas_isd; } } 

        //public float NotaIva(float im_sali_divisas, float im_val_agregado, float arancel, float imrodaje, float im_sali_divisas_isd)
        //{
        //    // Cálculo
        //   Resolve



        //    return suma;
        //}

    }
}
