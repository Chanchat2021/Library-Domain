namespace NeuLibrary.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual UserRolePermission UserRolePermission { get; set; }
        public virtual ICollection<Reserve> Reserve { get; set; }

    }
}
