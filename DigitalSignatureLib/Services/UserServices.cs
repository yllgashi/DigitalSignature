using DigitalSignature.DataAccess;
using DigitalSignature.Models;

namespace DigitalSignature.Services {
    public class UserServices {

        public static bool Add(string name, string lastName, string userName, string password) {
            if (Get(userName, password) == null) {

                User user = new User() {
                    Name = name,
                    LastName = lastName,
                    UserName = userName,
                    Password = password,
                };
                DataBase.Users.Add(user);
                return true;
            }
            return false;
        }

        public static User Get(string userName, string password) {
            if (FindIndex(userName, password) != -1) return DataBase.Users[FindIndex(userName, password)];
            return null;
        }

        public static int FindIndex(string userName, string password) {
            return DataBase.Users.FindIndex(user => user.UserName.Equals(userName) && user.Password.Equals(password));
        }


        public static string AllUserServices() {
            string rez = "";

            foreach (var user in DataBase.Users) {
                rez += user.ToString() + "\n";
            }

            return rez;
        }
    }
}