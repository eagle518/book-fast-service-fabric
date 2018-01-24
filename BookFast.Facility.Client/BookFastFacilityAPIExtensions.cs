// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace BookFast.Facility.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BookFastFacilityAPI.
    /// </summary>
    public static partial class BookFastFacilityAPIExtensions
    {
            /// <summary>
            /// List accommodations by facility
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='facilityId'>
            /// Facility ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<AccommodationRepresentation>> ListAccommodationsAsync(this IBookFastFacilityAPI operations, System.Guid facilityId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAccommodationsWithHttpMessagesAsync(facilityId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new accommodation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='facilityId'>
            /// Facility ID
            /// </param>
            /// <param name='accommodationData'>
            /// Accommodation details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccommodationRepresentation> CreateAccommodationAsync(this IBookFastFacilityAPI operations, System.Guid facilityId, AccommodationData accommodationData = default(AccommodationData), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateAccommodationWithHttpMessagesAsync(facilityId, accommodationData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Find accommodation by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Accommodation ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccommodationRepresentation> FindAccommodationAsync(this IBookFastFacilityAPI operations, System.Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FindAccommodationWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update accommodation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Accommodation ID
            /// </param>
            /// <param name='accommodationData'>
            /// Accommodation details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccommodationRepresentation> UpdateAccommodationAsync(this IBookFastFacilityAPI operations, System.Guid id, AccommodationData accommodationData = default(AccommodationData), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateAccommodationWithHttpMessagesAsync(id, accommodationData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete accommodation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Accommodation ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAccommodationAsync(this IBookFastFacilityAPI operations, System.Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteAccommodationWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List facilities by owner
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<FacilityRepresentation>> ListFacilitiesAsync(this IBookFastFacilityAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListFacilitiesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new facility
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='facilityData'>
            /// Facility details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FacilityRepresentation> CreateFacilityAsync(this IBookFastFacilityAPI operations, FacilityData facilityData = default(FacilityData), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateFacilityWithHttpMessagesAsync(facilityData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Find facility by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Facility ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FacilityRepresentation> FindFacilityAsync(this IBookFastFacilityAPI operations, System.Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FindFacilityWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update facility
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Facility ID
            /// </param>
            /// <param name='facilityData'>
            /// Facility details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FacilityRepresentation> UpdateFacilityAsync(this IBookFastFacilityAPI operations, System.Guid id, FacilityData facilityData = default(FacilityData), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateFacilityWithHttpMessagesAsync(id, facilityData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete facility
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Facility ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteFacilityAsync(this IBookFastFacilityAPI operations, System.Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteFacilityWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}