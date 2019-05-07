using System.Collections.ObjectModel;
using DataTemplateSelectorTest.Helpers;
using MvvmHelpers;
using Xamarin.Forms;

namespace DataTemplateSelectorTest.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            Names = new ObservableCollection<Name>();
            for (int i = 0; i < 5; i++)
            {
                Names.Add(new Name
                {
                    FirstName = $"bob{i}"
                });
            }
        }

        string lastNameToAdd;
        public string LastNameToAdd
        {
            get { return lastNameToAdd; }
            set { SetProperty(ref lastNameToAdd, value); }
        }

        string firstNameToAdd;
        public string FirstNameToAdd
        {
            get { return firstNameToAdd; }
            set { SetProperty(ref firstNameToAdd, value); }
        }

        //ObservableCollection<Name> items;
        //public ObservableCollection<Name> Items
        //{
        //    get { return items; }
        //    set { SetProperty(ref items, value); }
        //}

        ObservableCollection<Name> names;
        public ObservableCollection<Name> Names
        {
            get { return names; }
            set { SetProperty(ref names, value); }
        }

        public Command AddNameCmd => new Command(() =>
        {
            Names.Add(new Name
            {
                FirstName = FirstNameToAdd,
                LastName = LastNameToAdd
            });
        });
    }
}
