//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BurgerDEVApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zona
    {
        public Zona()
        {
            this.Sucursal = new HashSet<Sucursal>();
            this.Coordenada = new HashSet<Coordenada>();
        }
    
        public int iZonaId { get; set; }
        public string sNombreZona { get; set; }
    
        public virtual ICollection<Sucursal> Sucursal { get; set; }
        public virtual ICollection<Coordenada> Coordenada { get; set; }
    }
}
