using firstnet.Application.Interface;
using firstnet.Infrastracture.Interface;
using firstnet.Model;

namespace firstnet.Application.Apply;
public class ApplyStud:IStud {
    private readonly IStudRepositery student;
    public ApplyStud(IStudRepositery stu) {
        student = stu;
    }
    public IReadOnlyList<Stud> GetAll() {
        return student.GetAll();
    }
    public Stud GetById(int id) {
        return student.GetById(id);
    }
    public string Add(Stud stud) {
        student.Add(stud);
        return "added";
    }
    public string Edit(Stud stud) {
        var s = GetById(stud.Id);
        var studEdit = student.Edit(s);
        s.FirstName = studEdit.FirstName;
        s.MiddleName = studEdit.MiddleName;
        s.LastName = studEdit.LastName;
        return "updated";
    }
    public string Delete(int id) {
        var s = GetById(id);
        var del =   student.Delete(s);
        return del;
    }
}