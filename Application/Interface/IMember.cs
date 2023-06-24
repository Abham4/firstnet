namespace firstnet.Application.Interface;

public interface IMember {
    List<Member> Get();
    Member GetById(int id);
    List<Member> MemberDelete(int id);

    List<Member> MemberEdit(Member member);
    List<Member> MemberPost(Member member);

}