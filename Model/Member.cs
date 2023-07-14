namespace firstnet.Model;

public class Member:BaseModel {
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public List<Staff> Staff { get; set; }
    
}