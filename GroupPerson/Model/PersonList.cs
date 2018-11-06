using System;
using System.Collections.Generic;

namespace GroupPerson.Model
{
    /// <summary>
    /// Based on http://xamarinhelp.com/xamarin-forms-listview-grouping/
    /// 
    /// This wasn't obvious to me, but the part that makes this work at all
    /// is the class definition with "List<Person>". If the list is either 
    /// removed or left un-initialized, the XAML group binding will be empty.
    /// 
    /// I commented the Persons part, to make very clear.
    /// 
    /// While this way of creating the data for the group binding allows 
    /// the straightforward XAML - MVVM - item selected to be used, 
    /// it makes it difficult to create this list dynamically
    /// at a later point in time.
    /// The point of this is shown with the name list out of order and no way 
    /// to change this except at this object's creation time.
    /// </summary>
    public class PersonList : List<Person>
    {
        public string Heading { get; set; }
        //public List<Person> Persons => this;
    }
}
