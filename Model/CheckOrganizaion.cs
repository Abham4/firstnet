namespace firstnet.Model;

public class CheckOrganizaion:BaseModel {
    public Check Check { get; set; }
    public int CheckId { get; set; }
    public Organization Organization { get; set; }
    public int OrganizationId { get; set; }
}