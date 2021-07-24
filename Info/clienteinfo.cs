
using Modelo;
using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfo
{
    class clienteinfo : IEntityInfo
    {

        public string Publicar(IDBEntity entidad)
        {
            cliente config = (cliente)entidad;
            return String.Format( "ClienteId: {0} \n" +
                          "Nombre: {1} \n" +
                          "Edad: {2} \n" +
                          "GeneroId: {3} \n" ,

                config.clienteId,
                config.nombre,
                config.edad,
                 config.generoId

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
