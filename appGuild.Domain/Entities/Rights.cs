using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGuild.Domain.Entities
{
    public class Rights
    {
        public int Id { get; set; }
        public bool CanReadUsers { get; set; }
        public bool CanChangeDKP { get; set; }
        public bool CanChangeUsers { get; set; }
    }
}
