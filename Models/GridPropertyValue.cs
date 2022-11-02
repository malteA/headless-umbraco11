using Nikcio.UHeadless.Base.Properties.Commands;
using HotChocolate;
using Nikcio.UHeadless.Base.Properties.Models;

namespace UGCare.Models
{ ///


    /// Represents a rich text editor
    ///

    [GraphQLDescription("Represents a grid editor.")]
    public class GridPropertyValue : PropertyValue
    {
        [GraphQLDescription("Gets the value of the grid editor.")]
        public virtual string? Value { get; set; }


        public GridPropertyValue(CreatePropertyValue createPropertyValue) : base(createPropertyValue)
        {
            var value = createPropertyValue.Property.GetValue(createPropertyValue.Culture);

            var content = createPropertyValue.Content;
            if (content == null)
            {
                return;
            }

            foreach (var item in createPropertyValue.Content.Properties)
            {

            }

            string alias = createPropertyValue.Property.Alias;
            Value = createPropertyValue.Content.GetProperty(alias).GetValue().ToString();

        }
    }
}