namespace OCPSampleCode{
    public class UserPrinter{
        
        public UserPrinter(){
        }

        public void PrintToFile(User user){
            System.Console.WriteLine("Print User - User name: " + user.username + " Password: " + user.password);
        }
    }
}
