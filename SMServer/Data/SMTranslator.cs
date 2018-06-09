using System;
using Data.Models;
using IO.Swagger.Models;

public class SMTranslator
{
    /// <summary>
    /// Translates the student.
    /// </summary>
    /// <returns>The student.</returns>
    /// <param name="studentDataModel">Student data model.</param>
    public static Student TranslateStudent(StudentDataModel studentDataModel)
    {
        Student student = new Student();
        student.Id = studentDataModel.ID.ToString();
        student.Name = studentDataModel.Name;
        student.Dob = studentDataModel.DateOfBirth.ToString();

        AdditionalInformation additionalInformation = new AdditionalInformation();

        Height studentHeight = new Height();
        studentHeight.Value = studentDataModel.Height;
        studentHeight.Unit = Height.UnitEnum.FtEnum;

        additionalInformation.Height = studentHeight;

        Weight studentWeight = new Weight();
        studentWeight.Value = studentDataModel.Weight;
        studentWeight.Unit = Weight.UnitEnum.KgEnum;

        additionalInformation.Weight = studentWeight;

        student.AdditionalInformation = additionalInformation;

        student.Grade = translateGrade(studentDataModel.GradeDM);
        return student;
    }

    /// <summary>
    /// Translates the grade.
    /// </summary>
    /// <returns>The grade.</returns>
    /// <param name="gradeDataModel">Grade data model.</param>
    private static Grade translateGrade(GradeDataModel gradeDataModel)
    {
        Grade grade = new Grade();
        grade.Id = gradeDataModel.ID.ToString();
        grade.Name = gradeDataModel.Name;
        grade.Section = gradeDataModel.Section;

        return grade;
    }
}