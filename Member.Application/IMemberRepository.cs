namespace Member.Application
{
    public interface IMemberRepository
    {
        List<Domain.Member> GetAllMembers();
        Domain.Member? GetMemberById(int id);
        List<Domain.Member> Add(Domain.Member member);
        void Remove(int id);
        List<Domain.Member> Edit(int id, Domain.Member member);
    }
}
