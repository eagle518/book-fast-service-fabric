// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace BookFast.Web.Proxy.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class FacilityRepresentation
    {
        /// <summary>
        /// Initializes a new instance of the FacilityRepresentation class.
        /// </summary>
        public FacilityRepresentation() { }

        /// <summary>
        /// Initializes a new instance of the FacilityRepresentation class.
        /// </summary>
        public FacilityRepresentation(Guid? id = default(Guid?), string name = default(string), string description = default(string), string streetAddress = default(string), double? longitude = default(double?), double? latitude = default(double?), IList<string> images = default(IList<string>), int? accommodationCount = default(int?))
        {
            Id = id;
            Name = name;
            Description = description;
            StreetAddress = streetAddress;
            Longitude = longitude;
            Latitude = latitude;
            Images = images;
            AccommodationCount = accommodationCount;
        }

        /// <summary>
        /// Facility ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Facility name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Facility description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Facility street address
        /// </summary>
        [JsonProperty(PropertyName = "streetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Latitude
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Facility images
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IList<string> Images { get; set; }

        /// <summary>
        /// Number of accommodations
        /// </summary>
        [JsonProperty(PropertyName = "accommodationCount")]
        public int? AccommodationCount { get; set; }

    }
}