namespace firstnet.Application.Apply;

using firstnet.Application.Interface;

public class ApplyMember:IMember {
       public List<Member> MemberList() {
        return new List<Member> {
            new Member {
                Id= 1,
                FirstName = "Kassa",
                MiddleName = "Kassaye",
                LastName = "Kassu",
                Gender = "Male",
                Age = 20
                 },
                  new Member {
                Id= 2,
                FirstName = "abebe",
                MiddleName = "kebede",
                LastName = "Kassu",
                Gender = "Male",
                Age = 20
                 },
        };
    }
    public List<Member> Get(){

        var mem = MemberList();
        return mem;
    }

    public Member GetById(int id){
        var mem = MemberList().SingleOrDefault(m => m.Id == id);
        return mem;
    }

    public List<Member> MemberDelete(int id) {
        var mem = MemberList();
        var memDel = mem.SingleOrDefault(m => m.Id == id);
        mem.Remove(memDel);
        return mem;
    }
    public  List<Member> MemberEdit(Member member){
        var mem = MemberList();
        var memEdit = mem.SingleOrDefault(m => m.Id == member.Id);
        memEdit.FirstName = member.FirstName;
        memEdit.MiddleName = member.MiddleName;
        memEdit.LastName = member.LastName;
        memEdit.Gender = member.Gender;
        memEdit.Age = member.Age;
        return mem;
        
         

    }
    public List<Member> MemberPost(Member member){
         var mem = MemberList();
        mem.Add(member);
        return mem;
    }

}