using System.Collections.ObjectModel;
using DataTemplateSelectorTest.Helpers;
using Xamarin.Forms;

namespace DataTemplateSelectorTest.UI
{
    public class MyDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var name = new ObservableCollection<Names>
            {
                new Names
                {
                    FirstName = item.ToString()
                }
            };
            //if (name)
            //{
            //    return new DataTemplate(typeof(ListViewDataTemplateView));
            //}

            return new DataTemplate(typeof(YourDataTemplateView));
        }
    }
}
