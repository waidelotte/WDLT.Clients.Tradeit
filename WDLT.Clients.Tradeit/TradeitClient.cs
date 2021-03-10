using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using WDLT.Clients.Base;
using WDLT.Clients.Tradeit.Models;

namespace WDLT.Clients.Tradeit
{
    public class TradeitClient : BaseClient
    {
        public TradeitClient(string userAgent) : base("https://tradeit.gg", userAgent)
        {
            _client.AddDefaultHeader("referer", "https://tradeit.gg/");
        }

        public Task<List<TradeitInvertory>> Invertory(int appId)
        {
            return RequestAsync<List<TradeitInvertory>>(new RestRequest($"https://inventory.tradeit.gg/sinv/{appId}"));
        }
    }
}
