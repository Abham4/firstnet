using firstnet.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace firstnet;
[ApiController]
[Route("Member")]
public class MemberController:ControllerBase {
    private readonly IMember members;
 public MemberController(IMember mem){
    members = mem;
  }
 [HttpGet]
 public ActionResult<List<Member>> Get(){
  return members.Get();
 } 
 


[HttpGet("{id}")]
public ActionResult<Member> GetById(int id) {
    var 
}

[HttpDelete("{id}")]

public List<Member> MemberDelete(int id) {
}

}