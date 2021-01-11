using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AnimeSaveOneDropOne.Shared
{
    public class AnimeCharacter
    {
        [Key]
        public int MalId { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; } = "https://via.placeholder.com/300x400";

        public int Points { get; set; }

        public int Rank { get; set; }

        public int PreviousRank { get; set; }

        public int AnimeMalId { get; set; }
    }
}
