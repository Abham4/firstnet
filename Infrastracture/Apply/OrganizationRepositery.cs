using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Model;
using Microsoft.EntityFrameworkCore;

namespace firstnet.Infrastracture.Apply;

public class OrganizationRepositery : BaseRepositery<Organization>, IOrganizationRepositery
{
    private readonly Context context;
    public OrganizationRepositery(Context con) : base(con)
    {
        context = con;
    }
    public override IReadOnlyList<Organization> GetAll()
    {
        return context.Organizations.Include(c => c.CheckOrganizaion).ToList();
    }
}