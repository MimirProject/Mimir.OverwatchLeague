using Mimir.OverwatchLeague.Interfaces;
using Mimir.OverwatchLeague.Models;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimir.OverwatchLeague.Services
{
    public class OverwatchLeague : IOverwatchLeague
    {
        private readonly IOverwatchLeagueService _client;
        public OverwatchLeague()
        {
            _client = RestClient.For<IOverwatchLeagueService>("https://api.overwatchleague.com");
        }

        /// <summary>
        /// Returns a detailed list of all current Overwatch Maps
        /// </summary>
        /// <returns></returns>
        public async Task<List<MapsResponse>> GetMapsAsync()
        {
            return await _client.GetMapsAsync();
        }

        /// <summary>
        /// Returns a map's detailed info
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<MapsResponse> GetMapAsync(string id)
        {
            var maps = await _client.GetMapsAsync();
            return maps.Where(m => m.Id.Equals(id)).FirstOrDefault();
        }

        /// <summary>
        /// Returns a detailed list of all Overwatch League's Teams
        /// </summary>
        /// <returns></returns>
        public async Task<TeamsResponse> GetTeamsAsync()
        {
            return await _client.GetTeamsAsync();
        }

        /// <summary>
        /// Returns a team's detailed info
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TeamResponse> GetTeamAsync(int id)
        {
            return await _client.GetTeamAsync(id);
        }

        /// <summary>
        /// Returns the detailed current season rankings
        /// </summary>
        /// <returns></returns>
        public async Task<RankingResponse> GetRankingAsync()
        {
            return await _client.GetRankingAsync();
        }

        /// <summary>
        /// Returns a list of the latest news
        /// </summary>
        /// <returns></returns>
        public async Task<NewsResponse> GetNewsAsync()
        {
            return await _client.GetNewsAsync();
        }
    }
}
