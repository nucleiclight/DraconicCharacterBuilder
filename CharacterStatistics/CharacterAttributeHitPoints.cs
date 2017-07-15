using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConfigurationData;

namespace CharacterStatistics
{
    public class CharacterAttributeHitPoints : CharacterStatistic
    {
        public CharacterAttributeHitPoints(DieType hitDieType, CharacterCoreAttribute statisicSource)
            : base(CharacterAttributeName.HitPoints)
        {
            this.StatisticBase = hitDieType.GetMaxValue();
            this.ModifyStatisticModifier(statisicSource.StatisticName, statisicSource.StatisticModifier);
        }
        public CharacterAttributeHitPoints(DieType hitDieType, CharacterCoreAttribute statisticSource, int additionalHitpoints)
            :this(hitDieType,statisticSource)
        {
            this.StatisticBase += additionalHitpoints;
        }

        public void AddHitPoints(DieType hitDieType, CharacterCoreAttribute statisticSource, int additionalHitPoints, bool enforceMinimumGain = true)
        {
            if (enforceMinimumGain)
            {
                additionalHitPoints = Math.Min(hitDieType.GetMedianValue(), additionalHitPoints);
            }
            this.StatisticBase = this.StatisticBase + additionalHitPoints + statisticSource.StatisticValue;
        }
    }
}
