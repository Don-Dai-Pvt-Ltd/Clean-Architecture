using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application
{
    public class MemberService : IMemberServices
    {
        private readonly IMemberRepository _memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        List<Domain.Member> IMemberServices.GetAllMembers()
        {
            return _memberRepository.GetAllMembers();
        }
    }
}
