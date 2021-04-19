using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WOASS.Models;
using WOASS.Models.ViewModels;

namespace WOASS.Controllers
{
    public class WorkController : Controller
    {
        // F i e l d s   &    P r o p e r t i e s

        private IWorkRepository _repository;
        private int pageSize = 3;

        // C o n s t r u c t o r s

        public WorkController(IWorkRepository repository)
        {
            _repository = repository;
        }


        //Create

        public ViewResult Add()
        {
            return View();
        }

        //Read

        public IActionResult Index()
        {
            WorkListViewModel wlvm = new WorkListViewModel();
            wlvm.WorkOrders = _repository.GetAllWork()
                                         .OrderBy(w => w.WorkId);

            return View(wlvm);
            //Go to the database and get all references
            //Have the View list all those refrences
            /*IQueryable<Work> allWork;
            allWork = _repository.GetAllWork();
            return View(allWork);*/
        }

        public IActionResult Index(int workPage = 1)
        {
            IQueryable<Work> someWork =
                   _repository.GetAllWork()
                              .OrderBy(w => w.WorkId)
                              .Skip((workPage - 1) * pageSize)
                              .Take(pageSize);
            return View(someWork);
        }

        public IActionResult Details(int id)
        {

            Work workOrder = _repository.GetWorkById(id);
            if (workOrder != null)
            {
                return View(workOrder);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Search(string keyword)
        {
            IQueryable<Work> workOrders = _repository.GetWorkByKeyword(keyword);
            return View(workOrders);
        }

        //Update

        [HttpGet]
        public IActionResult Update(int id)
        {
            Work work = _repository.GetWorkById(id);
            if (work != null)
            {
                return View(work);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Work work)
        {
            _repository.UpdateWork(work);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id = 0)
        {
            return View();
        }

        
        //Delete
    }
}
