using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace Alchemy_Db.Views.Ingredients
{
    public class IndexModel : PageModel
    {
        public List<ingredientRecall> listIngredients = new List<ingredientRecall>();

        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=LAPTOP-NPB68NG0;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlIngredientQuery = "SELECT * FROM Ingredients";
                    
                    using (SqlCommand command = new SqlCommand(sqlIngredientQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ingredientRecall ingredientRecall = new ingredientRecall();
                                ingredientRecall.Id = "" + reader.GetInt32(0);
                                ingredientRecall.Name = reader.GetString(1);
                                ingredientRecall.Description = reader.GetString(2);
                                ingredientRecall.Imagefilelocation = reader.GetString(3); // this isnt passed through to ui.
                                ingredientRecall.QualityOne = reader.GetString(4);
                                ingredientRecall.QualityTwo = reader.GetString(5);
                                ingredientRecall.QualityThree = reader.GetString(6);
                                ingredientRecall.Category = reader.GetString(7);
                                
                            }
                        }
                    }
                   
                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

        }
    }
    public class ingredientRecall
    {
        public string Id;
        public string Name;
        public string Description;
        public string Imagefilelocation;
        public string QualityOne;
        public string QualityTwo;
        public string QualityThree;
        public string Category;
       


    }

}
