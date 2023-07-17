using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Model;

namespace firstnet.Infrastracture.Apply;

public class CheckRepositery : BaseRepositery<Check>, IChecRepositery
{
    public CheckRepositery(Context con) : base(con)
    {
    }
}