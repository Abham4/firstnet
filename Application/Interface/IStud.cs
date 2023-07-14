using firstnet.Model;

namespace firstnet.Application.Interface;
public interface IStud {
    IReadOnlyList<Stud> GetAll();
    Stud GetById(int id);
    string Add(Stud stud);
    string Edit(Stud stud);
    string Delete(int id);
}