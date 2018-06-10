using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsPlayBoardgames.Api.Models
{
    public class PlaytimeRangeDto
    {
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
    }
}
