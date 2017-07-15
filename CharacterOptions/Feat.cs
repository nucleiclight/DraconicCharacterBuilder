using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using ConfigurationData;

namespace CharacterOptions
{
    public class Feat
    {
        public string Name { get; private set; }
        public IList<string> Tags { get; private set; }
        public string Description { get; private set; }
        public Dictionary<string,int> Prerequisite { get; private set; }
        public Dictionary<string,int> AttributeModifiers { get; private set; }
        public bool AllowsStacking { get; private set; }

        public Feat(XElement featEntry)
        {
            this.Tags = new List<string>();
            this.Prerequisite = new Dictionary<string, int>();
            this.AttributeModifiers = new Dictionary<string, int>();

            this.Name = featEntry.Attribute(FeatLookupNames.Feat).Value.Trim();
            this.Description = featEntry.Element(FeatLookupNames.Description).Value.Trim();

            this.AllowsStacking = Boolean.Parse(featEntry.Attribute(FeatLookupNames.AllowsStacking).Value.Trim());

            foreach (var tagName in featEntry.Element(FeatLookupNames.ApplicableTagList).Elements(FeatLookupNames.ApplicableTag))
            {
                this.Tags.Add(tagName.Value.Trim());
            }

            foreach (var preReq in featEntry.Element(FeatLookupNames.PrerequisiteList).Elements(FeatLookupNames.PrerequsiteName))
            {
                this.Prerequisite.Add(
                    preReq.Attribute(FeatLookupNames.AttributeName).Value.Trim(),
                    Int32.Parse(preReq.Attribute(FeatLookupNames.AttributeModifier).Value.Trim()));
            }

            foreach (var attributeMod in featEntry.Element(FeatLookupNames.EffectList).Elements(FeatLookupNames.EffectName))
            {
                this.AttributeModifiers.Add(
                    attributeMod.Attribute(FeatLookupNames.AttributeName).Value.Trim(),
                    Int32.Parse(attributeMod.Attribute(FeatLookupNames.AttributeModifier).Value.Trim()));
            }

        }
    }
}
