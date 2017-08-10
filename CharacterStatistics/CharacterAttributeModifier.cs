using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CharacterStatistics
{
    public class CharacterAttributeModifier
    {
        public string ModifierName { get; private set; }
        public string ModifierType { get; private set; }
        public int ModifierValue { get; private set; }

        private bool isSpecialization;
        private string specializationName;

        public CharacterAttributeModifier(string modifierName, string modifierType, int value)
        {
            this.ModifierName = modifierName;
            this.ModifierType = modifierType;
            this.ModifierValue = value;
        }
        public CharacterAttributeModifier(string modifierName, string modifierType, int value, string specialization)
            :this(modifierName, modifierType, value)
        {
            this.isSpecialization = true;
            this.specializationName = specialization;
        }

        public CharacterAttributeModifier(XElement sourceData)
        {
            this.ModifierName = sourceData.Attribute("attribute").Value.Trim();
            this.ModifierType = ConfigurationData.ModifierTypeBonusSources.Untyped;
            if (sourceData.Attributes().Select(attributeSelect => attributeSelect.Name).Contains("type"))
            {
                this.ModifierType = sourceData.Attribute("type").Value.Trim();
            }
            this.ModifierValue = Int32.Parse(sourceData.Value.Trim());

            if (sourceData.Element("specialization") != null)
            {
                this.isSpecialization = true;
                this.specializationName = sourceData.Element("specialization").Value.Trim();
            }

       }
    }
}
