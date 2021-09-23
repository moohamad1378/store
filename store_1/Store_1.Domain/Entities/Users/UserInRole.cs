using Store_1.Domain.Commons;

namespace Store_1.Domain.Entities.Users
{
    public class UserInRole:BaseEntity
    {
        //we deleted Id becaus BaseEntity has A ID
        public virtual User User { get; set; }

        public long UserId { get; set; }

        public virtual Role Role { get; set; }
        public long RoleId { get; set; }
    }
}
