using MySql.Data.MySqlClient;

namespace ProjetCrud
{
    public class Utilisateur
    {
        public int ContactId { get; set; }
        public string ContactNom { get; set; }
        public string ContactPrenom { get; set; }
        public string ContactMail { get; set; }
        public string ContactMdp { get; set; }
        public int ContactAdmin { get; set; }
        public string ContactStatut { get; set; }
        public void save(DBConnection LaConnexion)
        {
            if (ContactId == 0)
            {
                String query = "INSERT INTO utilisateurs (nom,prenom,mail,mdp,admin) VALUES (@ContactNom,@ContactPrenom,@ContactMail,@ContactMdp,@ContactAdmin);";

                String queryId = "SELECT idu FROM utilisateurs where nom = @ContactNom;";



                using (MySqlCommand cmd = new MySqlCommand(query, LaConnexion.Connection))
                {


                    cmd.Parameters.AddWithValue("@ContactNom", ContactNom);
                    cmd.Parameters.AddWithValue("@ContactPrenom", ContactPrenom);
                    cmd.Parameters.AddWithValue("@ContactMail", ContactMail);
                    cmd.Parameters.AddWithValue("@ContactMdp", Crypto.HasherMotDePasse(ContactMdp));
                    cmd.Parameters.AddWithValue("@ContactAdmin", ContactAdmin);



                    cmd.ExecuteNonQuery();

                }

                using (MySqlCommand cmdId = new MySqlCommand(queryId, LaConnexion.Connection))
                {

                    cmdId.Parameters.AddWithValue("@ContactNom", ContactNom);



                    var reader = cmdId.ExecuteReader();
                    reader.Read();
                    ContactId = (int)reader[0];

                }

                LaConnexion.Connection.Close();

            }
            else
            {
                String query = "UPDATE utilisateurs SET nom = @ContactNom, prenom = @ContactPrenom, mail = @ContactMail, mdp = @ContactMdp, admin = @ContactAdmin where idu = @ContactId;";

                using (MySqlCommand cmd = new MySqlCommand(query, LaConnexion.Connection))
                {

                    cmd.Parameters.AddWithValue("@ContactId", ContactId);
                    cmd.Parameters.AddWithValue("@ContactNom", ContactNom);
                    cmd.Parameters.AddWithValue("@ContactPrenom", ContactPrenom);
                    cmd.Parameters.AddWithValue("@ContactMail", ContactMail);
                    cmd.Parameters.AddWithValue("@ContactAdmin", ContactAdmin);
                    cmd.Parameters.AddWithValue("@ContactMdp", Crypto.HasherMotDePasse(ContactMdp));



                    cmd.ExecuteNonQuery();

                }

            }
        }

        public void delete(DBConnection LaConnexion)
        {
            String queryId1 = "DELETE FROM connexion WHERE idu = @ContactId";

            using (MySqlCommand cmdId1 = new MySqlCommand(queryId1, LaConnexion.Connection))
            {

                cmdId1.Parameters.AddWithValue("@ContactId", ContactId);



                cmdId1.ExecuteNonQuery();
            }

                String queryId2 = "DELETE FROM utilisateurs WHERE idu = @ContactId";

            using (MySqlCommand cmdId2 = new MySqlCommand(queryId2, LaConnexion.Connection))
            {

                cmdId2.Parameters.AddWithValue("@ContactId", ContactId);



                cmdId2.ExecuteNonQuery();

            }

        }

        public void archivage (DBConnection LaConnexion)
        {
            string statut = "";
            if(ContactStatut == "actif") {
                statut = "archivé";
            } else
            {
                statut = "actif";
            }
            String queryId = "UPDATE utilisateurs SET statut = @statut WHERE idu = @ContactId;";

            using (MySqlCommand cmdId = new MySqlCommand(queryId, LaConnexion.Connection))
            {

                cmdId.Parameters.AddWithValue("@ContactId", ContactId);
                cmdId.Parameters.AddWithValue("@statut", statut);



                var reader = cmdId.ExecuteNonQuery();

            }
        }
    }
}
