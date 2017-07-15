using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationData
{
    public enum DieType
    {
        d3,
        d4,
        d6,
        d8,
        d10,
        d12,
        d20,
        d100
    }

    public static class DieTypeExtensions
    {
        public static int GetMaxValue(this DieType die)
        {
            switch (die)
            {
                case DieType.d3:
                    { return 3; }
                case DieType.d4:
                    { return 4; }
                case DieType.d6:
                    { return 6; }
                case DieType.d8:
                    { return 8; }
                case DieType.d10:
                    { return 10; }
                case DieType.d12:
                    { return 12; }
                case DieType.d20:
                    { return 20; }
                case DieType.d100:
                    { return 100; }
                default:
                    { return 0; }
            }
        }
        public static int GetMedianValue(this DieType die)
        {
            switch (die)
            {
                case DieType.d3:
                    { return 2; }
                case DieType.d4:
                    { return 3; }
                case DieType.d6:
                    { return 4; }
                case DieType.d8:
                    { return 5; }
                case DieType.d10:
                    { return 6; }
                case DieType.d12:
                    { return 7; }
                case DieType.d20:
                    { return 11; }
                case DieType.d100:
                    { return 51; }
                default:
                    { return 0; }
            }
        }

    }

    public static class CharacterAttributeName
    {
        public static readonly string Strength = "Strength";
        public static readonly string Consitution = "Consitution";
        public static readonly string Dexteritry = "Dexterity";
        public static readonly string Intelligence = "Intelligence";
        public static readonly string Wisdom = "Wisdom";
        public static readonly string Charisma = "Charisma";

        public static readonly string HitPoints = "Hit Points";


    }

    public static class CharacterSkillName
    {
        public static readonly string SkillNameAppraise = "Appraise";

    }

    public static class FeatLookupNames
    {
        public static readonly string FeatList = "feat_list";
        public static readonly string Feat = "feat";
        public static readonly string Description = "description";
        public static readonly string ApplicableTagList = "tags";
        public static readonly string ApplicableTag = "tag";
        public static readonly string PrerequisiteList = "prerequisites";
        public static readonly string PrerequsiteName = "prerequisite";
        public static readonly string EffectList = "effects";
        public static readonly string EffectName = "effect";
        public static readonly string AttributeName = "attribute";
        public static readonly string AttributeModifier = "value";
        public static readonly string AllowsStacking = "stacks";

    }
}
