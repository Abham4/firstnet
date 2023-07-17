using firstnet.Application.Interface;
using firstnet.Infrastracture.Interface;
using firstnet.Model;

namespace firstnet.Application.Apply;

public class ApplyOrganization:IOrganization {
    private readonly IOrganizationRepositery organizaion;
    public ApplyOrganization(IOrganizationRepositery org) {
        organizaion = org;
    }
    public IReadOnlyList<Organization> Get(){
        return organizaion.GetAll();
    }
    public Organization GetById(int id) {
        return organizaion.GetById(id);
    }
    public string Add(Organization organ) {
        return organizaion.Add(organ);
    }
    public Organization Edit(Organization organ) {
        var o = GetById(organ.Id);
        var orgEdit = organizaion.Edit(o);
        o.Name = organ.Name;
        o.ShorName = organ.ShorName;
        return orgEdit;
    }
    public string Delete(int id) {
        var o = GetById(id);
        return organizaion.Delete(o);
    }
}