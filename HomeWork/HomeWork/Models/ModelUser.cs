using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    class ModelUser
    {
        private int user_id;
        private int userData_id;
        private string firstName;
        private string middleName;
        private string lastName;
        private string login;
        private string password;

        public void SetValues(int _user_id, int _userData_id, string _firstName, string _middleName, string _lastName,  string _login, string _password)
        {
            user_id = _user_id;
            userData_id = _userData_id;
            firstName = _firstName;
            middleName = _middleName;
            lastName = _lastName;
            login = _login;
            password = _password;
        }

        public int GetUserId() { return user_id; }
        public int GetUserDataId() { return userData_id; }
        public string GetFirstName() { return firstName; }
        public string GetMiddleName() { return middleName; }
        public string GetLastName() { return lastName; }
        public string GetLogin() { return login; }
        public string GetPassword() { return password; }
    }
}
