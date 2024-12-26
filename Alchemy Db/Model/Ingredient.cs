namespace Alchemy_Db.Model
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Image { get; set; } // string will locate image in C
        public string qualityOne { get; set; }
        public string qualityTwo { get; set; }
        public string qualityThree { get; set; }
        public int Category { get; set; }

    }
}
