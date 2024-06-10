using System;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DisplayColors.Data
{
    public interface IWebColorsService
    {

        Task<WebColors> GetWebColorsAsync();
    }
}