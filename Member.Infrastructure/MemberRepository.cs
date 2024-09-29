using Member.Application;

namespace Member.Infrastructure
{
    public class MemberRepository : IMemberRepository
    {
        public static List<Domain.Member> members = new List<Domain.Member>()
        {
            new Domain.Member{ Id = 1, Name = "Kirtesh Shah", Type = "G", Address = "Vadodara" },
            new Domain.Member{ Id = 2, Name = "Mahesh Shah", Type = "S", Address = "Dabhoi" },
            new Domain.Member{ Id = 3, Name = "Nitya Shah", Type = "G", Address = "Mumbai" },
            new Domain.Member{ Id = 4, Name = "Dilip Shah", Type = "S", Address = "Dabhoi" },
            new Domain.Member{ Id = 5, Name = "Hansa Shah", Type = "S", Address = "Dabhoi" },
            new Domain.Member{ Id = 6, Name = "Mita Shah", Type = "G", Address = "Surat" }
        };

        public List<Domain.Member> GetAllMembers()
        {
            return members;
        }

        public Domain.Member? GetMemberById(int id)
        {
            var member = members.Find(m => m.Id == id);
            return member;
        }

        public List<Domain.Member> Add(Domain.Member member)
        {
            members.Add(member);
            return members;
        }

        public void Remove(int id)
        {
            members.Remove(members.Find(m => m.Id == id));
        }

        public List<Domain.Member> Edit(int id, Domain.Member member)
        {
            var data = members.Find(m => m.Id == id);
            if (data != null)
            {
                data.Name = member.Name;
                data.Address = member.Address;
                data.Type = member.Type;
            }

            return members;
        }
    }
}
