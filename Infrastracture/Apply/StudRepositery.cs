using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Model;

namespace firstnet.Infrastracture.Apply;
public class StudRepositery : BaseRepositery<Stud>, IStudRepositery
{
    public StudRepositery(Context con) : base(con)
    {
    }
}