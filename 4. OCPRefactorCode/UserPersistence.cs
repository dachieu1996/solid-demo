namespace OCPRefactorCode{
    public class UserPersistence{
        
        private IPersistence _userPersistence;

        public UserPersistence(IPersistence userPersistence)
        {
            _userPersistence = userPersistence;
        }

        public void Save(User user){
            _userPersistence.Save(user);
        }
    }
}