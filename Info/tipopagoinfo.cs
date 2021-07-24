using Modelo;
using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfo
{
    class tipopagoinfo : IEntityInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            tipopago config = (tipopago)entidad;
            return String.Format("TipoPagoId: {0} \n" +
                          "NombreDePago: {1} \n",
                config.tipopagoId,
                config.nombreTipoPago
                


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
