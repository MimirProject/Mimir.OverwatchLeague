using Mimir.OverwatchLeague.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mimir.OverwatchLeague.Interfaces
{
    public interface IOverwatchLeague
    {
        /// <summary>
        /// Returns a detailed list of all current Overwatch Maps
        /// </summary>
        /// <returns></returns>
        Task<List<MapsResponse>> GetMapsAsync();

        /// <summary>
        /// Returns a map's detailed info
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<MapsResponse> GetMapAsync(string id);

        /// <summary>
        /// Returns a detailed list of all Overwatch League's Teams
        /// </summary>
        /// <returns></returns>
        Task<TeamsResponse> GetTeamsAsync();

        /// <summary>
        /// Returns a team's detailed info
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TeamResponse> GetTeamAsync(int id);

        /// <summary>
        /// Returns the detailed current season rankings
        /// </summary>
        /// <returns></returns>
        Task<RankingResponse> GetRankingAsync();

        /// <summary>
        /// Returns a list of the latest news
        /// </summary>
        /// <returns></returns>
        Task<NewsResponse> GetNewsAsync();
    }
}
