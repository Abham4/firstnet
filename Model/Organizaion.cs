namespace firstnet.Model;
public class Organization:BaseModel {
  public  string Name { get; set; }
  public string ShorName { get; set; }
  public List<CheckOrganizaion> CheckOrganizaion { get; set; }
}