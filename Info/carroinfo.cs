
using Modelo;
using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfo
{
    class carroinfo : IEntityInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            carro config = (carro)entidad;
            return String.Format("CarroId: {0} \n" +
                          "ModeloId: {1} \n" +
                          "MarcaId: {2} \n",
                         
                config.carroId,
                config.modeloId,
                config.marcaId
                
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
