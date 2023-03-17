using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MoneyManagementLibrary.DataAccess;
using MoneyManagementLibrary.Repository;

namespace MoneyManagementWebApp.Controllers
{
    public class LoanController : Controller
    {
        IDatasRepository<Loan> loanRepository = new DatasRepository<Loan>();
        IDataRepository dataRepository = new DataRepository();
        // GET: LoanController
        public ActionResult Index()
        {
            var list = loanRepository.GetAll();
            return View(list);
        }

        public ActionResult List(string search, DateTime? timeFrom, DateTime? timeTo, string sortMoney, string status, string deadline)
        {

            bool? _status = null;
            if (!status.IsNullOrEmpty())
            {
                if (status == "true")
                    _status = true;
                else if (status == "false")
                    _status = false;
            }
            bool? _deadline = null;
            if (!deadline.IsNullOrEmpty())
            {
                if (deadline == "true")
                    _deadline = true;
                else if (deadline == "false")
                    _deadline = false;
            }
            var list = dataRepository.GetAllLoan(search, timeFrom, timeTo, sortMoney, _status, _deadline, 1);
            return View(list);
        }

            // GET: LoanController/Details/5
            public ActionResult Details(int id)
        {
            if (id == null) return NotFound();
            var item = loanRepository.GetObjectByID(id);
            if (item == null) return NotFound();
            return View(item);
        }

        // GET: LoanController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoanController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Loan loan)
        {
            try
            {
                loanRepository.Insert(loan);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Điền thiếu thông tin");
            }
        }

        // GET: LoanController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
                return NotFound();
            var loan = loanRepository.GetObjectByID(id);
            if (loan == null)
                return NotFound();
            return View(loan);
        }

        // POST: LoanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Loan loan)
        {
            try
            {
                if (id != loan.Id) return NotFound();
                loanRepository.Update(loan);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoanController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var loan = loanRepository.GetObjectByID(id.Value);
            if (loan == null)
                return NotFound();
            return View(loan);
        }

        // POST: LoanController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                loanRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
