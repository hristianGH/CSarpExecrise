namespace SiteX.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public string Tags { get; set; }
        public int UploaderName { get; set; }
        public int PictureId { get; set; }
        public string PicturePath { get; set; }

    }
}
