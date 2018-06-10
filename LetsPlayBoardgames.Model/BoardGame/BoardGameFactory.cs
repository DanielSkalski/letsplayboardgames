using System;

namespace LetsPlayBoardgames.Model.BoardGame
{
    public class BoardGameFactory
    {
        public BoardGameEntity Create(string name, PlayersRange playersRange = null, PlaytimeRange playtimeRange = null)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name));
            }
            if (!IsPlayersRangeValid(playersRange))
            {
                throw new ArgumentException(nameof(playersRange));
            }
            if (!IsPlaytimeRangeValid(playtimeRange))
            {
                throw new ArgumentException(nameof(playtimeRange));
            }

            var boardGame = new BoardGameEntity
            {
                Id = Guid.NewGuid(),
                Name = name,
                PlayersRange = playersRange,
                PlaytimeRange = playtimeRange
            };

            return boardGame;
        }

        private bool IsPlayersRangeValid(PlayersRange playersRange)
        {
            return playersRange == null || 
                  (playersRange.From > 0 && 
                   playersRange.To >= playersRange.From);
        }

        private bool IsPlaytimeRangeValid(PlaytimeRange playtimeRange)
        {
            return playtimeRange == null ||
                  (playtimeRange.From > TimeSpan.FromMinutes(0) &&
                   playtimeRange.To >= playtimeRange.From);
        }
    }
}
