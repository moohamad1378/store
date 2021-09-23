using System.Collections.Generic;
using Store_1.Domain.Commons;
using Store_1.Domain.Entities.Users;


namespace Store_1.Domain.Entities.Users
{
    public class Role:BaseEntity
    {//we deleted Id becaus BaseEntity has A ID
        public string Name { get; set; }
        public ICollection<UserInRole> UserInroles { get; set; }
    }
}
