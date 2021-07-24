using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Escuela
{
    public class genero : IDBEntity
    {
        public int generoId { get; set; }
        public string nomgenero { get; set; }

        public List<cliente> clientes { get; set; }

    }
}
