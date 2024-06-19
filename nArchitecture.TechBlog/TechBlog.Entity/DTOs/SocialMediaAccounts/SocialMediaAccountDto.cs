namespace TechBlog.Entity.DTOs.SocialMediaAccounts
{
    public class SocialMediaAccountDto
    {
        public Guid Id { get; set; }
        public string MediaName { get; set; }
        public string NormalizedMediaName { get; set; }
        public string MediaLink { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
