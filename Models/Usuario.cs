using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto1.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string TipoUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Password { get; set; }
        public DateTime? FechaIngreso { get; set; }
    }
}
