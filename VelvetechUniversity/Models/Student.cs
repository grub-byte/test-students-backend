using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VelvetechUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(40)]
        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(40)]
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [MaxLength(60)]
        [JsonProperty("middlename")]
        public string MiddleName { get; set; }

        [Required]
        [JsonProperty("gender")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Gender Gender { get; set; }

        [MinLength(6)]
        [MaxLength(16)]
        [JsonProperty("nickname")]
        public string Nickname { get; set; }
    }

    [Flags]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Gender
    { 
        male, female
    }
}
