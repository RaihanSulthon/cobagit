using ConsoleApp1;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("NamaPraktikan");

        // Tambahkan minimal 10 judul film
        for (int i = 1; i <= 10; i++)
        {
            string judulFilm = $"Review Film {i} oleh {user.Username}";
            SayaTubeVideo video = new SayaTubeVideo(judulFilm);
            video.IncreasePlayCount(i * 1000); // Contoh playCount
            user.AddVideo(video);
        }

        // Panggil method untuk menampilkan hasil
        user.PrintAllVideoPlaycount();
        Console.WriteLine($"Total Video PlayCount: {user.GetTotalVideoPlayCount()}");
    }
}