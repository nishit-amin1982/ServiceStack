// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// HelloResponse
    /// </summary>
    public partial class HelloResponse
    {
        /// <summary>
        /// Initializes a new instance of the HelloResponse class.
        /// </summary>
        public HelloResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HelloResponse class.
        /// </summary>
        public HelloResponse(string result = default(string))
        {
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Result")]
        public string Result { get; set; }

    }
}
