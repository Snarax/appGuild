using System.Web.Mvc;

namespace appGuild.Domain.Entities
{
    public class Character
    {
        [HiddenInput(DisplayValue=false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public string Class { get; set; }
    }
}
