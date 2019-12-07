namespace MusicStore.Models.DataModels {
    using System.ComponentModel.DataAnnotations;

    public class Panier {
        [Key]
        public int UtilisateurId { get; set; }
        [Key]
        public int AlbumId { get; set; }
    }
}