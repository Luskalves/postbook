using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository
{ 
  protected readonly DbContext _context;
  public UserRepository(DbContext context)
  {
    _context = context;
  }

  public ICollection<User> GetAll()
  {
    var users = _context.Set<User>().ToList();
    return users;
  }

  public User Create(User user)
  {
    var exists = _context.Find<User>(user.Email);

    if (exists != null)
    {
      throw new Exception("deu ruim");
    }

    _context.Add(user);
    _context.SaveChanges();

    return user;
  }

  public void Put(User user)
  {
    var exists = _context.Find<User>(user.Email);

    if (exists == null)
    {
      throw new Exception("deu ruim");
    }

    _context.Update(user);
    _context.SaveChanges();
   }

   public void Delete(int id)
  {
    var exists = _context.Find<User>(id);

    if (exists == null)
    {
      throw new Exception("deu ruim");
    }

    _context.Remove(id);
    _context.SaveChanges();
   }
}