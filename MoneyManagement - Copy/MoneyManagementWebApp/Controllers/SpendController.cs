using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoneyManagementLibrary.DataAccess;
using MoneyManagementLibrary.Repository;

namespace MoneyManagementWebApp.Controllers
{
    public class SpendController : Controller
    {
        DatasRepository<Spend> spendRepository = new DatasRepository<Spend>();
        IDataRepository dataRepository = new DataRepository();
        // GET: SpendController
        public ActionResult Index()
        {
            var list = spendRepository.GetAll();
            return View(list);
        }

        // GET: SpendController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null) return NotFound();
            var spend = spendRepository.GetObjectByID(id);

            if (spend == null) return NotFound();
            ViewBag.Category = dataRepository.GetCateSpendById(spend.CateId);
            return View(spend);
        }

        // GET: SpendController/Create
        public ActionResult Create()
        {
            ViewBag.Category = dataRepository.GetCateSpend();
            return View();
        }

        // POST: SpendController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Spend spend)
        {
            try
            {
                spendRepository.Insert(spend);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SpendController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
                return NotFound();
            var spend = spendRepository.GetObjectByID(id);
            if (spend == null)
                return NotFound();
            return View(spend);
        }

        // POST: SpendController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Spend spend)
        {
            try
            {
                if (id != spend.Id) return NotFound();
                spendRepository.Update(spend);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: SpendController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var spend = spendRepository.GetObjectByID(id.Value);
            if (spend == null)
                return NotFound();
            return View();
        }

        // POST: SpendController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                spendRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
