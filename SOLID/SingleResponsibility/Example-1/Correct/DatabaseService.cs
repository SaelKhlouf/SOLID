using System.Data.SqlClient;

namespace SOLID.SingleResponsibility.Example_1.Correct
{
    class DatabaseService
    {
        public void AddUser(User user)
        {
            using (var DbContext = new SqlConnection())
            {
                //Logic to add the user to the database.
            }
        }
    }
}
