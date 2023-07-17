namespace firstnet.Model;
public class Check:BaseModel {
  public  string FirstName { get; set; }
  public string MiddleName { get; set; }
  public string LastName { get; set; }
  public List<CheckOrganizaion> CheckOrganizaion { get; set; }

}