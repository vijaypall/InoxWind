﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessObjectModel
{
   public class Career
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public string Location { get; set; }
        public string RequireQualification { get; set; }
        public string DetailPdf { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
}