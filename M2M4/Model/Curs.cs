using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace M2M4.Model{
        public class Curs
        {
            private List<Modul> moduls = new List<Modul>();
            public static string nom;
            public static string any;

            public Curs() { }

            // Getter para moduls
            public List<Modul> GetModuls()
            {
                return moduls;
            }

            // Setter para moduls
            public void SetModuls(List<Modul> moduls)
            {
                this.moduls = moduls;
            }

            // Getter para nom
            public  string GetNom()
            {
                return nom;
            }

            // Setter para nom
            public  void SetNom(string value)
            {
                nom = value;
            }

            // Getter para any
            public string GetAny()
            {
                return any;
            }

            // Setter para any
            public void SetAny(string value)
            {
                any = value;
            }
        }

    }
