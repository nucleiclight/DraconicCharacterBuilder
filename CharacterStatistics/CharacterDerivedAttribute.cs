using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStatistics
{
    public class CharacterDerivedAttribute:CharacterStatistic
    {
        public CharacterDerivedAttribute(string attributeName, CharacterCoreAttribute statisticSource, int additionalAttributePoints)
            : base(attributeName)
        {
            this.ModifyStatisticModifier(statisticSource.StatisticName, statisticSource.StatisticModifier);
            this.StatisticBase += additionalAttributePoints;

        }
    }
}
