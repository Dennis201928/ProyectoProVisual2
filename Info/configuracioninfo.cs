
using Modelo;
using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfo
{
    class configuracioninfo : IEntityInfo
    {


        public string Publicar(IDBEntity entidad)
        {
            Configuracion config = (Configuracion)entidad;
            return String.Format("ConfigId: {0} \n" +
                          "Valor Minimo: {1} \n" ,


                config.configId,
                config.valormin


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
