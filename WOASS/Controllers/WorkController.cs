using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WOASS.Models;

namespace WOASS.Controllers
{
    public class WorkController : Controller
    {
        // F i e l d s   &    P r o p e r t i e s

        private IWorkRepository _repository;

        // C o n s t r u c t o r s

        public WorkController(IWorkRepository repository)
        {
            _repository = repository;
        }


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
            /*IQueryable<Work> allWork;
            allWork = _repository.GetAllWork();*/
            return View(_repository.GetAllWork());
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
