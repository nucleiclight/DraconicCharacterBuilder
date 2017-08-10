using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStatistics
{
    public class CharacterSkill
    {
        public string SkillName { get; private set; }
        public int SkillRank { get; private set; }
        public double SkillPoints { get; private set; }

        private CharacterCoreAttribute backingStatistic;
        private Dictionary<string, int> skillModifiers;
        private bool isCrossClass;
        private int skillRankMaximum;
        private bool isSkillRankMaximized;

        public CharacterSkill(string skillName, CharacterCoreAttribute backingAttribute)
        {
            this.SkillName = skillName;
            this.backingStatistic = backingAttribute;
            this.isCrossClass = true;
            this.SkillRank = 0;
            this.SkillPoints = 0;
            this.skillRankMaximum = 0;
            this.isSkillRankMaximized = false;
        }

        public void UpdateSkill(int characterLevel, int skillPoints, bool isCrossClass = false)
        {
            double skillPointsToAdd=skillPoints;
            if (isCrossClass)
            {
                skillPointsToAdd = skillPoints / 2;
            }
            if (!isCrossClass)
            {
                this.isSkillRankMaximized = this.isSkillRankMaximized || !isCrossClass;
            }
            if (this.isSkillRankMaximized)
            {
                this.skillRankMaximum = characterLevel + 3;
            }
            else
            {
                this.skillRankMaximum = (int)Math.Floor((characterLevel + 3) / 2.0);
            }

            this.SkillPoints = this.SkillPoints + skillPointsToAdd;
            this.SkillRank = Math.Max((int)Math.Floor(this.SkillPoints), this.skillRankMaximum);
        }
        public int CalculateSkillModifier()
        {
            int modiferNumber = 0;
        foreach (var skillMod in this.skillModifiers)
            {

            }
        }
    }
}
