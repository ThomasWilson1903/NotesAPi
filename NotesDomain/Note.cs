namespace NotesDomain
{
    public class Note
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Detailse { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EdirDate { get; set;}
    }
}
