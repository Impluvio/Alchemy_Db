    using Alchemy_Db.Model;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    namespace Alchemy_Db.Views.Ingredients 

    {
        public class CreateModel : PageModel
        {
            public ingredientInfo ingredientInfo = new ingredientInfo();
            public string ErrorMessage { get; set; } = string.Empty;
            public string successMessage = "";

            public void OnGet()
            {
            
            }

            public void OnPost()
            {
                ingredientInfo.Name = Request.Form["Name"];
                ingredientInfo.Description = Request.Form["Description"];
                ingredientInfo.Imagefilelocation = Request.Form["Imagefilelocation"];
                ingredientInfo.QualityOne = Request.Form["QualityOne"];
                ingredientInfo.QualityTwo = Request.Form["QualityTwo"];
                ingredientInfo.QualityThree = Request.Form["QualityThree"];
                ingredientInfo.Category = Request.Form["Category"];

                if (ingredientInfo.Name.Length == 0 || ingredientInfo.Description.Length == 0 ||
                    ingredientInfo.Imagefilelocation.Length == 0 || ingredientInfo.QualityOne.Length == 0 || ingredientInfo.QualityTwo.Length == 0 ||
                    ingredientInfo.QualityThree.Length == 0 || ingredientInfo.Category.Length == 0)
                {
                    ErrorMessage = "All the fields are required";
                    return;
                }
                // save new ingredient
                ingredientInfo.Name = "";
                ingredientInfo.Description = "";
                ingredientInfo.Imagefilelocation = "";
                ingredientInfo.QualityOne = "";
                ingredientInfo.QualityTwo = "";
                ingredientInfo.QualityThree = "";
                ingredientInfo.Category = "";
                successMessage = "New Ingredient Added";

                // Handle form submission here
                
            }
        }
    }

