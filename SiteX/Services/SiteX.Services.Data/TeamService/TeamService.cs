namespace SiteX.Services.Data.TeamService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using SiteX.Data.Common.Repositories;
    using SiteX.Data.Models.Team;
    using SiteX.Services.Data.TeamService.Interfaces;

    public class TeamService : ITeamService
    {
        private readonly IDeletableEntityRepository<Member> memberRepo;

        public TeamService(IDeletableEntityRepository<Member> memberRepo)
        {
            this.memberRepo = memberRepo;
        }

        public async Task CrateMemberAsync(Member member)
        {
            await this.memberRepo.AddAsync(member);
            await this.memberRepo.SaveChangesAsync();
        }

        public async Task DeleteMemberAsync(Member member)
        {
            this.memberRepo.Delete(member);
            await this.memberRepo.SaveChangesAsync();
        }

        public Task EditMemberAsync(Member member)
        {
            throw new NotImplementedException();
        }

        public Member GetMemberById(Guid id)
        {
            var member = this.memberRepo.AllAsNoTracking().FirstOrDefault(x => x.Id == id);
            return member;
        }

        public ICollection<Member> GetTeam()
        {
           return this.memberRepo.AllAsNoTracking().ToList();
        }
    }
}
