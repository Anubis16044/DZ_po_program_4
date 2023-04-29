namespace testDB;

internal class Program
{
    static void Main(string[] args) 
    {
        TestContext context = new TestContext();
        User data = new User(null, "Вася", "vasia@gmail.com");

        context.Users.Add(data);
        context.SaveChanges();
        Print(context);

        data.Name = "Test";
        context.Users.Update(data);
        context.SaveChanges();
        Print(context);

        context.Users.Remove(data);
        context.SaveChanges();
        Print(context);
        




    }
    static void Print(TestContext context)
    {
        Console.WriteLine(); 
        foreach (var user in context.Users)
        {
            Console.WriteLine(user);
        }
    }
}
