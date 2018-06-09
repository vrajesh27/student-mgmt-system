using System;
using System.Collections.Generic;
using IO.Swagger.Models;

namespace Data.Models
{
    /**
    * CodeFirst Approach for Generating Grade Table
    */
    public class GradeDataModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }

        public ICollection<StudentDataModel> Students { get; set; }

        public GradeDataModel()
        {
            
        }

        public GradeDataModel(Grade grade)
        {
            this.Name = grade.Name;
            this.Section = grade.Section;
        }
    }    
}
