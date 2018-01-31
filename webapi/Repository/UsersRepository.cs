using webapi.Models;

namespace webapi.Repository
{
public class UsersRepository : GenericRepository<Users>, IUsersRepository  
  {  
  
    public UsersRepository(WebapiContext context) : base(context)  
    {  
    }  
  }
}