﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2M4.Model {
    public class Alumne {
        public String name;
        public String lastName;
        public int age;

        public Alumne() { }

        //Getters
        public String getName(){
            return name;
        }
        public String getLastName(){
            return lastName;
        }
        public int getAge() { 
            return age;
        }

        // Setters
        public void setName(String name) {
            this.name = name;
        }
        public void setLastName(String lastName){
            this.lastName = lastName;
        }
        public void setAge(int age){
            this.age = age;
        }

    }
}
