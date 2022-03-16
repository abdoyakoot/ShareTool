using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShareTool.Models
{
    public class SharedTool
    {

        [Required(ErrorMessage ="يجب ادخال الاسم ")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="يجب ادخال الوصف ")]
        public string Description { get; set; }

        public int Quantity { get; set; }

        public SharedTool( string name,string description,int quantity)
        {
            this.Name = name;
            this.Description = description;
            this.Quantity = quantity;
        }
        public SharedTool()
        {

        }
    }
}