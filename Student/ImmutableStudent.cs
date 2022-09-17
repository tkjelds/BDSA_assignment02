public record ImmutableStudent {
    public int id {get;init;}
    public string GivenName {get;init;}
    public string SurName {get;init;}
    public DateTime StartDate {get;init;}
    public DateTime EndDate {get;init;}
    public DateTime GraduationDate {get;init;}
    public status Status {get;init;}
    public ImmutableStudent(int id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime graduationDate)
    {
        this.id = id;
        GivenName = givenName;
        SurName = surName;
        StartDate = startDate;
        EndDate = endDate;
        GraduationDate = graduationDate;
        Status = CalcStatus(startDate,
                            endDate,
                            graduationDate);
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
    }


