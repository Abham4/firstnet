using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Model;

namespace firstnet.Infrastracture.Apply;
public class StaffRepositery : BaseRepositery<Staff>, IStaffRepositery
{
    public StaffRepositery(Context con) : base(con)
    {
    }
}