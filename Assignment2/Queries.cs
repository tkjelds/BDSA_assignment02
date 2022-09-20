namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> FindAllRowligsLinq(IEnumerable<Wizard> Wizards) =>
        from wizard in Wizards
        where wizard.Creator == "J.K. Rowlings"
        select wizard.Name;

    public static Wizard FindFirstDarthLinq(IEnumerable<Wizard> wizards) =>
        (from Wizard in wizards
         where Wizard.Name.Split(' ').Contains("Darth")
         orderby Wizard.Year
         select Wizard).First();

    public static IEnumerable<(string, int?)> FindAllPottersLinq(IEnumerable<Wizard> wizards) =>
        from Wizard in wizards.Distinct()
        where Wizard.Medium == "Harry Potter"
        select (Wizard.Name, Wizard.Year);

    public static IEnumerable<Wizard> GroupWizardsLinq(IEnumerable<Wizard> wizards) =>
        from Wizard in wizards
        orderby Wizard.Creator descending, Wizard.Name
        select Wizard;

    public static IEnumerable<string> FindAllRowligsExt(IEnumerable<Wizard> Wizards) => 
        Wizards.Where(w => w.Creator == "J.K. Rowlings").Select(w => w.Name);

    public static Wizard FindFirstDarthExt(IEnumerable<Wizard> wizards) =>
        wizards.Where(w => w.Name.Split(' ').Contains("Darth")).First();

    public static IEnumerable<(string, int?)> FindAllPottersExt(IEnumerable<Wizard> wizards) =>
        wizards.Distinct().Where(w => w.Medium == "Harry Potter").Select(w => (w.Name,w.Year));
    
    public static IEnumerable<Wizard> GroupWizardsExt(IEnumerable<Wizard> wizards) =>
        wizards.OrderByDescending(w => w.Creator).ThenBy(w => w.Name);

}
