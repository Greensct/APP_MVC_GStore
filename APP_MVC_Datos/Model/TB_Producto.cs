//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APP_MVC_Datos.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Producto()
        {
            this.TB_Carrito = new HashSet<TB_Carrito>();
            this.TB_DetalleComprobante = new HashSet<TB_DetalleComprobante>();
        }
    
        public int idProd { get; set; }
        public string nomProd { get; set; }
        public decimal precio { get; set; }
        public string descripcion { get; set; }
        public byte[] foto { get; set; }
        public int idCategoria { get; set; }
        public int stock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Carrito> TB_Carrito { get; set; }
        public virtual TB_Categoria TB_Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_DetalleComprobante> TB_DetalleComprobante { get; set; }
    }
}
