using system;

public class UI
{
    //UI akan mengatur tampilan game
    //UI akan menampilkan informasi player, informasi battle, dan navigasi player dalam game
    public static UI instance = null;

    private UI()
    {
        //constructor
    }

    public static UI Instance()
    {
        if (instance == null)
        {
            return new UI();
        }
        else
        {
            return this.instance;
        }
    }

    public static int MainMenu()
    {
        //digunakan untuk menampilkan main menu dari game
        Console.WriteLine("                   _         _                                    __                 _ ");
        Console.WriteLine("  /\  /\___  _ __ | | ____ _(_)  _    /\/\   ___   ___  _ __     /__\ ___   __ _  __| |");
        Console.WriteLine(" / /_/ / _ \| '_ \| |/ / _` | | (_)  /    \ / _ \ / _ \| '_ \   / \\/\/\/ _ \ / _` |/ _` |");
        Console.WriteLine("/ __  / (_) | | | |   < (_| | |  _  / /\/\ \ (_) | (_) | | | | / _  \ (_) | (_| | (_| |");
        Console.WriteLine("\/ /_/ \___/|_| |_|_|\_\__,_|_| (_) \/    \/\___/ \___/|_| |_| \/ \_/\___/ \__,_|\__,_|");
        Console.WriteLine("\nMain Menu");
        Console.WriteLine(" 1. Lanjutkan Permainan");
        Console.WriteLine(" 2. Mulai Permainan Baru");
        Console.WriteLine(" 3. Memuat Permainan");
        Console.WriteLine(" 4. Credits");
        Console.WriteLine(" 5. Keluar");
        Console.Write("Pilihan: ");
        string choice = Console.ReadLine();
        int int_choice;
        Int32.TryParse(choice, out int_choice);
        return int_choice;
    }

    public static void ShowCredits()
    {
        //digunakan untuk menampilkan credits
        Console.WriteLine("Credits");
        Console.WriteLine("Game ini dibuat oleh:");
        Console.WriteLine("1. Anthonius Hendhy Wirawan (2306161795)");
        Console.WriteLine("2. Maxwell Zefanya Ginting (2306221200)");
        Console.WriteLine("3. Naufal Hadi Rasikhin (2306231366)");
        Console.WriteLine("Terima kasih telah memainkan game ini!");
    }

    public static void ExitGame()
    {
        //digunakan untuk menampilkan massage exit
        Console.WriteLine("Terima kasih telah memainkan game ini!");
        Console.WriteLine("Sampai jumpa lagi");
    }

    public static string ShowStartNewGame()
    {
        //digunakan untuk menampilkan menu pembuatan karakter baru
        //plot:
        //latar cerita : seorang pangeran dari suatu 
    }
}