
using Modelo;
using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfo
{
    class ivainfo : IEntityInfo
    {

        public string Publicar(IDBEntity entidad)
        {
            iva config = (iva)entidad;
            return String.Format("El impuesto a la salida de divisas: {0} \n" +
                          "Impuesto al valor agregado (IVA): {1} \n" +
                          "Arancel : {2} \n" +
                          " Impuesto al rodaje (GAD): {3} \n" +
                          "El impuesto a la salida de divisas (ISD): {4} \n" +
                          "VentaId: {5} \n" +
                          "Total Iva: {6} \n" ,

                config.im_sali_divisas,
                config.im_val_agregado,
                config.arancel,
                 config.imrodaje,
                 config.im_sali_divisas_isd,
                  config.ivaId,
                 config.TotalIva

                );
        }

        public string Publicar(IEnumerable<IDBEntity> ListaTipo)
        {
            var cadena = "";

            foreach (var item in ListaTipo)
            {
                cadena += Publicar(item) + "\n";
            }

            return cadena;
        }
    }
}
