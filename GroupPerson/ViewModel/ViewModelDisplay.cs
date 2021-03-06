﻿using System;
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
            Person one = new Person() { FirstName = "Sally", LastName = "Sampson" };
            Person two = new Person() { FirstName = "Taylor", LastName = "Swift" };
            Person three = new Person() { FirstName = "John", LastName = "Smith" };
            var sPerson = new List<Person>();
            sPerson.Add(one);
            sPerson.Add(two);
            sPerson.Add(three);

            var sList = new PersonList();
            //var sPerson = new List<Person>
            //{
            //    new Person() { FirstName = "Sally", LastName = "Sampson" },
            //    new Person() { FirstName = "Taylor", LastName = "Swift" },
            //    new Person() { FirstName = "John", LastName = "Smith" }
            //};
            //sList.Persons.AddRange(sPerson);
            //sList.Persons.Remove(three);
            sList.AddRange(sPerson);
            sList.Heading = "S";

            Person four = new Person() { FirstName = "Jane", LastName = "Doe" };
            var dList = new PersonList()
            {
                //new Person() { FirstName = "Billy", LastName = "Joel" }
                four
            };
            dList.Heading = "D";

            Person five = new Person() { FirstName = "Billy", LastName = "Joel" };
            var jList = new PersonList();
            //{
            //    new Person() { FirstName = "Billy", LastName = "Joel" }
            //};
            //var jList = new PersonList(jPerson);
            jList.Add(five);
            jList.Heading = "J";

            ListOfPeople = new List<PersonList>()
            {
                dList,
                jList,
                sList
            };
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
