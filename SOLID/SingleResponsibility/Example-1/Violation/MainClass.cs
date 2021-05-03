using System.Data.SqlClient;

namespace SOLID.SingleResponsibility.Example_1.Violation
{
    //Class that have a capability to register new user in a system.
    class MainClass
    {
        public bool AddUser(string name, string email)
        {
            //Violation 1: Email Validation or Validation in general should not be the responsibility of this class.
            if (!email.Contains("@"))
                return false; // "email validation failed"

            InsertUser(name, email);
            SendEmail("Welcome", "Welcome to our system !", "sael@sael.com", email);

            return true;
        }

        //Violation 2: Database Insertion and interactions should not be handled here.
        private void InsertUser(string name, string email)
        {
            using (var DbContext = new SqlConnection())
            {
                //Logic to add the user to the database.
            }
        }

        //Violation 3: Sending emails should not be handled here.
        private void SendEmail(string from, string to, string subject, string body)
        {
            //Logic to send email from sender to receiver with the provided subject and body.
        }
    }
}
