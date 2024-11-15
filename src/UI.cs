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
        //latar cerita : seorang pangeran dari suatu kerajaann yang sangat makmur dan damai, namun suatu hari 
        //kerajaan tersebut diserang oleh makhluk bernama "Honkai", kerajaan hancur lebur, dan merekea harus mengirimkan
        //pangeran tersebut ke luar angkasa, namun naas pesawat yang membawa 
        Console.Clear();
        Console.WriteLine("Apakah anda yakin ingin memulai permainan baru?");
        Console.WriteLine("Y/N");
        if(Console.ReadLine().ToLower() != "y")
        {
            return null;
        }
        Console.WriteLine("Petualangan anda akan segera dimulai");
        //digunakan sebagai pause sampai user mengetikkan apapun
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Nikmatilah petualangan ini!");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Kamu dibangunkan oleh sebuah cahaya terang...");
        Console.ReadKey();
        Console.WriteLine("Badanmu terasa dingin, dan nafasmu terasa sesak");
        Console.ReadKey();
        Console.WriteLine("\"Aduhhhh....\" rintihmu sambil mencoba mendirikan badanmu")
        Console.ReadKey();
        Console.WriteLine("Tetapi rasanya seperti ada gajah yang menimpamu");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("...");
        Console.ReadKey();
        Console.WriteLine("...");
        Console.ReadKey();
        Console.WriteLine("...");   
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Pikiranmu kosong, seperti menderita demensia");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Apa mungkin kamu memang terkena demensia?");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Hal itu tidak penting, karena kamu masih ingat ajaran mengenai suatu hal")''
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Hal yang paling penting untuk dilakukan saat kamu kehilangan pijakanmu");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Cari informasi mengenai sekitarmu");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("..."); 
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Kamu merogoh kantongmu");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Tertemu sebuah kartu berdebu");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("*Sapu sapu sapu*");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Terlihatlah namamu");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("..."); 
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Namaku adalah...");
        Console.ReadKey();
        Console.Clear();
        string tempName = Console.ReadLine("Masukkan nama karaktermu: ");
        Console.WriteLine("Apakah anda yakin ingin menggunakan nama" + tempName + "? (nama tidak dapat diubah)");
        Console.WriteLine("Y/N");
        if(Console.ReadLine().ToLower() == "y")
        {
            player.playerName = tempName;
        }
        //TERAPIN WHILE LOOP, GW NGANTUK CIK
    }
}