using Modelo;
using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfo
{
    class modeloinfo : IEntityInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            modelo config = (modelo)entidad;
            return String.Format("Nombre Marca: {0} \n" +
                          "ModeloId: {1} \n" +
                          "Color: {2} \n" +
                          "Num Puertas: {3} \n" ,
                config.nombre_modelo,
                config.modeloId,
                 config.color,
                  config.npuertas


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
