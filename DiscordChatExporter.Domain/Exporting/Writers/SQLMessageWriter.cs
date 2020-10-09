using DiscordChatExporter.Domain.Discord.Models;
using DiscordChatExporter.Domain.Exporting.Writers;
using System.IO;
using System.Threading.Tasks;

namespace DiscordChatExporter.Domain.Exporting
{
    internal class SQLMessageWriter : MessageWriter
    {
        private FileStream stream;
        private ExportContext context;

        public SQLMessageWriter(FileStream stream, ExportContext context) : base(stream, context)
        {
            this.stream = stream;
            this.context = context;
        }

        public override async ValueTask WriteMessageAsync(Message message)
        {
            // TODO: write SQL inserts
            await Task.CompletedTask;
        }
    }
}