﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FacturaBE
    {
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        
        public int IdCliente { get; set; }
        public float Total { get; set; }
    }
}
