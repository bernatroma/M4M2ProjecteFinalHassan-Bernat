using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using M2M4.DAO;

namespace M2M4.Model
{
    public static class cursos
    {
        public static List<Curs> listcursos = new List<Curs>();
        public static List<Alumne> alumnesList = new List<Alumne>();
        public static List<Modul> modulList = new List<Modul>();


        public static bool carregarModel(string filepath)
        {
            bool bres = false ;
            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);
            XmlNodeList cursos = doc.SelectNodes("//curs");
            foreach (XmlNode curs in cursos){
                Curs cur = new Curs();
                cur.SetNom(curs.Attributes["curs"].Value);
                cur.SetAny(curs.Attributes["any"].Value);
                listcursos.Add(cur);
                cursDAO.insertCurs(cur);
                XmlNodeList modulC = curs.SelectNodes("modul");
                foreach (XmlNode modul in modulC) {
                    Modul modulObj = new Modul();
                    modulObj.uf = modul.Attributes["UF"].Value;
                    modulObj.nom = modul.Attributes["modul"].Value;
                    modulList.Add(modulObj);
                    modulDAO mdao = new modulDAO();
                    mdao.modulInsert(modulObj);
                    XmlNodeList Alumnes = modul.SelectNodes("alumne");
                    foreach (XmlNode al in Alumnes)
                    {
                        Alumne alumneObj = new Alumne();
                        alumneObj.name = al.SelectSingleNode("nom").InnerText;
                        alumneObj.lastName = al.SelectSingleNode("cognom").InnerText;
                        alumneObj.age = int.Parse( al.SelectSingleNode("edat").InnerText);
                        alumnesList.Add(alumneObj);
                        alumneDAO.insertAlumne(alumneObj);
                    }
                }
            }
            bool dbConnResult = M2M4DAO.Connect();
            if (dbConnResult)
            {

            }
            return bres;
        }
    }
}
