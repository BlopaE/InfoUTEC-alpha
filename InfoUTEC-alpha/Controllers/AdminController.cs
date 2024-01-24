using InfoUTEC_alpha.Models;
using InfoUTEC_alpha.Services;
using Microsoft.AspNetCore.Mvc;

namespace InfoUTEC_alpha.Controllers
{
    public class AdminController : Controller
    {

        private readonly IUserService _userService;

        public AdminController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            //Utilizar el servicio de usuarios para comprobar los usuarios
            var users = await _userService.GetUsers();
            var model = new UsersViewModel() { Users = users };


            //Comprobar si el usuario está loggeado

            return View(model);
        }

        //Se utilizará si no hay usuario loggeado
        public IActionResult Login()
        {
            //Comprobar si ya hay un usuario loggeado para regresar Index
            return View();
        }
    }
}
