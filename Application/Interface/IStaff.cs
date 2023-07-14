using firstnet.Model;

namespace firstnet.Application.Interface;
public interface IStaff {
    IReadOnlyList<Staff> GetAll();
    Staff GetById(int id);
    string Add(Staff staff);
    string Delete(int id);
    Staff Edit(Staff staff);
}