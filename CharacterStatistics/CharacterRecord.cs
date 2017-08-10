using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStatistics
{
    public class CharacterRecord
    {
        public List<string> CharacterLevels { get; private set; }
        public CharacterAttributeHitPoints TotalHP { get; private set; }

        private Dictionary<string, CharacterDerivedAttribute> defenses;
        private Dictionary<string, CharacterDerivedAttribute> skills;
        private Dictionary<string, CharacterCoreAttribute> statistics;
        private Dictionary<string, CharacterDerivedAttribute> attacks;



    }
}
