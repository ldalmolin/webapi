using webapi.Models;

public class UsersRepository : GenericRepository<Users>, IUsersRepository  
  {  
  
    public UsersRepository(WebapiContext context) : base(context)  
    {  
    }  
  }