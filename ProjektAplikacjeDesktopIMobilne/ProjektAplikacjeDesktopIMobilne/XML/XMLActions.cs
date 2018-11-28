using System.IO;
using System.Xml.Serialization;

namespace ProjektAplikacjeDesktopIMobilne.XML
{
    public static class XMLActions
    {
        /// <summary>
        /// Metoda zapisująca pracownika do XML
        /// </summary>
        /// <param name="filename">Ścieżka wzglądna do XML</param>
        /// <returns></returns>
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

        public static Biblioteka.Model.Department ReadDepartment(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Biblioteka.Model.Department));
            FileStream fs = new FileStream(filename, FileMode.Open);
            Biblioteka.Model.Department department;
            department = (Biblioteka.Model.Department)serializer.Deserialize(fs);
            fs.Close();
            return department;
        }

        public static void SaveDepartment(string filename, Biblioteka.Model.Department department)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Biblioteka.Model.Department));
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, department);
            writer.Close();
        }
    }

}
