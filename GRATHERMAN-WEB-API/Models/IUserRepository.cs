using System;
using System.Collections.Generic;

namespace GRATHERMAN_WEB_API.Models
{
	public interface IUserRepository
    {
        void Add(User user);
        void Update(User item);
        User Remove(string key);
        User Get(string id);
        IEnumerable<User> GetAll();
    }
}
