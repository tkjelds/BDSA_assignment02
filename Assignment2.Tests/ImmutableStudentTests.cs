namespace Assignment2.Tests;

public class ImmutableStudentTests{
    [Fact]
    public void ImmutableStudentToStringTest()
    {
        // Given
        var student = new ImmutableStudent(1,"Tore","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", null),
        DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null));
        
        var result = student.ToString();
        // Then
        Assert.Equal(
            "ImmutableStudent { id = 1, GivenName = Tore, SurName = Kjelds, StartDate = 08/10/2018 00.00.00, EndDate = 10/10/2023 00.00.00, GraduationDate = 10/10/2023 00.00.00, Status = Active }",
            result
        );
    }
    [Fact]
    public void TesttingRecordEqualityReturnsTrue()
    {
        // Given
        var student1 = new ImmutableStudent(1,"Tore","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", null),
        DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null));
        
        var student2 = new ImmutableStudent(1,"Tore","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", null),
        DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null));
        
        // When
        var result = student1 == student2;
        // Then
        Assert.True(result);
    }
    [Fact]
    public void TestingRecordEqualityReturnFalse()
    {
        // Given
        var student1 = new ImmutableStudent(1,"Tore","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", null),
        DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null));
        
        var student2 = new ImmutableStudent(1,"Emil","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", null),
        DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null));
        
        // When
        var result = student1 == student2;
        // Then
        Assert.False(result);
    }
}