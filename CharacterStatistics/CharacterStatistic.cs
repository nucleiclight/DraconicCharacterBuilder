using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStatistics
{
    public class CharacterStatistic
    {
        public int StatisticBase { get; protected set; }
        private Dictionary<string, int> statisticModifiers;
        public string StatisticName { get; private set; }
        private bool StatisticIsApplicable;

        public int StatisticValue
        {
            get
            {
                return this.CalculateStatisticValue();
            }
        }
        public int StatisticModifier
        {
            get
            {
                return this.CalculateStatisticModifierValue();
            }
        }

        public CharacterStatistic(string statisticName)
        {
            this.StatisticBase = 0;
            this.StatisticIsApplicable = true;
            this.StatisticName = statisticName;
        }
        public CharacterStatistic(string statisticName, bool statisticIsNotPresent)
            :this(statisticName)
        {
            this.StatisticBase = -1;
            this.StatisticIsApplicable = statisticIsNotPresent;
        }
        public CharacterStatistic(string statisticName, int statisticBaseValue)
            :this(statisticName)
        {
            this.StatisticBase = statisticBaseValue;
        }

        public void ModifyStatisticModifier(string modifierName, int newModifierValue)
        {
            this.statisticModifiers[modifierName] = newModifierValue;
        }

        private int CalculateStatisticValue()
        {
            var statisticValue = this.StatisticBase;
            foreach (var statisticModifier in this.statisticModifiers)
            {
                statisticValue += statisticModifier.Value;
            }
            statisticValue = Math.Max(0, statisticValue);
            return statisticValue;
        }
        protected virtual int CalculateStatisticModifierValue()
        {
            //var modifierValue = (int)Math.Floor((this.StatisticValue - 10) / 2.0);
            return this.StatisticValue;
        }
    }
}
