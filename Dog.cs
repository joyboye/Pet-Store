using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dog_Store_App.Data
{
    public class Dog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }
        public string DogName { get; set; }
        public string Breeds { get; set; }
        public string color  { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public int PID { get; set; }
        [ForeignKey("PID")]
        public Pet_Stores Pet { get; set; }




    }
}
