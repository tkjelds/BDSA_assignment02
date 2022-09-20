namespace Classlib;

public enum Status {New, Active, Dropout, Graduated};
public class Student{

    public int Id {get; private set;}
    public string GivenName {get; set;}
    public string Surname {get; set;}
    public Status Status {get;}
    public DateTime StartDate {get; set;}
    public DateTime endDate {get; set;}
    public DateTime graduationDate {get; set;}

    public Student(int id) {
        Id = id;
    }
    public Status calculate() {
        if (graduationDate < DateTime.Now && endDate == graduationDate) return Status.Graduated;
        if (endDate > DateTime.Now && StartDate < DateTime.Now) return Status.Active;
        if (endDate < DateTime.Now && endDate != graduationDate) return Status.Dropout;
        
        return Status.New;
    }

    public override string ToString(){
        return $"Id: {Id}, Name: {GivenName} {Surname}, Status: {Status}, Start Date: {StartDate.ToString("yyyy-MM-dd")}, End Date: {endDate.ToString("yyyy-MM-dd")}, Graduation Date: {graduationDate.ToString("yyyy-MM-dd")}";
    }
}
