using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Model;

namespace firstnet.Infrastracture.Apply;

public class BaseRepositery<T> : IBaseRepositery<T> where T : BaseModel
{
    private readonly Context context;
    public BaseRepositery (Context con) {
        context = con;
    }
    public string Add(T t)
    {
       context.Set<T>().Add(t);
      context.SaveChanges();
      return "added";
    }

    public string Delete(T t)
    {
        context.Set<T>().Remove(t);
        context.SaveChanges();
        return "deleted";
    }

    public T Edit(T t)
    {
      context.Set<T>().Update(t);
      context.SaveChanges();
      return t;
    }

    public IReadOnlyList<T> GetAll()
    {
     return context.Set<T>().ToList();
       
    }

    public T GetById(int id)
    {
       return context.Set<T>().SingleOrDefault(h => h.Id == id);
    }
}