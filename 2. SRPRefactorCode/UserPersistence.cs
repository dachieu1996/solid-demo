namespace RefactorCode{
    public class UserPersistence{
        

        public UserPersistence(){
            
        }

        public void SaveToFile(User user){
            System.Console.WriteLine("Saved to file - User name: " + user.username + " Password: " + user.password);
        }
    }
}