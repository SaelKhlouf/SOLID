namespace SOLID.SingleResponsibility.Example_1.Correct
{
    class ValidationService
    {
        public bool IsEmailValid(string email) => email.Contains("@");
    }
}
