namespace social_media_be.Models
{
    public class Events
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Email { get; set; }

        public int IsActive { get; set; }

        public string CreatedOn { get; set; }
    }
}
