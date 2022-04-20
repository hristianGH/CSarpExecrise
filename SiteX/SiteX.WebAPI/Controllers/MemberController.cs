using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteX.Data.Models.Team;
using SiteX.Services.Data.TeamService.Interfaces;
using System;
using System.Threading.Tasks;

namespace SiteX.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MemberController : ControllerBase
    {
        private readonly ITeamService teamService;

        public MemberController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        // GET: MemberController
        [Route("All")]
        [HttpGet]
        public ActionResult Index()
        {
            return this.Ok(this.teamService.GetTeam());
        }

        // GET: MemberController/Create
        [HttpGet]
        [Route("Create")]
        public ActionResult Create()
        {
            var member = new Member();
            return this.Ok(member);
        }

        // POST: MemberController/Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(Member member)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.teamService.CrateMemberAsync(member);
            return this.Ok(member);
        }

        // GET: MemberController/Edit/5
        [HttpGet]
        [Route("Edit")]
        public ActionResult Edit(Guid id)
        {
            Member member = teamService.GetMemberById(id);
            return this.Ok(member);
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> Edit(Member member)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.teamService.EditMemberAsync(member);
            return this.Ok(member);
        }

        // GET: MemberController/Delete/5
        [HttpGet]
        [Route("Delete")]
        public ActionResult Delete(Guid id)
        {
            Member member = teamService.GetMemberById(id);
            return this.Ok(member);
        }

        // POST: MemberController/Delete/5
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(Member member)
        {
            await this.teamService.DeleteMemberAsync(member);

            return this.Ok(member);
        }

    }
}
