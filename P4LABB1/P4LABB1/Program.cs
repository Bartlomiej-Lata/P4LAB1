using System;
using System.Data.SqlClient;

namespace P4LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionstring = @"Data Source=DESKTOP-DLS69EU\SQLEXPRESS;Initial Catalog=ZNorthwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();

            var zapytanie = "Select * FROM mg.kategorie";

            var command = new SqlCommand(zapytanie, connection);



            var dodanie = "INSERT INTO mg.kategorie (IDkategorii, NazwaKategorii, Opis) VALUES ('9', 'Przekaski', ' ');";

            var command1 = new SqlCommand(dodanie, connection);

            command1.ExecuteNonQuery();


            Console.WriteLine("Dodano nowa kategorie : Przekaski, podaj jakie produkty maja sie w niej znalezc");

            var podana = Console.ReadLine();

            var modyfikacja = @"UPDATE mg.kategorie 
                                SET Opis = '" + podana +
                                "'WHERE IDkategorii = 9";

            var command2 = new SqlCommand(modyfikacja, connection);

            command2.ExecuteNonQuery();




            var usuniecie = @"	
                                DELETE FROM mg.kategorie
                                WHERE IDkategorii = '9'; ";


            var command3 = new SqlCommand(usuniecie, connection);
            command3.ExecuteNonQuery();




            connection.Close();
        }
    }
}
