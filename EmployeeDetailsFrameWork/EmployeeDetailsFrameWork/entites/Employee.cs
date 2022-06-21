﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetailsFrameWork.entites

{
    public class Employee
    {
       

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; } 
        public ICollection<EmployeeOrganization> Organization { get; set; }
        

    } 

}
