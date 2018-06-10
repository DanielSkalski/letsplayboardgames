using AutoMapper;
using LetsPlayBoardgames.Api.Models;
using LetsPlayBoardgames.Model.BoardGame;
using LetsPlayBoardgames.Model.Meetup;
using LetsPlayBoardgames.Model.Player;

namespace LetsPlayBoardgames.Api.Mappings
{
    public static class MappingsConfig
    {
        public static void ConfigureMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<PlayersRange, PlayersRangeDto>();
            cfg.CreateMap<PlaytimeRange, PlaytimeRangeDto>();
            cfg.CreateMap<BoardGameEntity, BoardGameDto>();
            cfg.CreateMap<MeetupEntity, MeetupDto>();
            cfg.CreateMap<PlayerEntity, PlayerDto>();
        }
    }
}
