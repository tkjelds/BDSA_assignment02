using static Student.Student;

namespace Assignment2.Tests;
public class StudentTests{
    [Fact]
    public void StudentToStringTest()
    {
        // Given
        var student = new Student.Student(1,"Tore","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", null),
        DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null));
        // When
        var result = student.ToString();
        // Then
        Assert.Equal(
            "Name: Tore Kjelds. Status: Active StartDate: 08/10/2018 EndDate: 10/10/2023 GraduationDate 10/10/2023",
            result
        );
    }

    [Fact]
    public void StudentGraduationStatusEqualDropoutTest()
    {
        // Given
        var student = new Student.Student(1,"Tore","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", null),
        DateTime.ParseExact("10/10/2019","dd/MM/yyyy", null),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null));
        // When
        var result = student.Status;

        Assert.Equal(status.Dropout,result);
    }
    [Fact]
    public void StudentGraduationStatusEqualActiveTest()
    {
        // Given
        var student = new Student.Student(1,"Tore","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", null),
        DateTime.ParseExact("10/10/2024","dd/MM/yyyy", null),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null));    
        // When
        var result = student.Status;
        // Then
        Assert.Equal(status.Active,result);
    }

    [Fact]
    public void StudentGraduationStatusEqualGraduatedTest()
    {
        // Given
        var student = new Student.Student(1,"Tore","Kjelds",DateTime.ParseExact("18/09/2020","dd/MM/yyyy", null),
        DateTime.ParseExact("10/10/2025","dd/MM/yyyy", null),DateTime.ParseExact("10/10/2021","dd/MM/yyyy", null));    
        // When
        var result = student.Status;
        // Then
        Assert.Equal(status.Graduated,result);
    }
}