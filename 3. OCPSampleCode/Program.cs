﻿using System;

namespace OCPSampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("admin", "123456");

            var userPrinter = new UserPrinter();
            userPrinter.PrintToFile(user);

            // var userPersistence = new UserPersistence(user);
            // userPersistence.SaveToFile();

            var userPersistence = new UserPersistence();
            userPersistence.SaveToSqlServer(user);
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
