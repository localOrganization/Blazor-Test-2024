using System;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace DisplayColors.Data
{
    public class WebColorsService : IWebColorsService
    {
        public readonly IHttpClientFactory _httpClientFactory;

        public WebColorsService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
       

        public async Task<WebColors> GetWebColorsAsync()
        {
            var _httpClient = _httpClientFactory.CreateClient("Colors");
            var webColors = await _httpClient.GetFromJsonAsync<WebColors>("unknown");  // Gets data for 5 colors

            if (webColors == null)
            {
                throw new Exception();
            }

            return webColors;
        }
    }
}
