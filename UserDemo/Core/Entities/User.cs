namespace UserDemo.Core.Entities
{
    public class User : Base
    {
        public required string Username { get; set; }
        public required string Forename { get; set; }
        public required string Surname { get; set; }
        public required string Email { get; set; }
        public required string EmailAddress { get; set; }
        //TO-DO - implement a proper way of dealing with passwords.
        public required string Password { get; set; }
    }
}
