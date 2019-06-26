using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using System.Data;
using System.Data.SqlClient;
namespace DAL1
{
    public class ProductDal
    {
        public static List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\nam adjava\dot_net\first_project_nam\WPFEcomm\App_Data\Admin.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            string query = "SELECT * FROM product ";
            IDbCommand cmd = new SqlCommand(query, con as SqlConnection);

            con.Open();
            IDataReader reader = cmd.ExecuteReader();
            //Online data using streaming mechanism
            while (reader.Read())
            {
                int id = int.Parse(reader["productID"].ToString());
                string title = reader["title"].ToString();
                string description = reader["description"].ToString();

                products.Add(new Product()
                {
                    ID = id,
                    Title = title,
                    Description = description
                });

            }
            reader.Close();


            con.Close();

            return products;
        }
    }
}
    
    

