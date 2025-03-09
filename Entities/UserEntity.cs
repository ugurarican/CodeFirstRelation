namespace CodeFirstRelation.Entities
{
    public class UserEntity : BaseEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        // Relational Property
        public List<PostEntity> Posts { get; set; }
    }
}
