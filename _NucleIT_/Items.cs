using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _NucleIT_
{
    public class Items
    {
        public Items(int p0, int p1)
        {
            this.Total = p0 * p1;
            this.Cantidad = p1;
            this.Precio = p0;
        }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Total { get; set; }
    }
}