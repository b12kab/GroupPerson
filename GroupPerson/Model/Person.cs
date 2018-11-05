using System;
namespace GroupPerson.Model
{
    /// <summary>
    /// Based on http://xamarinhelp.com/xamarin-forms-listview-grouping/
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
    }
}
