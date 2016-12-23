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

    public partial class BookingData
    {
        /// <summary>
        /// Initializes a new instance of the BookingData class.
        /// </summary>
        public BookingData() { }

        /// <summary>
        /// Initializes a new instance of the BookingData class.
        /// </summary>
        public BookingData(DateTime fromDate, DateTime toDate, Guid? accommodationId = default(Guid?))
        {
            AccommodationId = accommodationId;
            FromDate = fromDate;
            ToDate = toDate;
        }

        /// <summary>
        /// Accommodation ID
        /// </summary>
        [JsonProperty(PropertyName = "accommodationId")]
        public Guid? AccommodationId { get; set; }

        /// <summary>
        /// Booking start date
        /// </summary>
        [JsonProperty(PropertyName = "fromDate")]
        public DateTime FromDate { get; set; }

        /// <summary>
        /// Booking end date
        /// </summary>
        [JsonProperty(PropertyName = "toDate")]
        public DateTime ToDate { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}