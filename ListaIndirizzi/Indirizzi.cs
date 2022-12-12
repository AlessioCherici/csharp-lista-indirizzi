using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
    {
    public class PersonalData
        {
        public string nome;
        public string cognome;
        public string street;
        public string city;
        public string province;
        public string zipCode;

        public PersonalData(string nome, string cognome, string street, string city, string province, string zipCode)
            {
            this.nome = nome;
            this.cognome = cognome;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zipCode = zipCode;
            }

        //-------------------------- Metodo tostring --------------------------

        public override string ToString()
            {
            return this.nome + ", " + this.cognome + ", " + this.street + ", " + this.city + ", " +
            this.province + ", " + this.zipCode;
            }
        }
    }
