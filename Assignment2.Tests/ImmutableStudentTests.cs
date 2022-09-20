using System.Globalization;

namespace Assignment2.Tests;

public class ImmutableStudentTests{
    [Fact]
    public void ImmutableStudentToStringTest()
    {
        // Given
        var startDate = DateTime.ParseExact("08/10/2018","dd/MM/yyyy", CultureInfo.CurrentCulture);
        var endDate = DateTime.ParseExact("10/10/2023","dd/MM/yyyy", CultureInfo.CurrentCulture);
        var graduationDate = DateTime.ParseExact("10/10/2023","dd/MM/yyyy", CultureInfo.CurrentCulture);
        var student = new ImmutableStudent(1,"Tore","Kjelds", startDate, endDate, graduationDate);
        
        var result = student.ToString();
        // Then
        Assert.Equal(
            result,
            $"ImmutableStudent {{ id = 1, GivenName = Tore, SurName = Kjelds, StartDate = {startDate}, EndDate = {endDate}, GraduationDate = {graduationDate}, Status = Active }}"
        );
    }
    [Fact]
    public void TesttingRecordEqualityReturnsTrue()
    {
        // Given
        var student1 = new ImmutableStudent(1,"Tore","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", CultureInfo.CurrentCulture),
        DateTime.ParseExact("10/10/2023","dd/MM/yyyy", CultureInfo.CurrentCulture),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", CultureInfo.CurrentCulture));
        
        var student2 = new ImmutableStudent(1,"Tore","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", CultureInfo.CurrentCulture),
        DateTime.ParseExact("10/10/2023","dd/MM/yyyy", CultureInfo.CurrentCulture),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", CultureInfo.CurrentCulture));
        
        // When
        var result = student1 == student2;
        // Then
        Assert.True(result);
    }
    [Fact]
    public void TestingRecordEqualityReturnFalse()
    {
        // Given
        var student1 = new ImmutableStudent(1,"Tore","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", CultureInfo.CurrentCulture),
        DateTime.ParseExact("10/10/2023","dd/MM/yyyy", CultureInfo.CurrentCulture),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", CultureInfo.CurrentCulture));
        
        var student2 = new ImmutableStudent(1,"Emil","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", CultureInfo.CurrentCulture),
        DateTime.ParseExact("10/10/2023","dd/MM/yyyy", CultureInfo.CurrentCulture),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", CultureInfo.CurrentCulture));
        
        // When
        var result = student1 == student2;
        // Then
        Assert.False(result);
    }
}
