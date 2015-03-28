using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain;
using HboFactFind.EF;
using HboFactFind.Services;

namespace HboFactFind.Controllers
{
    public class FactFindController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();
        // GET: FactFinds
        public async Task<ActionResult> Index()
        {
            var factFinds = _db.FactFinds;
            return View(await factFinds.ToListAsync());
        }

        // GET: FactFinds/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var factFind =
                
                    _db.FactFinds.Include(x => x.PageOne)
                        .Include(x => x.PageTwo)
                        .Include(x => x.PageThree)
                        .Include(x => x.PageFour)
                        .Include(x => x.PageFive)
                        .Include(x => x.PageSix)
                        .Include(x => x.PageSeven)
                        .Include(x => x.PageEight)
                        .Include(x => x.PageNine)
                        .Include(x => x.PageTen).First(x => x.Id == (id));

//              var factFind = _db.FactFinds.First(x => x.Id == (id));
//            factFind.PageOne = _db.PageOnes.Find(id);
//            factFind.PageTwo = _db.PageTwos.Find(id);
//            factFind.PageThree = _db.PageThrees.Find(id);
//            factFind.PageFour = _db.PageFours.Find(id);
//            factFind.PageFive = _db.PageFives.Find(id);
//            factFind.PageSix = _db.PageSixs.Find(id);
//            factFind.PageSeven = _db.PageSevens.Find(id);
//            factFind.PageEight = _db.PageEights.Find(id);
//            factFind.PageNine = _db.PageNines.Find(id);
//            factFind.PageTen = _db.PageTens.Find(id);
////
//            var factFind = await _db.FactFinds.FindAsync(id);
//
//            // Load the blog related to a given post 
//            _db.Entry(factFind).Reference(p => p.PageOne).Load();

            //// Load the blog related to a given post using a string  
            //context.Entry(post).Reference("Blog").Load();

            //var blog = context.Blogs.Find(1);

            //// Load the posts related to a given blog 
            //context.Entry(blog).Collection(p => p.Posts).Load();

            //// Load the posts related to a given blog  
            //// using a string to specify the relationship 
            //context.Entry(blog).Collection("Posts").Load(); 

            if (factFind == null)
            {
                return HttpNotFound();
            }
            return View(factFind);
        }

        // GET: FactFinds/Create
        public ActionResult Create()
        {
//            var newFactFind = new FactFind();
            FactFindRepositorty factFindRepositorty = new FactFindRepositorty(_db);
            var newFactFind =  factFindRepositorty.Create();

            return RedirectToAction("PageOne", "FactFind", new {@id = newFactFind.Id});
        }

        // POST: FactFinds/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "ClientOneName,ClientTwoName"
                )] FactFind factFind)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (factFind.CreatedDateTime == DateTime.MinValue) factFind.CreatedDateTime = DateTime.Now;
                    _db.FactFinds.Add(factFind);
                    await _db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return View(factFind);
        }

        // GET: FactFinds/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var factFind = await _db.FactFinds.FindAsync(id);
            if (factFind == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(_db.PageEights, "Id", "ClientOneRequiredEmergancyFund", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageFives, "Id", "ClientOneIncomeNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageFours, "Id", "Id", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageNines, "Id", "ClientOnePrioritiesNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageOnes, "Id", "ClientOneForename", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageSevens, "Id", "AssetsNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageSixs, "Id", "OutGoingsNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageTens, "Id", "ExistingPlansNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageThrees, "Id", "ClientOneSolicitor", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageTwos, "Id", "ClientOneOccupation", factFind.Id);
            return View(factFind);
        }

        // POST: FactFinds/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOneName,ClientTwoName,UserId,CompletionDateTime,PageOneClientOneId,PageTwoId,PageThreeId,PageFourId,PageFiveId,PageSixId,PageSevenId,PageEightId,PageNineId,PageTenId,CreatedDateTime"
                )] FactFind factFind)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(factFind).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(_db.PageEights, "Id", "ClientOneRequiredEmergancyFund", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageFives, "Id", "ClientOneIncomeNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageFours, "Id", "Id", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageNines, "Id", "ClientOnePrioritiesNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageOnes, "Id", "ClientOneForename", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageSevens, "Id", "AssetsNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageSixs, "Id", "OutGoingsNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageTens, "Id", "ExistingPlansNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageThrees, "Id", "ClientOneSolicitor", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageTwos, "Id", "ClientOneOccupation", factFind.Id);
            return View(factFind);
        }

        // GET: FactFinds/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var factFind = await _db.FactFinds.FindAsync(id);
            if (factFind == null)
            {
                return HttpNotFound();
            }
            return View(factFind);
        }

        // POST: FactFinds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var factFind = await _db.FactFinds.FindAsync(id);
            _db.FactFinds.Remove(factFind);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}