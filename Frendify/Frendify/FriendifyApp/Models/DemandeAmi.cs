using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Builder;
using CircleApp.Models;

namespace CircleApp.Models
{
    public class DemandeAmi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DemandeAmiId { get; set; }

        
        public int UserId { get; set; }
       public User User { get; set; }
        public int DestinataireId { get; set; }
        public User Destinataire { get; set; }


        public DateTime DateHeure { get; set; } = DateTime.Now;

        //public bool Accepter {  get; set; } = false;

        public bool Status { get; set; } = false; 

       public DateTime? DateReponse { get; set; }


        public enum DemandeStatus
        {
            EnAttente = 0, //il faut attendre que lutilisateur a qui on a fait la demande fasse une reponse
            Acceptee = 1, // lutilisateur acceoter
            Rejetee = 2, // lutilisateur rejete  ***revoir 
        }


    }

}
