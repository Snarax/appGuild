using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGuild.Domain.Entities
{
    public class EventItem
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int ItemId { get; set; }
    }
}
