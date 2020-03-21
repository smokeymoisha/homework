using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongsLibrary;

namespace SongsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songList = new List<Song>();
            string input;

            do
            {
                Console.WriteLine("====================== MENU ======================");
                Console.WriteLine("Enter 'add' if you want to add a new song to the list.");
                Console.WriteLine("Enter 'view' if you want to view the current list of songs.");
                Console.WriteLine("Enter 'remove' if you want to remove a song from the list.");
                Console.WriteLine("Enter 'end' to finish working with the app.");

                Console.Write("Enter your answer: ");
                input = Console.ReadLine().ToLower();

                Console.WriteLine(string.Empty);

                if (input.Equals("add"))
                {
                    AddSongToList(songList);
                }
                else if (input.Equals("view"))
                {
                    ViewSongList(songList);
                }
                else if (input.Equals("remove"))
                {
                    RemoveSongFromList(songList);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine(string.Empty);
                }
            } while (input.Equals("end") == false);
        }

        static void AddSongToList(List<Song> songList)
        {
            Song song = new Song();

            Console.Write("Enter the name of the song: ");
            song.Name = Console.ReadLine();

            Console.Write("Enter the artist: ");
            song.Artist = Console.ReadLine();

            Console.Write("Enter the album: ");
            song.Album = Console.ReadLine();

            Console.Write("Enter the year of release: ");
            song.Year = Console.ReadLine();

            Console.Write("Enter the genre: ");
            song.Genre = Console.ReadLine();

            songList.Add(song);

            Console.WriteLine(string.Empty);
            Console.WriteLine($"Song '{song.Name}' by {song.Artist} was added to the list.");

            Console.WriteLine(string.Empty);
        }

        static void ViewSongList(List<Song> songList)
        {
            foreach (var song in songList)
            {
                int i = songList.IndexOf(song);
                Console.WriteLine($"{i + 1}. {song.ToString()}");
            }

            Console.WriteLine(string.Empty);
        }

        static void RemoveSongFromList(List<Song> songList)
        {
            Console.Write("Enter the number of the song you want to remove: ");
            string input = Console.ReadLine();
            int i = int.Parse(input);

            Console.WriteLine(string.Empty);
            Console.WriteLine($"Song '{songList[i - 1].Name}' by {songList[i - 1].Artist} was removed from the list.");

            songList.Remove(songList[i-1]);

            Console.WriteLine(string.Empty);
        }
    }
}
