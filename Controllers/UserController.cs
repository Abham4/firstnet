using firstnet.Application.Interface;
using firstnet.Model;
using Microsoft.AspNetCore.Mvc;

namespace firstnet.Controllers;
[ApiController]
[Route("User")]
public class UserController:ControllerBase {
    private readonly IUser user;
    public UserController(IUser u) {
        user = u;
    }
    [HttpGet]
    public ActionResult<List<User>> GetAll() {
        return Ok(user.GetAll());
    }
    [HttpGet("{id}")]
    public ActionResult<User> GetById(int id) {
        return Ok(user.GetById(id));
    }
    [HttpPost]
    public ActionResult<List<User>> Add(User use) {
        return Ok(user.Add(use));
    }
    [HttpDelete]
    public ActionResult<List<User>> Delete(int id) {
        return Ok(user.Delete(id));
    }
    [HttpPut]
    public ActionResult<List<User>> Edit(User use) {
        return Ok(user.Edit(use));
    }
}