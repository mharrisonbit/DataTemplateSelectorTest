using System;
using System.Collections.Generic;
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
            Items = new ObservableCollection<Names>();
            ListOfNames = new List<object>
            {
                "Bob", "John", "Paul", "Mike", "Billy", "Mark"
            };
        }

        ObservableCollection<Names> items;
        public ObservableCollection<Names> Items 
        {
            get { return items; }
            set { SetProperty(ref items, value); }
        }

        string newNameToAdd;
        public string NewNameToAdd
        {
            get { return newNameToAdd; }
            set { SetProperty(ref newNameToAdd, value); }
        }

        List<Object> listOfNames;
        public List<object> ListOfNames
        {
            get { return listOfNames; }
            set { SetProperty(ref listOfNames, value); }
        }

        ObservableCollection<Names> name;
        public ObservableCollection<Names> Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        public Command AddNameCmd => new Command(() =>
        {
            //ListOfNames.Add(NewNameToAdd);

            items.Add(new Names
            {
                FirstName = NewNameToAdd
            });
        });


    }
}
