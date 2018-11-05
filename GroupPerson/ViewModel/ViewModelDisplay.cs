using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GroupPerson.Model;
using Xamarin.Forms;

namespace GroupPerson.ViewModel
{
    /// <summary>
    /// Based on http://xamarinhelp.com/xamarin-forms-listview-grouping/
    /// </summary>
    public class ViewModelDisplay : INotifyPropertyChanged
    {
        public INavigation _navigation;
        public ViewModelDisplay(INavigation navigation)
        {
            _navigation = navigation;
            CreateList();
        }

        private void CreateList()
        {
            ListOfPeople = new List<PersonList>();

            var sList = new PersonList()
            {
                new Person() { FirstName = "Sally", LastName = "Sampson" },
                new Person() { FirstName = "Taylor", LastName = "Swift" },
                new Person() { FirstName = "John", LastName = "Smith" }
            };
            sList.Heading = "S";
            ListOfPeople.Add(sList);

            var dList = new PersonList()
            {
                new Person() { FirstName = "Jane", LastName = "Doe" }
            };
            dList.Heading = "D";
            ListOfPeople.Add(dList);

            var jList = new PersonList()
            {
                new Person() { FirstName = "Billy", LastName = "Joel" }
            };
            jList.Heading = "J";
            ListOfPeople.Add(jList);

            //var list = new List<PersonList>()
            //{
            //    sList,
            //    dList,
            //    jList
            //};

            //ListOfPeople = list;
        }

        private List<PersonList> _listOfPeople;
        public List<PersonList> ListOfPeople
        {
            get { return _listOfPeople; }
            private set 
            { 
                _listOfPeople = value;
                NotifyPropertyChanged("ListOfPeople");
            }
        }

        private Person _person;
        public Person SelectedPerson { 
            get { return _person; }
            set
            {
                _person = value;
                NotifyPropertyChanged("SelectedPerson");
                Application.Current.MainPage.DisplayAlert("Person", "Selected: " + value.DisplayName, "OK");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
