using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application
{
    public interface IMemberServices
    {
        List<Domain.Member> GetAllMembers();
        Domain.Member? GetMemberById(int id);
        List<Domain.Member> AddMembers(Domain.Member member);
        void RemoveMembers(int id);
        List<Domain.Member> EditMembers(int id, Domain.Member member);
    }
}
