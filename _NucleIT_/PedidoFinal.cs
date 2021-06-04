using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _NucleIT_
{
    public class PedidoFinal
    {

        public PedidoFinal(List<Items> Plistado)
        {
            int total = 0;
            foreach (var item in Plistado)
            {
                total += item.Total;
            }
            this.Productos = Plistado;
            this.Total = total;
        }

        public int numero { get; set; }
        public string Cliente { get; set; }
        public string Mozo { get; set; }
        public List<Items> Productos { get; set; }
        public string Fecha { get; set; }
        public int Total { get; set; }
    }

}