using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class
{
    class UserSingleton
    {
        private static Models.ModelUser user;

        public static Models.ModelUser GetUser()
        {
            if (user == null)
                user = new Models.ModelUser();
            return user;
        }

        public static Models.ModelUser FromDatabase(Entity.User _user, Entity.UserData userData)
        {
            GetUser();
            user.SetValues(_user.id, userData.id, userData.firstname, userData.middlename, userData.lastname,
                _user.login, _user.password);
            return user;
        }
    }
}
