using Microsoft.AspNetCore.Mvc;

namespace firstnet;

[ApiController]
[Route("[controller]")]
public class FirstController:ControllerBase
{
    [NonAction]
    public List<Student> Students() 
    {
        return new List<Student>{
            new Student{
                Id = 1,
                Name = "Abebe"
            },
              new Student{
                Id = 2,
                Name = "Kebede"
            },
              new Student{
                Id = 3,
                Name = "Debebe"
            }
        };
    }
    
    [HttpGet("dotnet")]

    public ActionResult<List<Student>> Get() 
    {
       return Ok(Students());
    }
    [HttpGet("{id}")]
    
    public ActionResult<Student> GetById(int id) 
    {
        var student = Students().SingleOrDefault(h => h.Id == id);
        if (student == null) 
            return NotFound();
        return Ok(student);
    }
    [HttpPut]
    public ActionResult<List<Student>> Edit(Student student) {
        var sEdit = Students();
        var stud = sEdit.SingleOrDefault(s => s.Id == student.Id);
         if(stud == null)
         return NotFound();
         stud.Name = student.Name;
         return sEdit;
    }

    [HttpDelete("{id}")]
    public ActionResult<List<Student>> Delete(int id) {
        var sDelete = Students();
        var stud = sDelete.SingleOrDefault(s => s.Id == id);
        if(stud == null)
        return NotFound();
        sDelete.Remove(stud);
        return sDelete;
    }

    [HttpPost]

    public ActionResult<List<Student>> Post(Student student) {
        var spost = Students();
        if(student.Id <= 0)
        return BadRequest("");
        spost.Add(student);
        return spost;

    }

    //  public ActionResult<List<Student>> Post(string name) {
    //     var spost = Students();
    //     if(name == "" || name == null)
    //     return BadRequest("student Name Required");
    //     var student = new Student{
    //         Id = 5,
    //         Name = name
    //     };
    //     spost.Add(student);
    //     return spost;

    // }

}