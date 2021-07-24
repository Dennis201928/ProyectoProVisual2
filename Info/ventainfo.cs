using Modelo;
using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfo
{
    class ventainfo : IEntityInfo
    {

        public string Publicar(IDBEntity entidad)
        {
            venta config = (venta)entidad;
            return String.Format("VentaId: {0} \n" +
                          "ClienteId: {1} \n"+
                          "CarroId: {2} \n" +
                          "Tipo PagoId: {3} \n" +
                          "IvaId: {4} \n" +
                          "Total: {5} \n" ,

                config.ventaId,
                config.clienteId,
                  config.carroId,
                config.tipopagoId,
                  config.ivaId,
                config.total


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
