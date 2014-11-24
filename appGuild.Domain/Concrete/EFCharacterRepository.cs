using appGuild.Domain.Abstract;
using appGuild.Domain.Entities;
using System.Data.Entity;
using System.Linq;

namespace appGuild.Domain.Concrete
{
    public class EFCharacterRepository : ICharacterRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Character> Characters
        {
            get { return context.Characters; }
        }

        public void SaveCharacter(Character character)
        {
            
            context.Entry(character).State = EntityState.Modified;
            if (character.Id == 0)
            {
                context.Entry(character).State = EntityState.Added;
                context.Characters.Add(character);
            }
            context.SaveChanges();
        }
    }
}
