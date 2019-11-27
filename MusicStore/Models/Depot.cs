namespace MusicStore.Models {
    using MusicStore.Models.DAL;
    public class Depot {
        public DALUtilisateur Utilisateurs { get; private set; } = new DALUtilisateur();
    }

}