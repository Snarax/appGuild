using appGuild.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace appGuild.Web.Models
{
    public class CharactersViewModel
    {
        public IEnumerable<Character> Characters { get; set; }
    }
}