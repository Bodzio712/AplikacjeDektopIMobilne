using System.IO;
using System.Xml.Serialization;

namespace ProjektAplikacjeDesktopIMobilne.XML
{
    public static class XMLActions
    {
        public static Biblioteka.Model.Employee ReadEmployees(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Biblioteka.Model.Employee));
            FileStream fs = new FileStream(filename, FileMode.Open);
            Biblioteka.Model.Employee employee;
            employee = (Biblioteka.Model.Employee)serializer.Deserialize(fs);
            fs.Close();
            return employee;
        }

        public static void SaveEmployees(string filename, Biblioteka.Model.Employee employee)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Biblioteka.Model.Employee));
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, employee);
            writer.Close();
        }
    }
}
