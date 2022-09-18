namespace Classlib.Tests;
using Classlib;

using Xunit;
public class StudentTests
{
    [Fact]
    public void toString_return_student_info()
    {
        // Arrange
        // var student = new Student(1, "John", "Doe", new DateTime(2020, 1, 1), new DateTime(2021, 1, 1), new DateTime(2022, 1, 1));
        var student = new Student(1){
            GivenName = "John",
            Surname = "Doe",
            StartDate = new DateTime(2020, 1, 1),
            endDate = new DateTime(2021, 1, 1),
            graduationDate = new DateTime(2022, 1, 1)
        };

        // Act
        var result = student.ToString();

        // Assert
        result.Should().Be("Id: 1, Name: John Doe, Status: New, Start Date: 2020-01-01, End Date: 2021-01-01, Graduation Date: 2022-01-01");
    }

    [Fact]
    public void calculate_status_new()
    {
        // Arrange
        // var student = new Student(1, "John", "Doe", new DateTime(2023, 1, 1), new DateTime(2025, 1, 1), new DateTime(2025, 1, 1));
        var student = new Student(1){
            GivenName = "John",
            Surname = "Doe",
            StartDate = new DateTime(2023, 1, 1),
            endDate = new DateTime(2099, 1, 1),
            graduationDate = new DateTime(2099, 1, 1)
        };

        // Act
        var result = student.calculate();

        // Assert
        result.Should().Be(Status.New);
    }

    [Fact]
    public void calculate_status_active()
    {
        // Arrange
        // var student = new Student(1, "John", "Doe", new DateTime(2022, 1, 1), new DateTime(2025, 1, 1), new DateTime(2025, 1, 1));
        var student = new Student(1){
            GivenName = "John",
            Surname = "Doe",
            StartDate = new DateTime(2022, 1, 1),
            endDate = new DateTime(2099, 1, 1),
            graduationDate = new DateTime(2099, 1, 1)
        };

        // Act
        var result = student.calculate();

        // Assert
        result.Should().Be(Status.Active);
    }

    [Fact]
    public void calculate_status_dropout()
    {
        // Arrange
        // var student = new Student(1, "John", "Doe", new DateTime(2019, 1, 1), new DateTime(2020, 1, 1), new DateTime(2021, 1, 1));
        var student = new Student(1){
            GivenName = "John",
            Surname = "Doe",
            StartDate = new DateTime(2018, 1, 1),
            endDate = new DateTime(2019, 1, 1),
            graduationDate = new DateTime(2020, 1, 1)
        };

        // Act
        var result = student.calculate();

        // Assert
        result.Should().Be(Status.Dropout);
    }

    [Fact]
    public void calculate_status_graduated()
    {
        // Arrange
        // var student = new Student(1, "John", "Doe", new DateTime(2020, 1, 1), new DateTime(2021, 1, 1), new DateTime(2021, 1, 1));
        var student = new Student(1){
            GivenName = "John",
            Surname = "Doe",
            StartDate = new DateTime(2020, 1, 1),
            endDate = new DateTime(2021, 1, 1),
            graduationDate = new DateTime(2021, 1, 1)
        };

        // Act
        var result = student.calculate();

        // Assert
        result.Should().Be(Status.Graduated);
    }
}