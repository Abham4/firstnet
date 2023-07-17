using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Model;
using Microsoft.EntityFrameworkCore;

namespace firstnet.Infrastracture.Apply;
public class StaffRepositery : BaseRepositery<Staff>, IStaffRepositery
{
    private readonly Context context;
    public StaffRepositery(Context con) : base(con)
    {
        context = con;
    }
    public override IReadOnlyList<Staff> GetAll()
    {
        return context.Staffs.Include(c => c.Member).ToList();
    }
}