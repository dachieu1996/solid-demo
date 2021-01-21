using System;

namespace SampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("admin", "123456");
            user.PrintToFile();
            user.SaveToFile();
        }
    }

    public class User
    {
        public string username;
        public string password;

        public User(string username, string password){
            this.username = username;
            this.password = password;
        }
        
        public void PrintToFile(){
            System.Console.WriteLine("Print User - User name: " + username + " Password: " + password);
        }

        public void SaveToFile(){
            System.Console.WriteLine("Saved to file - User name: " + username + " Password: " + password);
        }
    }
}

