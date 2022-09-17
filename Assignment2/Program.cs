var student = new ImmutableStudent(1,"Tore","Kjelds",DateTime.ParseExact("08/10/2018","dd/MM/yyyy", null),
        DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null),DateTime.ParseExact("10/10/2023","dd/MM/yyyy", null));
        

Console.WriteLine(student);
foreach (var wizard in WizardCollection.Create())
{
    Console.WriteLine(wizard);
}
