using Microsoft.AspNetCore.Authorization;
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
    public class MembersController : ControllerBase
    {

        private readonly ITeamService teamService;

        public MembersController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        [HttpGet]
        [Route("All")]
        public IActionResult All()
        {
            var members = this.teamService.GetTeam();

            return Ok(members);
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
            return Ok(member);
        }

        // GET: MemberController/Edit/5
        [HttpGet]
        [Route("Edit")]
        public ActionResult Edit(Guid id)
        {
            Member member = teamService.GetMemberById(id);
            return Ok(member);
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

        // POST: MemberController/Delete/5
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var member = this.teamService.GetMemberById(id);

            await this.teamService.DeleteMemberAsync(member);
            return Ok(member);
        }

    }
}
