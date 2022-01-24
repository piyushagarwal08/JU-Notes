using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;
using Company.Product1.Activities.Design.Designers;
using Company.Product1.Activities.Design.Properties;

namespace Company.Product1.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute = new CategoryAttribute($"{Resources.Category}");

            builder.AddCustomAttributes(typeof(Check), categoryAttribute);
            builder.AddCustomAttributes(typeof(Check), new DesignerAttribute(typeof(CheckDesigner)));
            builder.AddCustomAttributes(typeof(Check), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
