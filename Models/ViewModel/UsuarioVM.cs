using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto1.Models.ViewModel
{
    public class UsuarioVM
    {

        [Requiered(ErrorMessage = "Escriba su usuario")]
        public string Usuario1 { get; set; }

        [Requiered(ErrorMessage = "Escriba su contraseña")]
        public string Password { get; set; }
    }
}
