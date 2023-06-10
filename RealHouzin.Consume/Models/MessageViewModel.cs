namespace RealHouzin.Consume.Models
{
    public class MessageViewModel
    {
        public int MessageID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Date { get; set; }
        public string? Type { get; set; }
        public string MessageContent { get; set; }
    }
}
