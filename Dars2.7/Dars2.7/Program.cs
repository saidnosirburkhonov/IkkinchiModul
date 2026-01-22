namespace Dars2._7;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        User user1 = new User();
        user1.UsersId = Guid.NewGuid();
        user1.Password = "password";
        user1.Password = "qwerty";
    }
}
