using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2M4.Model;

namespace M2M4.Controller{
    public class CursosImport{
        private List<Curs> cursos = new List<Curs>();

        // GEtter
        public List<Curs> Cursos { get {  return cursos; } }

        //Constructor
        public CursosImport(String path) {
            
        }
    }
}
