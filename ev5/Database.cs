using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ev5
{
    static class Database
    {
        private static List<string> allescholen = new List<string>();
        private static SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Environment.CurrentDirectory + @"\Database1.mdf; Integrated Security = True");

        private static List<string> allprojects = new List<string>();
        /*Deze methode vraagt uit de database het wachtwoord op bij het meegekregen wachtwoord*/
        public static string Getpassword(string username)
        {
            SqlCommand query = new SqlCommand("SELECT Wachtwoord FROM Inloggegevens WHERE Username = @parameter1", connection);
            //Stuurd de opgegeven username mee in de query, de query geeft het gevonden wachtwoord terug
            query.Parameters.AddWithValue("@parameter1", username);

            string password = "";
            //Opend de connectie met de database
            connection.Open();

            using (SqlDataReader reader = query.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        password = reader.GetString(0);
                    }
                    connection.Close();
                    return password;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                    connection.Close();
                    return null;
                }
            }
        }

        /*Voegt de meegekregen wachtwoord en username toe aan de database*/
        public static void CreateUser(string username, string password)
        {
            SqlCommand query = new SqlCommand("INSERT INTO Inloggegevens VALUES (@newusername, @newpassword)", connection);
            
            //set de parameters in de query met de opgegeven username en password
            query.Parameters.AddWithValue("@newusername", username);
            query.Parameters.AddWithValue("@newpassword", password);

            connection.Open();
            query.ExecuteNonQuery();
            connection.Close();
        }

        public static int GetUserId(string username)
        {
            SqlCommand query = new SqlCommand("SELECT Id FROM Inloggegevens WHERE Username = @parameter1", connection);
            //Stuurd de opgegeven username mee in de query, de query geeft het gevonden wachtwoord terug
            query.Parameters.AddWithValue("@parameter1", username);

            int id = 0;

            //Opend de connectie met de database
            connection.Open();

            using (SqlDataReader reader = query.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                    connection.Close();
                    return id;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                    connection.Close();
                    return 0;
                }
            }
        }

        public static void SetName(int id, string voornaam, string tussenvoegsel, string achternaam)
        {
            //Connect met de database en maak in een Sqlcommand aan (een query)
            SqlCommand query = new SqlCommand("INSERT INTO Naam VALUES (@id, @voornaam, @tussenvoegsel, @achternaam)", connection);
            //set de parameters in de query met de opgegeven username en password
            query.Parameters.AddWithValue("@id", id);
            query.Parameters.AddWithValue("@voornaam", voornaam);
            query.Parameters.AddWithValue("@tussenvoegsel", tussenvoegsel);
            query.Parameters.AddWithValue("@achternaam", achternaam);
            
            //opend de connectie met de database
            connection.Open();
            query.ExecuteNonQuery();
            connection.Close();
        }

        public static void Getschoolen()
        {
            allescholen.Clear();
            //connect met de database en maak een nieuw SqlCommand aan met daarin de query
            SqlCommand query = new SqlCommand("SELECT Schoolnaam FROM School", connection);
            
            connection.Open();

            using (SqlDataReader reader = query.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        allescholen.Add(reader.GetString(0));
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static void SetSchool(string schoolnaam, string schooladres, string schoolplaats)
        {
            //Connect met de database en maak in een Sqlcommand aan (een query)
            SqlCommand query = new SqlCommand("INSERT INTO School VALUES (@adres, @schoolnaam, @postcode)", connection);

            //set de parameters in de query met de opgegeven username en password
            query.Parameters.AddWithValue("@adres", schooladres);
            query.Parameters.AddWithValue("@schoolnaam", schoolnaam);
            query.Parameters.AddWithValue("@postcode", schoolplaats);
            allescholen.Add(schoolnaam);

            //opend de connectie met de database
            connection.Open();
            query.ExecuteNonQuery();
            connection.Close();
        }

        public static void Setgebruiker(int id, string email, string schoolnaam)
        {
            SqlCommand query = new SqlCommand("INSERT INTO gebruiker VALUES (@id, @schoolnaam, @email)", connection);

            query.Parameters.AddWithValue("@id", id);
            query.Parameters.AddWithValue("@schoolnaam", schoolnaam);
            query.Parameters.AddWithValue("@email", email);

            connection.Open();
            query.ExecuteNonQuery();
            connection.Close();
        }

        public static List<string> Returnallprojects()
        {
            SqlCommand query = new SqlCommand("SELECT Projectnaam FROM Project", connection);

            connection.Open();

            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    allprojects.Add(reader.GetString(0));
                }
            }

            connection.Close();

            return allprojects;
        }

        public static void Upload(string project, string projectnaam, string uploaddatum, int userid)
        {
            SqlCommand query = new SqlCommand("INSERT INTO Project VALUES (@projectid, @projectnaam, @uploaddatum, @project, @usesrid)", connection);

            //query.Parameters.AddWithValue("@id", id);
            //query.Parameters.AddWithValue("@schoolnaam", schoolnaam);
            // query.Parameters.AddWithValue("@email", email);

            connection.Open();
            query.ExecuteNonQuery();
            connection.Close();

        }

        public static List<string> GeefAlleScholen
        {
            get { return allescholen; }
        }

        public static List<string> allprojectslist
        {
            get { return allprojects; }
        }
    }
}
