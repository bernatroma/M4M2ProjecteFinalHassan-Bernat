using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using M2M4.Model;

namespace M2M4.Controller{
    public class CursosImport{
        private static List<Curs> cursos = new List<Curs>();

        // GEtter
        public List<Curs> Cursos { get {  return cursos; } }

        //Constructor
        public CursosImport(String test) { 
        
        }
    }
}
