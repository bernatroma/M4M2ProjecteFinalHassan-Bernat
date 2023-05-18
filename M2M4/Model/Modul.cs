using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2M4.Model{
    public class Modul{
        private String nom;
        private String uf;
        private List<Alumne> alumnes;

        //Getters
        public String getNom(){
            return nom;
        }
        public String getUF(){
            return uf;
        }
        public List<Alumne> getAlumnes()
        {
            return alumnes;
        }

        //Setters
        public void setNom(String nom){
            this.nom = nom;
        }
        public void setUF(String uf){
            this.uf = uf;
        }

        
    }
}
