using System.Collections.ObjectModel;
using DataTemplateSelectorTest.Helpers;
using Xamarin.Forms;

namespace DataTemplateSelectorTest.UI
{
    public class MyDataTemplateSelector : DataTemplateSelector
    {
        private DataTemplate yourTemplate;

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            //var name = new ObservableCollection<Name>
            //{
            //    new Name
            //    {
            //        FirstName = item.ToString()
            //    }
            //};
            //if (name)
            //{
            //    return new DataTemplate(typeof(ListViewDataTemplateView));
            //}
            yourTemplate = new DataTemplate(typeof(YourDataTemplateView));

            return yourTemplate;
        }
    }
}
