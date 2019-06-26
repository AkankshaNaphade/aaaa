using System.ComponentModel.DataAnnotations; 
// provides inbuilt annotations 
// data level constraints

namespace BOL
{
    //metdata
    //.net we use special attribute
    //annotations are associated with b. objects
    //data level constraints
    //Rules
    //Policies

    //POCO object

    public class Product
    {
       //data constraints

        [Required]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
