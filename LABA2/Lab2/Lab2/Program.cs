using BL2; 

class Program
{
    static void Main()
    {
        Console.WriteLine("Оберіть в якому стилі створити кнопку \n 1. Windows\n 2. IOS\n 3. Android");
        string choice = Console.ReadLine();

        IButtonFactory buttonFactory = GetButtonFactory(choice);
        IButton button = buttonFactory.CreateButton();

        button.Render();

        Console.ReadLine();
    }

    static IButtonFactory GetButtonFactory(string choice)
    {
        switch (choice)
        {
            case "1":
                return new WindowsButtonFactory();
            case "2":
                return new iOSButtonFactory();
            case "3":
                return new AndroidButtonFactory();
            default:
                throw new ArgumentException("Нема такої опції");
        }
    }
}
