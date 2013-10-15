﻿using Newtonsoft.Json;

namespace SharpRaven.Data
{
    public class SentryUser
    {
        [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }
    }
}