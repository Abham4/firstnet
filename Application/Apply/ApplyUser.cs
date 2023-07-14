using firstnet.Application.Interface;
using firstnet.Infrastracture.Interface;
using firstnet.Model;

namespace firstnet.Application.Apply;
public class ApplyUser:IUser {
    private readonly IUserRepositery user;
    public ApplyUser(IUserRepositery u) {
        user = u;
    }
    public IReadOnlyList<User> GetAll(){
        return user.GetAll();
    }
    public User GetById(int id) {
        return user.GetById(id);
    }
    public string Add(User use) {
        return user.Add(use);
    }
    public string Delete(int id) {
        var userById = GetById(id);
        user.Delete(userById);
        return "deleted";
    }
    public User Edit(User use) {
        var userById = GetById(use.Id);
        var userEdit = user.Edit(userById);
        userById.FirstName = use.FirstName;
        userById.MiddleName = use.MiddleName;
        userById.LastName = use.LastName;
        userById.PhoneNumber = use.PhoneNumber;
        userById.Email = use.Email;
        return userEdit;
    }
}