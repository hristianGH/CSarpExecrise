namespace SiteX.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using SiteX.Data.Models.Team;
    using SiteX.Services.Data.TeamService.Interfaces;
    using System.Threading.Tasks;

    public class MembersController : AdministrationController
    {
        private readonly ITeamService teamService;

        public MembersController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        // GET: MemberController
        public ActionResult Index()
        {
            return this.View(this.teamService.GetTeam());
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return this.View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            var member = new Member();
            return this.View(member);
        }

        // POST: MemberController/Create
        [HttpPost]
        public async Task<IActionResult> Create(Member member)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.teamService.CrateMemberAsync(member);
            return this.RedirectToAction(nameof(this.Index));
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return this.View();
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
