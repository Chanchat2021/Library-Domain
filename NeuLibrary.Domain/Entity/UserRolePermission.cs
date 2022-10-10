namespace NeuLibrary.Domain.Entity
{
    public class UserRolePermission
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsAdmin { get; set; }
        public virtual User User { get; set; }

    }
}
