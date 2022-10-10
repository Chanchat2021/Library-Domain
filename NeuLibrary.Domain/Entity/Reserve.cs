namespace NeuLibrary.Domain.Entity
{
    public class Reserve
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime ReservedDate { get; set; }
        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
       
    }
}
