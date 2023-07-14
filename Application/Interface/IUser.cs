using firstnet.Model;

namespace firstnet.Application.Interface;
public interface IUser {
    IReadOnlyList<User> GetAll();
    User GetById(int id);
    string Add(User user);
    string Delete(int id);
    User Edit(User user);
}