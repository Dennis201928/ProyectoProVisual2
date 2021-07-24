
using Modelo;
using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfo
{
    class marcainfo : IEntityInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            marca config = (marca)entidad;
            return String.Format("MarcaId: {0} \n" +
                          "Nombre Marca: {1} \n" ,
                         
                config.marcaId,
                config.nommarca
                

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
