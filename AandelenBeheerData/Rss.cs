﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AandelenBeheerData
{
    public class Rss
    {
        private string connectionString;

        public string MyProperty
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        private SqlConnection GetDbConnectie()
        {
            return new SqlConnection(connectionString);
        }

        public void Bewaar(string titel, string auteur, string inhoud, string link, DateTime publicatieTijd)
        {
            string insertSqlText = "INSERT INTO Rss(Titel, Auteur, Inhoud, Link, PublicatieTijd) VALUES(@titel, @auteur, @inhoud, @link, @publicatietijd)";

            SqlCommand insertSql = new SqlCommand(insertSqlText);
            insertSql.Connection = GetDbConnectie();
            insertSql.Parameters.Add(new SqlParameter("@titel", titel));
            insertSql.Parameters.Add(new SqlParameter("@auteur", auteur));
            insertSql.Parameters.Add(new SqlParameter("@inhoud", inhoud));
            insertSql.Parameters.Add(new SqlParameter("@link", link));
            insertSql.Parameters.Add(new SqlParameter("@publicatietijd", publicatieTijd));

            try
            {
                insertSql.Connection.Open();
                insertSql.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Bewaren Rss mislukt " + ex.Message);
            }
            finally
            {
                if(insertSql.Connection.State != ConnectionState.Open)
                {
                    insertSql.Connection.Close();
                }
            }
              
        }

    }
}
