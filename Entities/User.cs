using Infrastructures.EntityAbstraction;

namespace Entities
{
    public class User : EntityBaseWithId
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte [] Avatar { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public UserPosition Position { get; set; }

    }
}
