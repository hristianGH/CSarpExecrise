using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> playList = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] inputSong = Console.ReadLine().Split('_').ToArray();
                string type = inputSong[0];
                string songName = inputSong[1];
                Song song = new Song();
                song.Type = type;
                song.Name = songName;
             
                playList.Add(song);
            }
            string command = Console.ReadLine();
            List<Song> filtered =playList.Where(x=>x.Type==command).ToList();
            if (command=="all")
            {
                Console.WriteLine(string.Join(Environment.NewLine,playList));
            }
            foreach (Song song in filtered)
            {
                if (song.Type==command)
                {
                    Console.WriteLine(song.Name);
                }
            }
            
        }
    }
}
