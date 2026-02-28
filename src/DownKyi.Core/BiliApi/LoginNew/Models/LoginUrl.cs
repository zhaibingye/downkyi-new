using DownKyi.Core.BiliApi.Models;
using Newtonsoft.Json;

namespace DownKyi.Core.BiliApi.LoginNew.Models
{
    // https://passport.bilibili.com/qrcode/getLoginUrl
    [JsonObject]
    public class LoginUrlOrigin : BaseModel
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public LoginUrl Data { get; set; }
    }

    [JsonObject]
    public class LoginUrl : BaseModel
    {
        [JsonProperty("qrcode_key")]
        public string QrcodeKey { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("ttl")]
        public int Ttl { get; set; }
    }
}
