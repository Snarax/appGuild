using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGuild.Domain.Entities
{

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DateRegistration { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public int GroupId { get; set; }
    }
}
