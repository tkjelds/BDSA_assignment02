namespace Student;
public class Student
{
    readonly int id;
    string GivenName;
    string SurName;
    public readonly status Status;
    DateTime StartDate;
    DateTime EndDate;
    DateTime GraduationDate;

    public Student(int id, string givenName, string surName,  DateTime startDate, DateTime endDate, DateTime graduationDate)
    {
        this.id = id;
        GivenName = givenName;
        SurName = surName;
        Status = CalcStatus(startDate, endDate, graduationDate);
        StartDate = startDate;
        EndDate = endDate;
        GraduationDate = graduationDate;
    }

    private status CalcStatus(DateTime startDate, DateTime endDate, DateTime graduationDate)
    {
        if(endDate < graduationDate) return status.Dropout;
        if(startDate.Year == DateTime.Now.Year) return status.New;
        if(DateTime.Now > graduationDate) return status.Graduated;
        if(startDate < DateTime.Now && DateTime.Now < endDate) return status.Active;
        return default;
    }

    public enum status {
        New, 
        Active, 
        Dropout, 
        Graduated
    }

    public override string ToString() => $"Name: {GivenName} {SurName}. Status: {Status} StartDate: {StartDate.ToString("d")} EndDate: {EndDate.ToString("d")} GraduationDate {GraduationDate.ToString("d")}";


}