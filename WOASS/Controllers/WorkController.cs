using Microsoft.AspNetCore.Mvc;
using WOASS.Models;

namespace WOASS.Controllers
{
    public class WorkController : Controller
    {

        //Create

        public ViewResult Add()
        {
            ViewResult answer = View();
            return answer;
        }

        //Read

        public IActionResult Index()
        {
            //Go to the database and get all references
            //Have the View list all those refrences
            return View();
        }

        public IActionResult Details(int id = 0)
        {

            //Go to the database and get 1 Reference based on the id received
            //Have the View display that reference
            Work board1 = new Work
            {
                Id = 1,
                OrderDate = "2020-02-09",
                Priority = false,
                WorkType = "base grind",
                PayStatus = true,
                PriceId = 2,
                GearId = 5,
                UserId = 2
            };
            return View(board1);
        }

        //Update

        public IActionResult Edit(int id = 0)
        {

            //Go to the database and get 1 Reference based on the id received
            //Have the View display that reference
            Work board1 = new Work
            {
                Id = 1,
                OrderDate = "2020-02-09",
                Priority = false,
                WorkType = "base grind",
                PayStatus = true,
                PriceId = 2,
                GearId = 5,
                UserId = 2
            };
            return View(board1);
        }

        //Delete
    }
}
