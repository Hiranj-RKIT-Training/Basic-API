namespace Collection_Demo
{
    internal sealed class UserAuth
    {
        private readonly string username = "admin";
        private readonly string password = "1234";

        // Method to validate username and password
        public bool Validate(string inputUsername, string inputPassword)
        {
            return inputUsername == username && inputPassword == password;
        }
    }
    //internal class InheritedAuth:UserAuth
    //{

    //}
}
