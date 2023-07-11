namespace firstnet.Application.Interface;
using firstnet.Model;
public interface IMember {
    List<Member> Get();
    Member GetById(int id);
    string MemberDelete(int id);

    string MemberEdit(Member member);
    string MemberPost(Member member);

}