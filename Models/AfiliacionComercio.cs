using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto1.Models
{
    public partial class AfiliacionComercio
    {
        public AfiliacionComercio()
        {
            Comida = new HashSet<Comida>();
            Productos = new HashSet<Producto>();
        }

        public int IdComercio { get; set; }
        public string Nombre { get; set; }
        public string Decripcion { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Comida> Comida { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
