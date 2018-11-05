using System;
using System.Collections.Generic;

namespace GroupPerson.Model
{
    /// <summary>
    /// Based on http://xamarinhelp.com/xamarin-forms-listview-grouping/
    /// </summary>
    public class PersonList : List<Person>
    {
        public string Heading { get; set; }
        public List<Person> Persons => this;
    }
}
