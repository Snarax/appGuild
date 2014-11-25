using appGuild.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appGuild.Domain.Abstract
{
    public interface ICharacterRepository
    {
        IQueryable<Character> Characters { get; }
        void SaveCharacter(Character character);
        void DeleteCharacter(Character character);
    }
}
