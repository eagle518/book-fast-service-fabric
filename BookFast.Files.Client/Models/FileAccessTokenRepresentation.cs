// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace BookFast.Files.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class FileAccessTokenRepresentation
    {
        /// <summary>
        /// Initializes a new instance of the FileAccessTokenRepresentation
        /// class.
        /// </summary>
        public FileAccessTokenRepresentation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileAccessTokenRepresentation
        /// class.
        /// </summary>
        /// <param name="accessPermission">Possible values include: 'Read',
        /// 'Write', 'Delete'</param>
        public FileAccessTokenRepresentation(string accessPermission = default(string), string url = default(string))
        {
            AccessPermission = accessPermission;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Read', 'Write', 'Delete'
        /// </summary>
        [JsonProperty(PropertyName = "accessPermission")]
        public string AccessPermission { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}
