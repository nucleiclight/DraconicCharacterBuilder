using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStatistics
{
    public class CharacterCoreAttribute:CharacterStatistic
    {
        public CharacterCoreAttribute(string attributeName, int attributeValue):
            base(attributeName,attributeValue)
        {

        }

        protected override int CalculateStatisticModifierValue()
        {
            var modifierValue = (int)Math.Floor((this.StatisticValue - 10) / 2.0);
            return modifierValue;

        }

    }
}
