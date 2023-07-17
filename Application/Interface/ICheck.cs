namespace firstnet.Application.Interface;
using firstnet.Model;
public interface ICheck {
    IReadOnlyList<Check> Get();
    Check GetById(int id);
    string Delete(int id);

    Check Edit(Check check);
    string Add(Check check);

}