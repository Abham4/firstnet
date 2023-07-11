using firstnet.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace firstnet.Model;
[ApiController]
[Route("Member")]
public class MemberController:ControllerBase {
    private readonly IMember members;
 public MemberController(IMember mem){
    members = mem;
  }
 [HttpGet]
 public ActionResult<List<Member>> Get(){
  return Ok(members.Get());
 } 
 


[HttpGet("{id}")]
public ActionResult<Member> GetById(int id) {
   return members.GetById(id);
}

[HttpDelete("{id}")]

public ActionResult<List<Member>> MemberDelete(int id) {
   return Ok(members.MemberDelete(id));
}
[HttpPut]
public ActionResult<List<Member>> MemberEdit(Member member) {
   return Ok(members.MemberEdit(member));
}
[HttpPost]
public ActionResult<List<Member>> MemberPost(Member member) {
   return Ok(members.MemberPost(member));
}
}