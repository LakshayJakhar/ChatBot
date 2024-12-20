using ChatBotApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatBotApp.Data
{
    public class ChatDbContext : DbContext
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options) { }

        public DbSet<ChatHistory> ChatHistories { get; set; }
    }
}
