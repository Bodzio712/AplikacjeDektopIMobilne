using Biblioteka.BaseClass;
using System.Xml.Serialization;

namespace Biblioteka.Model
{
    public class Employee : Notify
    {
        string firstName;
        string lastName;
        string phone;
        string job;

        [XmlElement(ElementName = "FirstName")]
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        [XmlElement(ElementName = "LastName")]
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        [XmlElement(ElementName = "Phone")]
        public string Phone
        {
            get { return phone; }
            set
            {
                if (phone != value)
                {
                    phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }

        [XmlElement(ElementName = "Job")]
        public string Job
        {
            get { return job; }
            set
            {
                if (job != value)
                {
                    job = value;
                    OnPropertyChanged("Job");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}\nLast Name: {1}\nTelephone Number: {2}\nJob: {3}", FirstName, LastName, Phone, Job);
        }

    }
}
