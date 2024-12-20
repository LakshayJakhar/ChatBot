namespace ChatBotApp.Models
{
    public class ChatHistory
    {
        public int Id { get; set; }
        public string UserMessage { get; set; }
        public string BotMessage { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
