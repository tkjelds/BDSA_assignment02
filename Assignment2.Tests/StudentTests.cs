using System.Globalization;
using static Student.Student;

namespace Assignment2.Tests;
public class StudentTests
{
    [Fact]
    public void StudentToStringTest()
    {
        // Given
        var startDate = DateTime.ParseExact("08/10/2018", "dd/MM/yyyy", CultureInfo.CurrentCulture);
        var endDate = DateTime.ParseExact("10/10/2023", "dd/MM/yyyy", CultureInfo.CurrentCulture);
        var graduationDate = DateTime.ParseExact("10/10/2023", "dd/MM/yyyy", CultureInfo.CurrentCulture);

        var student = new Student.Student(1, "Tore", "Kjelds", startDate, endDate, graduationDate);

        // When
        var result = student.ToString();
        // Then
        Assert.Equal(
            result,
            $"Name: Tore Kjelds. Status: Active StartDate: {startDate.ToShortDateString()} EndDate: {endDate.ToShortDateString()} GraduationDate {graduationDate.ToShortDateString()}"
        );
    }

    [Fact]
    public void StudentGraduationStatusEqualDropoutTest()
    {
        // Given
        var student = new Student.Student(1, "Tore", "Kjelds", DateTime.ParseExact("08/10/2018", "dd/MM/yyyy", CultureInfo.CurrentCulture),
        DateTime.ParseExact("10/10/2019", "dd/MM/yyyy", CultureInfo.CurrentCulture), DateTime.ParseExact("10/10/2023", "dd/MM/yyyy", CultureInfo.CurrentCulture));
        // When
        var result = student.Status;

        Assert.Equal(status.Dropout, result);
    }
    [Fact]
    public void StudentGraduationStatusEqualActiveTest()
    {
        // Given
        var student = new Student.Student(1, "Tore", "Kjelds", DateTime.ParseExact("08/10/2018", "dd/MM/yyyy", CultureInfo.CurrentCulture),
        DateTime.ParseExact("10/10/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture), DateTime.ParseExact("10/10/2023", "dd/MM/yyyy", CultureInfo.CurrentCulture));
        // When
        var result = student.Status;
        // Then
        Assert.Equal(status.Active, result);
    }

    [Fact]
    public void StudentGraduationStatusEqualGraduatedTest()
    {
        // Given
        var student = new Student.Student(1, "Tore", "Kjelds", DateTime.ParseExact("18/09/2020", "dd/MM/yyyy", CultureInfo.CurrentCulture),
        DateTime.ParseExact("10/10/2025", "dd/MM/yyyy", CultureInfo.CurrentCulture), DateTime.ParseExact("10/10/2021", "dd/MM/yyyy", CultureInfo.CurrentCulture));
        // When
        var result = student.Status;
        // Then
        Assert.Equal(status.Graduated, result);
    }
}
