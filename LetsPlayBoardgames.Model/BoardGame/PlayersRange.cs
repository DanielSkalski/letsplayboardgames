
namespace LetsPlayBoardgames.Model.BoardGame
{
    public class PlayersRange
    {
        public uint From { get; private set; }
        public uint To { get; private set; }

        public PlayersRange(uint from, uint to)
        {
            From = from;
            To = to;
        }
    }
}
