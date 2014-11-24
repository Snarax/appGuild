using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGuild.Domain.Entities
{
    public class DKP
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }
        public int EventId { get; set; }
    }
}
