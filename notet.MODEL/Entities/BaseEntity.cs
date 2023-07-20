using notet.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notet.MODEL.Entities
{
    public class BaseEntity
    {
        public BaseEntity() { 
            CreatedDate= DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public DataStatus DataStatus { get; set; }
        
    }
}
