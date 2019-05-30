using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace GRATHERMAN_WEB_API.Models
{
	public class UserRepository: IUserRepository
    {
        private static ConcurrentDictionary<string, User> users =
           new ConcurrentDictionary<string, User>();

        public UserRepository()
        {
            Add(new User { Id = Guid.NewGuid().ToString(), Name = "User 1", Email = "User1Mail@hotmail.fr" });
            Add(new User { Id = Guid.NewGuid().ToString(), Name = "User 2", Email = "User1Mail@hotmail.fr" });
            Add(new User { Id = Guid.NewGuid().ToString(), Name = "User 3", Email = "User1Mail@hotmail.fr" });
        }

        public IEnumerable<User> GetAll()
        {
            return users.Values;
        }

        public void Add(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            users[user.Id] = user;
        }

        public User Get(string id)
        {
            User user;
            users.TryGetValue(id, out user);

            return user;
        }

        public User Remove(string id)
        {
            User user;
            users.TryRemove(id, out user);

            return user;
        }

        public void Update(User user)
        {
            users[user.Id] = user;
        }
    }
}

