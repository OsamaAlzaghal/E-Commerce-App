using System.Collections.Generic;

namespace E_Commerce.Auth.Model.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public IList<string> Roles { get; internal set; }
    }
}
