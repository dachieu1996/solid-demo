namespace DIPRefactorCode
{
    public class SqlServerPersistence : IPersistence
    {
        public void Save(User user)
        {
            System.Console.WriteLine("Saved to sql server - User name: " + user.username + " Password: " + user.password);
        }
    }
}
