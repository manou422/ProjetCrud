using MySql.Data.MySqlClient;

namespace Projet_BTS2
{
    public class Utilisateur
    {
        public int ContactId { get; set; }
        public string ContactNom { get; set; }
        public string ContactPrenom { get; set; }
        public string ContactMail { get; set; }
        public string ContactMdp { get; set; }
        public int ContactAdmin { get; set; }
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
                String query = "UPDATE utilisateurs SET nom = @ContactNom, prenom = @ContactPrenom, mail = @ContactMail, mdp = @ContactMdp where idu = @ContactId;";

                using (MySqlCommand cmd = new MySqlCommand(query, LaConnexion.Connection))
                {

                    cmd.Parameters.AddWithValue("@ContactId", ContactId);
                    cmd.Parameters.AddWithValue("@ContactNom", ContactNom);
                    cmd.Parameters.AddWithValue("@ContactPrenom", ContactPrenom);
                    cmd.Parameters.AddWithValue("@ContactMail", ContactMail);
                    cmd.Parameters.AddWithValue("@ContactMdp", Crypto.HasherMotDePasse(ContactMdp));



                    cmd.ExecuteNonQuery();

                }

            }
        }

        public void delete(DBConnection LaConnexion)
        {
            String queryId = "DELETE FROM utilisateurs WHERE idu = @ContactId";

            using (MySqlCommand cmdId = new MySqlCommand(queryId, LaConnexion.Connection))
            {

                cmdId.Parameters.AddWithValue("@ContactId", ContactId);



                var reader = cmdId.ExecuteNonQuery();

            }

        }
    }
}
