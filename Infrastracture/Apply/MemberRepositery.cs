using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Model;

namespace firstnet.Infrastracture.Apply;

public class MemberRepositery : BaseRepositery<Member>,IMemberRepositery
{
    public MemberRepositery(Context con) : base(con)
    {
    }
}