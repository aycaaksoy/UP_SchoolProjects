namespace UP_School_API_Consume.Models
{
    public class CategoryViewModel
    {

        public class Rootobject
        {
            public CategoryViewModel[] Property1 { get; set; }
        }

        
            public int categoryID { get; set; }
            public string categoryName { get; set; }
            public string description { get; set; }
            public bool status { get; set; }
        

    }
}
