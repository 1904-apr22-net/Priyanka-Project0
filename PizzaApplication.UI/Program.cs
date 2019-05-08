using System;

namespace PizzaApplication.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("r:\tEnter the customer detail");
                Console.WriteLine("a:\tEnter the location");
                Console.WriteLine("s:\tEnter the order.");
                Console.WriteLine("l:\tEnter the product.");
                Console.WriteLine();
                Console.Write("Enter valid menu option, or \"q\" to quit: ");
                var input = Console.ReadLine();
                if (input == "r")
                {

                    // array[] a = new int[10];
                    // if(a[i]=)
                    Console.WriteLine("Enter the idnumber of customer");
                    int cid = Console.ReadLine();
                    name(cid); 

                    
                   // Console.WriteLine("Enter the lastname of customer");
                }
                if(input=="a")
                {
                    Console.WriteLine("Enter the idnumber of storelocation");
                    int lid = Console.ReadLine();
                    location(lid);
                }
            }
        }
        public string name(int id)
        {
            var connstring  = $"SELECT * FROM Customer where cid={id};";
            // var dataset = new Dataset();
            getconnection();
            
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                DataColumn idColumn = dataSet.Tables[0].Columns["cid"];

                Console.WriteLine($"Customername #{row[idColumn]}: {row["Name"]}");
            }
          
        }

        public string location(int id)
        {
            var connstring = $"SELECT * FROM Location where lid={id};";
            // var dataset = new Dataset();
            getconnection();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                DataColumn idColumn = dataSet.Tables[0].Columns["cid"];

                Console.WriteLine($"LocationStore #{row[idColumn]}: {row["Name"]}");
            }
            // string fullname=
        }
    }
    }
    public static void getconnection()
{
    var dataset = new Dataset();
    using (var connection = new SqlConnection(connectionString))
    {
        // step 1: open the connection.
        connection.Open();

        using (var command = new SqlCommand(commString, connection))
        using (var adapter = new SqlDataAdapter(command))
        {
            // step 2: execute the query, filling the dataset.
            adapter.Fill(dataSet);
        }

        // step 3: close the connection.
        connection.Close();
    }
}