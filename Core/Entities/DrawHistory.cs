using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DrawHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Range(1, 50)]
        public int FirstNumber { get; set; }

        [Range(1,50)]
        public int SecondNumber { get; set; }

        [Range(1, 50)]
        public int ThirdNumber { get; set; }

        [Range(1, 50)]
        public int FourthNumber { get; set; }

        [Range(1, 50)]
        public int FifthNumber { get; set; }

        public DateTime Created { get; set; }
        
    }
}
