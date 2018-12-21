using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;


namespace Projekat_20_dec_v_2.Models
{
    [Table ("Obrazac")]
    public class Obrazac
    {
        [Key] public int IdSkole { get; set; }

        [Required(ErrorMessage = "Podatak o nazivu skole je obavezan!")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Podatak o nazivu skole mora biti od 2 do 40 karaktera!")]
        [Display(Name = "Naziv Skole")]
        public string NazivSkole { get; set; }

        [Required(ErrorMessage = "Podatak o adresi je obavezan!")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Podatak o adresi mora biti od 5 do 30 karaktera!")]
        public string Adresa { get; set; }

        [Required(ErrorMessage = "Podatak o opstini je obavezan!")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Podatak o opstini mora biti od 5 do 30 karaktera!")]
        public string Opstina { get; set; }

        [Required(ErrorMessage = "Podatak o postanskom broju je obavezan!")]
        [Range(10000, 99999, ErrorMessage = "Podatak o postanskom broju mora imati tacno 5 cifara!")]
        [Display(Name = "Postanski Broj")]
        public string PostanskiBroj { get; set; }

        [Required(ErrorMessage = "Podatak o Maticnom broju skole je obavezan!")]
        //[Range(100000000, 999999999, ErrorMessage ="Podatak o maticnom broju skole mora imati tacno 13 cifara!")]
        [Display(Name = "Maticni Broj Skole")]
        public string Maticni_Broj_Skole { get; set; }

        [Required(ErrorMessage = "Podatak o PIB-u je obavezan!")]
        //[Range(1000, 9999, ErrorMessage = "Podatak o PIB-u mora imati tacno 4 cifara!")]
        [Display(Name = "PIB")]
        public string Pib { get; set; }

        [Required(ErrorMessage = "Podatak o broju racuna skole je obavezan!")]
        [Range(100000000, 999999999, ErrorMessage = "Podatak o broju racuna skole mora imati tacno 9 cifara!")]
        [Display(Name = "Broj Racuna Skole")]
        public string BrojRacunaSkole { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "Podatak o web adresi mora biti u opsegu od 5 do 20 karaktera!")]
        public string Website { get; set; }

        [StringLength(30, ErrorMessage = "Beleske moraju biti do 30 karaktera")]
        public string Beleska { get; set; }

        [Required(ErrorMessage = "Podatak o imenu je obavezan!")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Podatak o imenu mora biti od 3 do 15 karaktera!")]
        [Display(Name = "Ime")]
        public string ime { get; set; }

        [Required(ErrorMessage = "Podatak o prezimenu je obavezan!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = " Podatak o prezimenu mora biti od 3 do 20 karaktera!")]
        [Display(Name = "Prezime")]
        public string prezime { get; set; }

        [Required(ErrorMessage = "Podatak o radnom mestu je obavezan!")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Podatak o radnom mestu mora biti od 5 do 15 karaktera!")]
        [Display(Name = "Radno Mesto")]
        public string radno_mesto { get; set; }

         [Required(ErrorMessage = "Podatak o oznaci tipa je obavezan!")]
         [Display(Name = "Oznaka Tipa")]
         public string oznaka_tipa { get; set; }

        public IEnumerable<SelectListItem> TypeList
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem { Text = "Kancelarijski", Value = "Kancelarijski"},
                    new SelectListItem { Text = "Sluzbeni", Value = "Sluzbeni"}
                };
            }
        }


        [Required(ErrorMessage = "Podatak o broju telefona je obavezan!")]
        // [Range(100000, 999999999, ErrorMessage =
        //  "Podatak o broju telefona mora imati od 6 do 9 cifara!")]
        [Display(Name = "Broj Telefona")]
        public string broj_telefona { get; set; }


        [Display(Name = "Lokal")]
        [Range(100, 999, ErrorMessage = "Podatak o lokalu mora imati tacno 3 cifre!")]
        public string lokal { get; set; }

        /*[Required(ErrorMessage = "Podatak o oznaci tipa je obavezan!")]*/
        [Display(Name = "Oznaka Tipa Email-a")]
        public string oznaka_tipa_mail { get; set; }

        public IEnumerable<SelectListItem> TypeListEmail
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem { Text = "Kancelarijski", Value = "Kancelarijski"},
                    new SelectListItem { Text = "Sluzbeni", Value = "Sluzbeni"}
                };
            }
        }



        [Required(ErrorMessage = "Podatak o adresi je obavezan!")]
        [StringLength(36, MinimumLength = 5, ErrorMessage = "Podatak o adresi mora biti od 5 do 36 karaktera!")]
        [Display(Name = "Email adresa")]
        public string Email_adresa { get; set; }


    }
}