using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace M2M4.Model
{
    public static class cursos
    {
        public static List<Curs> list = new List<Curs>();

        public static bool carregarModel(string filepath)
        {
            bool bres = false ;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(filepath);
            XmlNodeList cursos = doc.SelectNodes("//curs");
            foreach (XmlNode curs in cursos)
            {
                Curs cur = new Curs();
                XmlNodeList modulC = curs.SelectNodes("modul");
                List<Modul> modulList = new List<Modul>();
                foreach (XmlNode modul in modulC) {
                    Modul modulObj = new Modul();
                    modulObj.uf = modul.Attributes["UF"].Value;
                    modulObj.nom = modul.Attributes["modul"].Value;
                    XmlNodeList Alumnes = modul.SelectNodes("alumne");
                    List<Alumne> alumnesList = new List<Alumne>();
                    foreach (XmlNode al in Alumnes)
                    {
                        Alumne alumneObj = new Alumne();
                        alumneObj.name = al.SelectSingleNode("nom").InnerText;
                        alumneObj.lastName = al.SelectSingleNode("cognom").InnerText;
                        alumneObj.age = int.Parse( al.SelectSingleNode("edat").InnerText);
                    }
                }
            }
            return bres;
        }
    }
}
