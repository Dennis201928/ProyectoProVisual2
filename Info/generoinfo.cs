
using Modelo;
using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfo
{
    class generoinfo : IEntityInfo
    {

        public string Publicar(IDBEntity entidad)
        {
            genero config = (genero)entidad;
            return String.Format("GeneroId: {0} \n" +
                          "Genero: {1} \n" ,
                       
                config.generoId,
                config.nomgenero
               

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
