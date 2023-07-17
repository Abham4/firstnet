using firstnet.Application.Interface;
using firstnet.Model;
using Microsoft.AspNetCore.Mvc;

namespace firstnet.Controllers;

[ApiController]

[Route("Organziation")]

public class OrganizationController:ControllerBase {
    private readonly IOrganization organization;
    public OrganizationController(IOrganization organ) {
        organization = organ;
    }
     [HttpGet]
 public ActionResult<List<Organization>> Get(){
  return Ok(organization.Get());
 } 
 


[HttpGet("{id}")]
public ActionResult<Organization> GetById(int id) {
   return organization.GetById(id);
}

[HttpDelete("{id}")]

public ActionResult<List<Organization>> Delete(int id) {
   return Ok(organization.Delete(id));
}
[HttpPut]
public ActionResult<List<Organization>> Edit(Organization organ) {
   return Ok(organization.Edit(organ));
}
[HttpPost]
public ActionResult<List<Organization>> Add(Organization organ) {
   return Ok(organization.Add(organ));
}

}