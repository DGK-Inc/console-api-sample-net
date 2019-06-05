using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaConsoleDemoApp.Models
{
    public class Obituary
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "death_date")]
        public DateTime? DeathDate { get; set; }

        [JsonProperty(PropertyName = "birthdate")]
        public DateTime? BirthDate { get; set; }

        [JsonProperty(PropertyName = "hide_birthdate")]
        public bool HideBirthDate { get; set; }

        [JsonProperty(PropertyName = "firstname")]
        public string Firstname { get; set; }

        [JsonProperty(PropertyName = "lastname")]
        public string Lastname { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "family_email")]
        public string FamilyEmail { get; set; }

        [JsonProperty(PropertyName = "exposition_branch_id")]
        public int ExpositionBranchId { get; set; }

        [JsonProperty(PropertyName = "exposition_branch_name")]
        public string ExpositionBranchName { get; set; }

        [JsonProperty(PropertyName = "exposition_date")]
        public DateTime? ExpositionDate { get; set; }

        [JsonProperty(PropertyName = "picture")]
        public string Picture { get; set; }

        [JsonProperty(PropertyName = "obituary_text_fr")]
        public string ObituaryText_FR { get; set; }

        [JsonProperty(PropertyName = "obituary_text_en")]
        public string ObituaryText_EN { get; set; }

        [JsonProperty(PropertyName = "tribute_url")]
        public string TributeUrl { get; set; }


        [JsonProperty(PropertyName = "anniversary_years")]
        public int? AnniversaryYears { get; set; }

        [JsonProperty(PropertyName = "anniversary_text_fr")]
        public string AnniversaryText_FR { get; set; }

        [JsonProperty(PropertyName = "anniversary_text_en")]
        public string AnniversaryText_EN { get; set; }


        [JsonProperty(PropertyName = "thanks_fr")]
        public string Thanks_FR { get; set; }

        [JsonProperty(PropertyName = "thanks_en")]
        public string Thanks_EN { get; set; }


        [JsonProperty(PropertyName = "secret")]
        public string Secret { get; set; }

        [JsonProperty(PropertyName = "events")]
        public List<Event> Events { get; set; }
    }
}