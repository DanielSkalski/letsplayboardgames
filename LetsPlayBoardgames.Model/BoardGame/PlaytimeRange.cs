using System;

namespace LetsPlayBoardgames.Model.BoardGame
{
    public class PlaytimeRange
    {
        public TimeSpan From { get; private set; }
        public TimeSpan To { get; private set; }

        public PlaytimeRange(TimeSpan from, TimeSpan to)
        {
            From = from;
            To = to;
        }
    }
}
