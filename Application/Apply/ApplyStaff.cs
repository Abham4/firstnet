using firstnet.Application.Interface;
using firstnet.Infrastracture.Interface;
using firstnet.Model;

namespace firstnet.Application.Apply;
public class ApplyStaff:IStaff {
    private readonly IStaffRepositery staff;
    public ApplyStaff(IStaffRepositery sta) {
        staff = sta;
    }
    public IReadOnlyList<Staff> GetAll() {
       return staff.GetAll();
    }
    public Staff GetById(int id) {
       return staff.GetById(id);
    }
    public string Add(Staff staf) {
        staff.Add(staf);
        return "added";
    }
    public string Delete(int id) {
        var s = GetById(id);
        staff.Delete(s);
        return "deleted";
    }
    public Staff Edit(Staff staf) {
        var s = GetById(staf.Id);
        var editS = staff.Edit(s);
        s.FirstName = staf.FirstName;
        s.MiddleName = staf.MiddleName;
        s.LastName = staf.LastName;
        return editS;
    }
}