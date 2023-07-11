namespace firstnet.Application.Apply;

using firstnet.Application.Interface;
using firstnet.Data;
using firstnet.Model;
public class ApplyMember:IMember {
    private readonly Context context;
    public ApplyMember (Context con) {
        context = con;
    }
      
    public List<Member> Get(){

        var mem = context.Members.ToList();
        return mem;
    }

    public Member GetById(int id){
        var mem = context.Members.SingleOrDefault(m => m.Id == id);
        return mem;
    }

    public string MemberDelete(int id) {
        var mem = context.Members.SingleOrDefault(m => m.Id == id);
        context.Members.Remove(mem);
        context.SaveChanges();
        return "deleted";
    }
    public  string MemberEdit(Member member){
        var mem = context.Members.SingleOrDefault(m => m.Id == member.Id);
        mem.FirstName = member.FirstName;
        mem.MiddleName = member.MiddleName;
        mem.LastName = member.LastName;
        mem.Gender = member.Gender;
        mem.Age = member.Age;
        context.Members.Update(mem);
        context.SaveChanges();
        return  "Updated";       
    }
    public string MemberPost(Member member){
   
        context.Add(member);
        context.SaveChanges();
        return "add new member";
    }

}