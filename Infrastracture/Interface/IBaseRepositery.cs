using firstnet.Model;

namespace firstnet.Infrastracture.Interface;

public interface IBaseRepositery<T> where T : BaseModel {
    IReadOnlyList<T>  GetAll();
    T GetById(int id);

    string Delete(T t);

    T Edit(T t);

    string Add(T t);
}
