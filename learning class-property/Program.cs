
using lerning_Class_Property;

try
{
    Person p1 = new Person("fazel", -22);

    p1.Greet();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

