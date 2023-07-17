using firstnet.Application.Interface;
using firstnet.Infrastracture.Interface;
using firstnet.Model;

namespace firstnet.Application.Apply;

public class ApplyCheck:ICheck {
    private readonly IChecRepositery check;
    public ApplyCheck(IChecRepositery che) {
        check = che;
    }
    public IReadOnlyList<Check> Get(){
        return check.GetAll();
    }
    public Check GetById(int id) {
        return check.GetById(id);
    }
    public string Add(Check chec) {
        return check.Add(chec);
    }
    public Check Edit(Check che) {
        var o = GetById(che.Id);
        var checkEdit = check.Edit(o);
        o.FirstName = che.FirstName;
        o.LastName = che.LastName;
        return checkEdit;
    }
    public string Delete(int id) {
        var o = GetById(id);
        return check.Delete(o);
    }
}