namespace SOLID.SingleResponsibility.Example_1.Correct
{
    class MainClass
    {
        public bool AddUser(User user)
        {
            // Do not worry about dependency injection here, I am just showing the single responsibility principle idea here.
            NotificationsService notificationsService = new NotificationsService();
            DatabaseService databaseService = new DatabaseService();
            ValidationService validationService = new ValidationService();

            var isEmailValid = validationService.IsEmailValid(user.Email);
            if (!isEmailValid)
            {
                return false;
            }

            databaseService.AddUser(user);

            notificationsService.SendEmail("Welcome", "Welcome to our system !", "sael@sael.com", user.Email);


            return true;
        }
    }
}
