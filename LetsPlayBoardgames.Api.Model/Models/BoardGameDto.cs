using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsPlayBoardgames.Api.Models
{
    public class BoardGameDto
    {
        public string Name { get; set; }
        public PlayersRangeDto PlayersRange { get; set; }
        public PlaytimeRangeDto PlaytimeRange { get; set; }
    }
}
