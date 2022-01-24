using System.IO;
using System.Xaml;

namespace UiPath.Shared.Activities.Design.Services
{
    public static class Xaml
    {
        public static T Clone<T>(T toClone)
        {
            using (var ms = new MemoryStream())
            {
                XamlServices.Save(ms, toClone);
                ms.Position = 0;
                return (T)XamlServices.Load(ms);
            }
        }
    }
}
