using System;

namespace T14
{
    class DeveloperInfoAttribute : Attribute
    {
        public string NameDeveloper { get; set; }
        public string DateCreating { get; set; }
        public DeveloperInfoAttribute(string developer, string date)
        {
            NameDeveloper = developer;
            DateCreating = date;
        }
    }
}