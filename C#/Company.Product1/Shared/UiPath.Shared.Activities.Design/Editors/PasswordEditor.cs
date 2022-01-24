using System.Activities.Presentation.PropertyEditing;
using System.Windows;

namespace UiPath.Shared.Activities.Design.Editors
{
    public class PasswordEditor : DialogPropertyValueEditor
    {
        public PasswordEditor()
        {
            this.InlineEditorTemplate = (DataTemplate)EditorTemplates.ResourceDictionary["PasswordEditorTemplate"];
        }
    }
}