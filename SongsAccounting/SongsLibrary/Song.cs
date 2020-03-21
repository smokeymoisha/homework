using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsLibrary
{
    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }

        public override string ToString()
        {
            return $"Song '{Name}' by {Artist}, album '{Album}' ({Year}), {Genre}";
        }

    }
}
