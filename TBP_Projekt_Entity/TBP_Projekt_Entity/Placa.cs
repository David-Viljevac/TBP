//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TBP_Projekt_Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Placa
    {
        public int placaID { get; set; }
        public int korisnikID { get; set; }
        public double Ukupan_Iznos { get; set; }
        public System.DateTime Pocetak_mjeseca { get; set; }
        public System.DateTime Kraj_mjeseca { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
    }
}
