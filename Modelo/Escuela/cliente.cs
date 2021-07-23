﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Escuela
{
    public class cliente : IDBEntity
    {
        public int clienteId { get; set; }
        public string nombre { get; set; }
        public string edad { get; set; }

        public genero genero { get; set; }
        public int generoId { get; set; }


        public List<venta> ventas { get; set; }

    }
}