﻿using Newtonsoft.Json;

namespace EmployeeManagementSystem.Common
{
    public class IdentityInfo_
    {
        [JsonProperty(PropertyName = "PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        [JsonProperty(PropertyName = "aadhar", NullValueHandling = NullValueHandling.Ignore)]
        public string Aadhar { get; set; }

        [JsonProperty(PropertyName = "nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        [JsonProperty(PropertyName = "passportNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PassportNumber { get; set; }

        [JsonProperty(PropertyName = "pfNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PFNumber { get; set; }




    }
}