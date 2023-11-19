internal class Program
{
    private static Dictionary<string, string> passwords = new Dictionary<string, string>();
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("1. List All Passwords\n2. Add/Change Password\n3. Get Password\n4. Delete Password\n5. Quit\nPlease Select Option: ");
            var input = Console.ReadLine();
            if (input == "1")
                ListPasswords();
            else if (input == "2")
                ChangeOrAddPasswords();
            else if (input == "3")
                GetPassword();
            else if (input == "4")
                DeletePassword();
            else if (input == "5")
                break;
            else
                Console.WriteLine("Invalid Option! ❌");
            Console.WriteLine("----------------------------------------------------------");
        }
    }

    private static void DeletePassword()
    {
        Console.Write("Please Enter Website/App Name: ");
        var appName = Console.ReadLine();
        if (passwords.ContainsKey(appName))
        {
            passwords.Remove(appName);
            Console.WriteLine("Password Is Deleted Successfully. ✅");
        }
        else
            Console.WriteLine("Not Found passwords! ❌🤷\nPlease Add Password First.");
    }

    private static void GetPassword()
    {
        Console.Write("Please Enter Website/App Name: ");
        var appName = Console.ReadLine();
        if (passwords.ContainsKey(appName))
            Console.WriteLine(passwords[appName]);
        else
            Console.WriteLine("Not Found passwords! ❌🤷\nPlease Add Password First.");
    }

    private static void ChangeOrAddPasswords()
    {
        Console.Write("Please Enter Website/App Name: ");
        var name = Console.ReadLine();

        if (passwords.ContainsKey(name))
        {
            Console.Write("Please Enter New Password: ");
            passwords[name] = Console.ReadLine();
            Console.WriteLine("Password Is Changed Successfully. ✅");
        }
        else
        {
            Console.Write("Please Enter Password: ");
            var pass = Console.ReadLine();
            passwords.Add(name, pass);
            Console.WriteLine("Password Is Added Successfully. ✅");
        }
    }

    private static void ListPasswords()
    {
        if (passwords.Count > 0)
        {
            Console.WriteLine("Passwords: ");
            foreach (var item in passwords)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
        else
        {
            Console.WriteLine("Not Found passwords! ❌🤷\nPlease Add Password First.");
        }
    }
}