using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    [Authorize]
    
    public class AdminController : Controller
    {
        Model1 db = new Model1();
        // GET: Admin
        public ActionResult Index()
        {
            Wiewmodel vm = new Wiewmodel();
            vm.Ie_role = db.Roles.ToList();
            vm.Ie_table = db.Tables.ToList();
            vm.Ie_user = db.Users.ToList();
            return View(vm);
        }
        [HttpPost]
        public ActionResult Index(User_Role user_Role,FormCollection form)
        {
            User_Role model = new User_Role();
            model.Role_id = Convert.ToInt16(form["Rol"]);
            model.User_id = Convert.ToInt16(form["usr"]);
            model.Table_id = Convert.ToInt16(form["table"]);
            db.User_Role.Add(model);
            db.SaveChanges();
            return View();

        }
    }
}