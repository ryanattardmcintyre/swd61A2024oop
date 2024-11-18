using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_DataLayer
{
    public class Book
    {
        [Key]//that the underneath property becomes the primary key
        public int Isbn { get; set; }
        public string Name { get; set; }

        public int CategoryFK { get; set; }

        //The ForeignKey  attribute has effect on the underneath property.
        //its telling the underneath to be populated with data related to the value stored
        //in CategoryFk 
        [ForeignKey("CategoryFK")]
        public virtual Category Category { get; set; } //navigational property
        //note: since navigational properties give you all the data realted to that particular class
        //.e.g Category, that means that coding inner join (later on) is not needed

    }
}
