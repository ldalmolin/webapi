using webapi.Models;

namespace webapi.Repository
{
public class UsersRepository : GenericRepository<Users>, IUsersRepository  
  {  
  
    public UsersRepository(MyDBContext context) : base(context)  
    {  
    }  
  }
}