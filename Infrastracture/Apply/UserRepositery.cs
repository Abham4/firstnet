using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Model;

namespace firstnet.Infrastracture.Apply;
public class UserRepositery : BaseRepositery<User>, IUserRepositery
{
    public UserRepositery(Context con) : base(con)
    {
    }
}