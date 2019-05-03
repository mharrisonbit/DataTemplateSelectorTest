using Xamarin.Forms;

namespace DataTemplateSelectorTest.UI
{
    public class MyDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var name = item as string;
            if (name.StartsWith("B"))
            {
                return new DataTemplate(typeof(ListViewDataTemplateView));
            }

            return new DataTemplate(typeof(YourDataTemplateView));
        }
    }
}
