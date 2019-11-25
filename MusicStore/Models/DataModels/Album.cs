namespace MusicStore.Models.DataModels {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;

    public class Album {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlbumId { get; set; }
        //Complétez....


        [NotMapped]
        public string Cover { get => $"/Content/Images/Albums/{AlbumId}.jpg"; }
    }
}