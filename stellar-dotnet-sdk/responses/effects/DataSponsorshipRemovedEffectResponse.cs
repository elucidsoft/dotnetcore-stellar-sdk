﻿using Newtonsoft.Json;

namespace stellar_dotnet_sdk.responses.effects
{
    /// <summary>
    ///     Represents data_sponsorship_created effect response.
    ///     See: https://www.stellar.org/developers/horizon/reference/resources/effect.html
    ///     <seealso cref="requests.EffectsRequestBuilder" />
    ///     <seealso cref="Server" />
    /// </summary>
    public class DataSponsorshipRemovedEffectResponse : EffectResponse
    {
        public override int TypeId => 68;

        [JsonProperty(PropertyName = "former_sponsor")]
        public string FormerSponsor { get; private set; }

        [JsonProperty(PropertyName = "data_name")]
        public string DataName { get; private set; }

        public DataSponsorshipRemovedEffectResponse()
        {

        }

        public DataSponsorshipRemovedEffectResponse(string formerSponsor, string dataName)
        {
            FormerSponsor = formerSponsor;
            DataName = dataName;
        }
    }
}
