using System;
using IO.Swagger.Models;

namespace Data.Models
{
    /**
     * CodeFirst Approach for Generating Student Table
     */
    public class StudentDataModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }

        public GradeDataModel GradeDM { get; set; }

        public StudentDataModel()
        {
            this.GradeDM = new GradeDataModel();    
        }

        public StudentDataModel(Student student)
        {
            this.Name = student.Name;
            this.DateOfBirth = DateTime.Parse(student.Dob);
            this.Height = student.AdditionalInformation.Height.Value;
            this.Weight = student.AdditionalInformation.Weight.Value;

            this.GradeDM = new GradeDataModel(student.Grade);
        }
    }
}
