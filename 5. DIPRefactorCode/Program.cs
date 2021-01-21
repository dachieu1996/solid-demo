using System;

namespace DIPRefactorCode
{
    class Program
    {
        static IoCContainer container;
        static void Main(string[] args)
        {
            RegisterInstances();

            var user = new User("admin", "123456");

            var userPrinter = new UserPrinter();
            userPrinter.PrintToFile(user);

           // var userPersistence = new UserPersistence(new SqlServerPersistence());
           var userPersistence = (UserPersistence)container.GetInstance(typeof(UserPersistence));
            userPersistence.Save(user);
        }

        //TODO: Tách ra 1 file riêng - Đăng ký service với File
        // Ví dụ: container.Register<IFileExport, ExcelExport>();
        static void RegisterInstances(){
            container = new IoCContainer();
            container.Register<IPersistence, SqlServerPersistence>();
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
    }
}
