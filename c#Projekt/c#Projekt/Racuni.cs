using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace c_Projekt {
    internal class Racuni {

        private string ime;
        private string prezime;
        private string kontakt;
        private string lozinka;
        private string userId;

        public Racuni() {; }



        public Racuni(string ime, string prezime, string kontakt, string lozinka, string userId) {
            this.ime = ime;
            this.prezime = prezime;
            this.kontakt = kontakt;
            this.lozinka = lozinka;
            this.userId = userId;
        }

        public void SetIme(string ime) { this.ime = ime; }
        public string GetIme() { return this.ime; }

        public string GetPrezime() { return this.prezime; }
        public void SetPrezime(string prezime) { this.prezime = prezime; }

        public string GetKontakt() { return this.kontakt; }
        public void SetKontakt(string kontakt) { this.kontakt = kontakt; }

        public string GetLozinka() { return this.lozinka; }
        public void SetLozinka(string lozinka) { this.lozinka = lozinka; }

        public string UserId {
            get { return userId; }
            set { userId = value; }
        }

       


    }
}

