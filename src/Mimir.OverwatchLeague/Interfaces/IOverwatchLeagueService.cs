using Mimir.OverwatchLeague.Models;
using RestEase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mimir.OverwatchLeague.Interfaces
{
    public interface IOverwatchLeagueService
    {
        [Get("teams/{id}")]
        Task<TeamResponse> GetTeamAsync([Path("id")]int id);

        [Get("rankings")]
        Task<RankingResponse> GetRankingAsync();

        [Get("news?pageSize=5&page=1")]
        Task<NewsResponse> GetNewsAsync();

        [Get("teams")]
        Task<TeamsResponse> GetTeamsAsync();

        [Get("maps")]
        Task<List<MapsResponse>> GetMapsAsync();
    }
}
