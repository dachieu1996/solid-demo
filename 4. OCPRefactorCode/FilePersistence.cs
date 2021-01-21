namespace OCPRefactorCode
{
    public class FilePersistence : IPersistence
    {
        public void Save(User user)
        {
            System.Console.WriteLine("Saved to file - User name: " + user.username + " Password: " + user.password);
        }
    }
}