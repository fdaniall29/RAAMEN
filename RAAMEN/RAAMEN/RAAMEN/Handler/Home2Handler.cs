using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN.Models;
using RAAMEN.Repository;
using RAAMEN.Factory;

namespace RAAMEN.Handler
{
    public class Home2Handler
    {
        private Home2Repository homeRepository;
        private Home2Factory homeFactory;
        public Home2Handler(Home2Repository homeRepository, Home2Factory homeFactory)
        {
            this.homeRepository = homeRepository;
            this.homeFactory = homeFactory;
        }
        public User GetUser(int id)
        {
            return homeRepository.FindUser(id);
        }

        public List<string> GetDistinctGenders()
        {
            return homeRepository.GetDistinctGenders();
        }

        public void UpdateUser(int id, string username, string email, string gender)
        {
            User user = GetUser(id);
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            homeRepository.UpdateUser(user);
        }
    }
}