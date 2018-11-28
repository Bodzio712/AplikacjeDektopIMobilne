using Biblioteka.BaseClass;
using System.Xml.Serialization;


namespace Biblioteka.Model
{
    public class Department : Notify
    {
        string name;
        string address;
        string bossName;

        [XmlElement(ElementName = "Name")]
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        [XmlElement(ElementName = "Address")]
        public string Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged("Address");
                }
            }
        }

        [XmlElement(ElementName = "bossName")]
        public string BossName
        {
            get { return bossName; }
            set
            {
                if (bossName != value)
                {
                    bossName = value;
                    OnPropertyChanged("BossName");
                }
            }
        }
    
        public override string ToString()
        {
            return string.Format("Name: {0}\nAddress: {1}\nBoss Name: {2}", Name, Address, BossName);
        }


    }
}
