using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SicIdev.API.Models
{
    public class Selection
    {
        public virtual int Id { get; set; }
        //Nom du projet
        [DataType(DataType.MultilineText)]
        [DisplayName("Description du pojet")]
        public virtual string Projet { get; set; }
        //Provenant du DG
        [DisplayName("Provenant de ")]
        public virtual string ProvenantDe { get; set; }
        [DisplayName("Département imputé ")]
        public virtual int DepartementId { get; set; }
        public virtual Departement Departement { get; set; }
        //Nature Dossier
        [DisplayName("Nature")]
        public virtual int NatureaoId { get; set; }
        public virtual Natureao Natureao { get; set; }
        [DisplayName("Echéance")]
        [DataType(DataType.Date)]
        public DateTime Echeance { get; set; }
        //Origine Dossier
        [DisplayName("Origine")]
        public virtual int OrigineaoId { get; set; }
        public virtual Origineao Origineao { get; set; }
        //Type Dossier
        [DisplayName("Type d'appel d'offre")]
        public virtual int TypeaoId { get; set; }
        public virtual Typeao Typeao { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date connaissance")]
        public virtual DateTime DateConnaissance { get; set; }
        //Pays et Ville
        [DisplayName("Pays")]
        public virtual int PaysId { get; set; }
        public virtual Pays Pays { get; set; }
        public virtual string Ville { get; set; }
        [DisplayName("Domaine d'activité")]
        public virtual string DomaineActivite { get; set; }
        //Client du projet
        [DisplayName("Client")]
        public virtual int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual bool Connu { get; set; }
        public virtual string Description { get; set; }
        //Prise en charge
        [DisplayName("Etat de prise en charge")]
        public virtual int PriseEnChargeId { get; set; }
        public virtual PriseEnCharge PriseEnCharge { get; set; }
        [DisplayName("Domaine")]
        public virtual int DomaineId { get; set; }
        public virtual Domaine Domaine { get; set; }
        public virtual string Commentaires { get; set; }
        [DisplayName("Nécessité Cadre Concertation ?")]
        public virtual bool CadreDeConcertation { get; set; }
        [DisplayName("Origine")]
        public virtual string ComplementInfos { get; set; }
        public virtual string Partenaire { get; set; }
        public virtual string Observations { get; set; }
        //Chargé de montage
        [Required]
        [DisplayName("Chargé de montage")]
        public virtual int AgentId { get; set; }
        public virtual Agent Agent { get; set; }
        //Visa Chef Service
        [DisplayName("Visa Chef Service")]
        public virtual string VisaChefService { get; set; }
        [DisplayName("Date Visa Chef Service")]
        [DataType(DataType.Date)]
        public virtual DateTime DateVisaCs { get; set; }
        //Visa Service commercial
        [DisplayName("Visa Servie commercial")]
        public virtual string VisaServiceCom { get; set; }
        [DisplayName("Date Visa Servie commercial")]
        [DataType(DataType.Date)]
        public virtual DateTime DateVisaCom { get; set; }
        //Visa DG
        [DisplayName("Visa DG")]
        public virtual string VisaDg { get; set; }
        [DisplayName("Date Visa DG")]
        [DataType(DataType.Date)]
        public virtual DateTime DateVisaDg { get; set; }


    }
}