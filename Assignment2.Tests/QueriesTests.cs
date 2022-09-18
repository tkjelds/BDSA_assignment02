namespace Assignment2.Test;

public class QueriesTest
{
[Fact]
    public void FindAllRowligsTestLinq()
    {
        // Given
        var Wizards = WizardCollection.Create();
        // When
        var result = Queries.FindAllRowligsLinq(Wizards);
        // Then
        Assert.Equal(new[] {"Albus Dumbeldore","Voldemort"},result);
    }
    [Fact]
    public void FindFirstDarthTestLinq()
    {
        // Given
        var Wizards = WizardCollection.Create();
        // When
        var result = Queries.FindFirstDarthLinq(Wizards);
        // Then
        Assert.True(result.Name.Split(' ').Contains("Darth"));
    }
    [Fact]
    public void FindAllPottersTestLinq()
    {
        // Given
        var Wizards = WizardCollection.Create();
        // When
        var result = Queries.FindAllPottersLinq(Wizards);
        // Then
        Assert.Equal(new List<(string,int?)> {("Albus Dumbeldore",2001),("Voldemort",2005)}, result);
    }
    [Fact]
    public void GroupByWizardsTestLinq()
    {
        // Given
        var Wizards = WizardCollection.Create();
        // When
        var result = Queries.GroupWizardsLinq(Wizards);
        Wizard[] expected = {
            new Wizard ( "The White Witch",  "Narnia", 2005, "Tilda Swinton"),
            new Wizard ("Stephen Strange","Marvel",1963,"Stan Lee"),
            new Wizard ("Gandalf","Lord of The Rings",2001,"Peter Jackson"),
            new Wizard ("Merlin","Excalibur",1981,"Nicol Williamson"),
            new Wizard ("Sauron","The Fellowship of the Ring", 1954,"J.R.R. Tolkien"),
            new Wizard ("Albus Dumbeldore","Harry Potter",2001,"J.K. Rowlings"),
            new Wizard ("Voldemort","Harry Potter",2005,"J.K. Rowlings"),
            new Wizard ("Nicolas Flamel", "Reality",1600, "His mom"),
            new Wizard ("Darth Vader" , "Star Wars",1977, "George Lucas"),
            new Wizard ("Zatanna","DC Comics",1964,"Gardner Fox"),
            new Wizard ("Glinda the Good Witch","The Wizards of Oz",1939,"Billie Burke"),
            new Wizard ("Willow Rosenberg","Buffy the Vampire Slayer",1997,"Alyson Hannigan")};
        // Then
        Assert.Equal(expected,result);
    }

[Fact]
    public void FindAllRowligsTestExt()
    {
        // Given
        var Wizards = WizardCollection.Create();
        // When
        var result = Queries.FindAllRowligsExt(Wizards);
        // Then
        Assert.Equal(new[] {"Albus Dumbeldore","Voldemort"},result);
    }
    [Fact]
    public void FindFirstDarthTestExt()
    {
        // Given
        var Wizards = WizardCollection.Create();
        // When
        var result = Queries.FindFirstDarthExt(Wizards);
        // Then
        Assert.True(result.Name.Split(' ').Contains("Darth"));
    }
    [Fact]
    public void FindAllPottersTestExt()
    {
        // Given
        var Wizards = WizardCollection.Create();
        // When
        var result = Queries.FindAllPottersExt(Wizards);
        // Then
        Assert.Equal(new List<(string,int?)> {("Albus Dumbeldore",2001),("Voldemort",2005)}, result);
    }
    [Fact]
    public void GroupByWizardsTestExt()
    {
        // Given
        var Wizards = WizardCollection.Create();
        // When
        var result = Queries.GroupWizardsExt(Wizards);
        Wizard[] expected = {
            new Wizard ( "The White Witch",  "Narnia", 2005, "Tilda Swinton"),
            new Wizard ("Stephen Strange","Marvel",1963,"Stan Lee"),
            new Wizard ("Gandalf","Lord of The Rings",2001,"Peter Jackson"),
            new Wizard ("Merlin","Excalibur",1981,"Nicol Williamson"),
            new Wizard ("Sauron","The Fellowship of the Ring", 1954,"J.R.R. Tolkien"),
            new Wizard ("Albus Dumbeldore","Harry Potter",2001,"J.K. Rowlings"),
            new Wizard ("Voldemort","Harry Potter",2005,"J.K. Rowlings"),
            new Wizard ("Nicolas Flamel", "Reality",1600, "His mom"),
            new Wizard ("Darth Vader" , "Star Wars",1977, "George Lucas"),
            new Wizard ("Zatanna","DC Comics",1964,"Gardner Fox"),
            new Wizard ("Glinda the Good Witch","The Wizards of Oz",1939,"Billie Burke"),
            new Wizard ("Willow Rosenberg","Buffy the Vampire Slayer",1997,"Alyson Hannigan")};
        // Then
        Assert.Equal(expected,result);
    }
    
}
