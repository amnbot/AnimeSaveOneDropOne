using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSaveOneDropOne.Shared
{
    public class AnimeMe
    {
        public int MalId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public List<AnimeCharacter> AnimeCharacters { get; set; }
    }
}
