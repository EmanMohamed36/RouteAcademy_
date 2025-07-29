namespace Part02_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAuthenticationService authService = new BasicAuthenticationService();

            string username = "Eman";
            string password = "12345";
            string role = "admin";

            bool isAuthenticated = authService.AuthenticateUser(username, password);
            bool isAuthorized = authService.AuthorizeUser(username, role);

            Console.WriteLine($"User authenticated: {isAuthenticated}");
            Console.WriteLine($"User authorized for role '{role}': {isAuthorized}");
        }
    
    }
}
