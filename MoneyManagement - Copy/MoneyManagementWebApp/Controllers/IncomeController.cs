using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoneyManagementLibrary.DataAccess;
using MoneyManagementLibrary.Repository;

namespace MoneyManagementWebApp.Controllers
{
    public class IncomeController : Controller
    {
        DatasRepository<Income> incomeRepository = null;
        DataRepository dataRepository = new DataRepository();
        public IncomeController()
        => incomeRepository = new DatasRepository<Income>();

        // GET: IncomeController
        public ActionResult Index()
        {
            var list = incomeRepository.GetAll();
            ViewBag.Category = dataRepository.GetCateIncome();
            return View(list);
        }

        public ActionResult Query(string search, string sort, 
            int[] category, DateTime? from, DateTime? to)
        {
            ViewBag.Search = search;
            ViewBag.Sort = sort;
            ViewBag.Cate = category;
            ViewBag.From = from;
            ViewBag.To = to;
            var list= dataRepository.GetAllIncomes(search, sort, category, from, to, 1);
            ViewBag.Category = dataRepository.GetCateIncome();
            return View(list);
        }

        // GET: IncomeController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
                return NotFound();

            Income item = incomeRepository.GetObjectByID(id);

            if (item == null)
                return NotFound();

            ViewBag.Category = dataRepository.GetCateIncomeById(item.CateId);
            return View(item);
        }

        // GET: IncomeController/Create
        public ActionResult Create()
        {
            ViewBag.Category = dataRepository.GetCateIncome();
            return View();
        }

        // POST: IncomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Income income)
        {


            try
            {
                incomeRepository.Insert(income);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(income);
            }
        }

        // GET: IncomeController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
                return NotFound();
            var income = incomeRepository.GetObjectByID(id);
            if (income == null)
                return NotFound();
            return View(income);
        }

        // POST: IncomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Income income)
        {
            try
            {
                if (id != income.Id) return NotFound();
                incomeRepository.Update(income);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: IncomeController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var income = incomeRepository.GetObjectByID(id.Value);
            if (income == null)
                return NotFound();
            return View();
        }

        // POST: IncomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                incomeRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
