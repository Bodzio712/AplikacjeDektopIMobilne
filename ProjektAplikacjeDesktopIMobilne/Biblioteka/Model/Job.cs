using Biblioteka.BaseClass;
using System.Xml.Serialization;

namespace Biblioteka.Model
{
    public class Job : Notify
    {
        string nameOfJob;
        string salary;

        [XmlElement(ElementName = "NameOfJob")]
        public string NameOfJob
        {
            get { return this.nameOfJob; }
            set
            {
                if (this.nameOfJob != value)
                {
                    this.nameOfJob = value;
                    OnPropertyChanged("NameOfJob");
                }
            }
        }

        [XmlElement(ElementName = "Salary")]
        public string Salary
        {
            get { return this.salary; }
            set
            {
                if (this.salary != value)
                {
                    this.salary = value;
                    OnPropertyChanged("Salary");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Name of job: {0}\nSalary: {1}", NameOfJob, Salary);
        }

    }
}
