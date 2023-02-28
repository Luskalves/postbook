public interface IUserRepository
{
  public ICollection<User> GetAll();
  public User Create(User user);
  public void Put(User user);
  public void Delete(int id);
}