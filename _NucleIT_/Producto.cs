//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _NucleIT_
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {

        public Producto()
        {
            this.productonombre = Nombre;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string productonombre { get; set; }
    }
}
