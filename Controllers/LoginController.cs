using Microsoft.AspNetCore.Mvc;
using Proyecto1.Models;
using Proyecto1.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Newtonsoft.Json.Linq;

namespace Proyecto1.Controllers
{
    public class LoginController : Controller
    {

        private readonly Order2GoContext _context;

        public LoginController(Order2GoContext context)
        {
            _context = context;

        }



        public IActionResult Index()
        {
            return View();
        }



        [BindProperty]
        public UsuarioVM usuario { get; set; }
        public object HashHelper { get; private set; }

        public async Task<IActionResult> Login()
        {

            if (!ModelState.IsValid)
            {
                return BadRequestResult(new JObject() {
            { "StatusCode", 400},
            { "Message", "El usuario ya existe, seleccione otro"}


                });


            }
            else
            {
                var result = await _context.Usuarios.Where(x => x.Usuario1 == usuario.Usuario1).SingleOrDefaultAsync();

                if (result == null)
                {
                    return NotFound(new JObject
                {
                   { "StatusCode", 400},
            { "Message", "Usuario no encontrado"}


                });

                }
            }


            return View();

        }


        /*public static bool CheckHash(String attempedPassword, string hash, string salt)
                {
                    string hashed = Convert.ToBase64String(KeyDerivation.Pbkf)

                }
        */
        private IActionResult BadRequestResult(JObject jObject)
        {
            throw new NotImplementedException();
        }
    }
}
