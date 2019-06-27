using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{

    public interface IMenuItem
    {
        [JsonProperty]
        string Description { get; set; }
        [JsonProperty]
        decimal BaseCost { get; set; }



    }
}
