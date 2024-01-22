using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos = new List<SayaTubeVideo>();
        public string Username;

        public SayaTubeUser(string username)
        {
            // Precondition
            if (string.IsNullOrEmpty(username) || username.Length > 100)
            {
                throw new ArgumentException("Nama username tidak valid.");
            }

            Username = username;
            id = GenerateRandomId();
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            // Precondition
            if (video == null || video.GetPlayCount() > int.MaxValue)
            {
                throw new ArgumentException("Video yang ditambahkan tidak valid.");
            }

            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");

            // Postcondition
            int maxVideosToPrint = Math.Min(8, uploadedVideos.Count);
            for (int i = 0; i < maxVideosToPrint; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }

        private int GenerateRandomId()
        {
            Random random = new Random();
            return random.Next(10000, 99999);
        }
    }
}
