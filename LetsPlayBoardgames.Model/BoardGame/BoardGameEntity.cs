using System;
using System.Collections.Generic;
using System.Text;

namespace LetsPlayBoardgames.Model.BoardGame
{
    public class BoardGameEntity : EntityBase
    {
        public string Name { get; set; }
        public PlayersRange PlayersRange { get; internal set; }
        public PlaytimeRange PlaytimeRange { get; internal set; }

        internal BoardGameEntity()
        {
        }
    }
}
