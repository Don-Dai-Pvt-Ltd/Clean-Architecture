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

        public List<Domain.Member> AddMembers(Domain.Member member)
        {
            return _memberRepository.Add(member);
        }

        public List<Domain.Member> EditMembers(int id, Domain.Member member)
        {
            return _memberRepository.Edit(id, member);
        }

        public void RemoveMembers(int id)
        {
            _memberRepository.Remove(id);
        }

        List<Domain.Member> IMemberServices.GetAllMembers()
        {
            return _memberRepository.GetAllMembers();
        }

        Domain.Member? IMemberServices.GetMemberById(int id)
        {
            return _memberRepository.GetMemberById(id);
        }
    }
}
