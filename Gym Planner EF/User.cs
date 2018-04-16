using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Planner_EF
{
    public class User
    {
        private string login;
        private string name;
        private string pass;

        public string Name { get { return name; } }

        public string Login
        {
            get
            {
                return login;
            }
        }

        public User(string login, string pass, string name)
        {
            this.login = login;
            this.pass = pass;
            this.name = name;
        }
        public bool isAdmin()
        {
            return this.login == "admin";
        }

    }
}
