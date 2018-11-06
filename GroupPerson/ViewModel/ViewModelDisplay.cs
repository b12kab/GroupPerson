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
            var sList = new PersonList()
            //var sPerson = new List<Person>
            {
                new Person() { FirstName = "Sally", LastName = "Sampson" },
                new Person() { FirstName = "Taylor", LastName = "Swift" },
                new Person() { FirstName = "John", LastName = "Smith" }
            };
            //var sList = new PersonList() { sPerson };
            //sList.Persons = sPerson;
            sList.Heading = "S";

            var dList = new PersonList()
            //var dPerson = new List<Person>
            {
                new Person() { FirstName = "Jane", LastName = "Doe" }
            };
            //var dList = new PersonList(dPerson);
            //dList.Persons = dPerson;
            dList.Heading = "D";

            var jList = new PersonList()
            //var jPerson = new List<Person>
            {
                new Person() { FirstName = "Billy", LastName = "Joel" }
            };
            //var jList = new PersonList(jPerson);
            //jList.Persons = jPerson;
            jList.Heading = "J";

            ListOfPeople = new List<PersonList>()
            {
                dList,
                jList,
                sList
            };

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
