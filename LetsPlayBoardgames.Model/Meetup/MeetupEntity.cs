using System;
using System.Collections.Generic;
using LetsPlayBoardgames.Model.BoardGame;
using LetsPlayBoardgames.Model.Player;

namespace LetsPlayBoardgames.Model.Meetup
{
    public class MeetupEntity : EntityBase
    {
        public string Name { get; private set; }
        public PlayerEntity Organizer { get; private set; }

        public IEnumerable<BoardGameEntity> BoardGames { get; private set; }

        public uint RequiredNumberOfPlayers { get; private set; }

        public IEnumerable<PlayerEntity> PlayersAttending { get; private set; }
        public IEnumerable<PlayerEntity> InvitedPlayers { get; private set; }

        internal MeetupEntity()
        {
        }
    }
}
