/*
 Gaspard Mucundanyi
 Robert Rugamba
 */

//THERE ARE MANY THINGS TO CHANGE ON OC
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//HOPE WE WILL USE THE SAME CONCEPT IN NEXT CLASS IN HOBBY LOBBY 

namespace OC_Menu.Controllers
    // REMEMBER TO WRITE THE CONTROLLER NAME
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        

        public ActionResult Index()
        {
            // Create an instance of the cafeteria class
            Models.Cafeteria Cafe = new Models.Cafeteria();
            Models.Line line = new Models.Line();
            List<Models.Line> lines = new List<Models.Line>();
            /* 
             Now populate the Cafeteria object with required info
             ie Menu for the OC Cafeteria, Breakfast, Lunch, Dinner 
            */
            
            // testing with the breakfast menu first
            line.Line_List = Cafe.Breakfast();
            Cafe.Line_List = line.Line_List;
          
            return View(Cafe);
        }
    }
}
