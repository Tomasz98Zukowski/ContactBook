namespace ContactBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactBook contactBook = new ContactBook();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Hello from the PhoneBook app");

                Console.WriteLine("1 Add contact");
                Console.WriteLine("2 Display contact by number");
                Console.WriteLine("3 Display all contacts");
                Console.WriteLine("4 Search contact");
                Console.WriteLine("5 To exit");

                
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":            
                        Console.WriteLine("Type name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Type number:");
                        var number = Console.ReadLine();
                        contactBook.AddContact(new Contact(name, number));                                                  
                        break;
                    case "2":
                        Console.WriteLine("Type number:");
                        var numberToSearch = Console.ReadLine();
                        contactBook.DisplayContactByNumber(numberToSearch);
                        break;
                    case "3":
                        contactBook.DisplayAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Insert searching phrase");
                        var searchingName = Console.ReadLine();
                        contactBook.DisplayMatchingContacts(searchingName);
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid value");
                        break;
                }
            }
            
        }
    }
}
