using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount = 0;

        public SayaTubeVideo(string title)
        {
            // Precondition
            if (string.IsNullOrEmpty(title) || title.Length > 200)
            {
                throw new ArgumentException("Judul video tidak valid.");
            }

            this.title = title;
            id = GenerateRandomId();
        }

        public void IncreasePlayCount(int count)
        {
            // Precondition
            if (count < 0 || count > 25000000)
            {
                throw new ArgumentOutOfRangeException("Input play count tidak valid.");
            }

            // Exception Handling untuk integer overflow
            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Integer overflow terdeteksi.");
                // Log atau tindakan lainnya dapat ditambahkan di sini
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"PlayCount: {playCount}");
        }

        public int GetPlayCount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }

        private int GenerateRandomId()
        {
            Random random = new Random();
            return random.Next(10000, 99999);
        }
    }
}
