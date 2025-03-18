namespace PatikaSecondDb.Entities
{
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }


        // relational property

        public int UserId { get; set; }

        public UserEntity User { get; set; }

    }
}
