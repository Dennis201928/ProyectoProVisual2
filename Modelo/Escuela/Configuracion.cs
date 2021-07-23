using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Escuela
{
    public class Configuracion : IDBEntity
    {

        public int configId { get; set; }
        public int valormin { get; set; }
        public int valormax { get; set; }
    }
}

