using System;
using System.Collections.Generic;
using MvvmHelpers;
using Xamarin.Forms;

namespace DataTemplateSelectorTest.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
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

        public MainPageViewModel()
        {
            ListOfNames = new List<object>
            {
                "Bob", "John", "Paul", "Mike", "Billy", "Mark"
            };
        }

        public Command AddNameCmd => new Command(() =>
        {
            ListOfNames.Add(NewNameToAdd);
        });

    }
}
