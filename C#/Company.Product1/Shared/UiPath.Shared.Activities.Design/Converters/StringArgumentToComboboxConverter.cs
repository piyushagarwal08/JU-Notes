using Microsoft.VisualBasic.Activities;
using System;
using System.Activities;
using System.Activities.Expressions;
using System.Activities.Presentation.Model;
using System.Globalization;
using System.Windows.Data;

namespace UiPath.Shared.Activities.Design.Converters
{
    public class StringArgumentToComboboxConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convert InArgument<string> to Combo box value
            string itemContent = string.Empty;
            ModelItem modelItem = value as ModelItem;
            if (value != null)
            {
                InArgument<string> inArgument = modelItem.GetCurrentValue() as InArgument<string>;
                if (inArgument != null)
                {
                    if (inArgument.Expression is VisualBasicValue<string>)
                    {
                        VisualBasicValue<string> vbexpression = inArgument.Expression as VisualBasicValue<string>;

                        //to avoid extra double quotation marks
                        if (vbexpression.ExpressionText.StartsWith("\"") && vbexpression.ExpressionText.EndsWith("\""))
                        {
                            itemContent = vbexpression.ExpressionText.Replace("\"", string.Empty);
                        }
                        else
                        {
                            itemContent = vbexpression.ExpressionText;
                        }
                    }
                    else if (inArgument.Expression is Literal<string>)
                    {
                        Literal<string> literal = inArgument.Expression as Literal<string>;
                        itemContent = literal.Value;
                    }
                }
            }
            return itemContent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convert combo box value to InArgument<string>  
            string itemContent = "\"" + (string)value + "\"";
            VisualBasicValue<string> vbArgument = new VisualBasicValue<string>(itemContent);
            InArgument<string> inArgument = new InArgument<string>(vbArgument);
            return inArgument;
        }
    }
}
