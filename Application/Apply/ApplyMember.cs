namespace firstnet.Application.Apply;

using firstnet.Application.Interface;
using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Model;
public class ApplyMember:IMember {
    private readonly IMemberRepositery context;
    public ApplyMember (IMemberRepositery con) {
        context = con;
    }
      
    public IReadOnlyList<Member> Get(){

        var mem = context.GetAll();
        return mem;
    }

    public Member GetById(int id){
        var mem = context.GetById(id);
        return mem;
    }

    public string MemberDelete(int id) {
        var member = GetById(id);
        var mem = context.Delete(member);
        return mem;
    }
    public  Member MemberEdit(Member member){
        var memEdit = GetById(member.Id);
        var mem = context.Edit(memEdit);
        memEdit.FirstName = member.FirstName;
        memEdit.MiddleName = member.MiddleName;
        memEdit.LastName = member.LastName;
        memEdit.Gender = member.Gender;
        memEdit.Age = member.Age;
        return  mem;     
    }
    public string MemberPost(Member member){
        context.Add(member);
        return "add new member";
    }

}