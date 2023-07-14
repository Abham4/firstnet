namespace firstnet.Model;

public class BaseModel {
   public int Id { get; protected set; }
   public DateTime CreatedDate { get; set; }

   public DateTime LastModifiedDate { get; set;}
    
}