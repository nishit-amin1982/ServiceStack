// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ArrayResult[]
    /// </summary>
    public partial class ArrayResultSequence
    {
        /// <summary>
        /// Initializes a new instance of the ArrayResultSequence class.
        /// </summary>
        public ArrayResultSequence()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArrayResultSequence class.
        /// </summary>
        public ArrayResultSequence(int length = default(int), long longLength = default(long), int rank = default(int), object syncRoot = default(object), bool isReadOnly = default(bool), bool isFixedSize = default(bool), bool isSynchronized = default(bool))
        {
            Length = length;
            LongLength = longLength;
            Rank = rank;
            SyncRoot = syncRoot;
            IsReadOnly = isReadOnly;
            IsFixedSize = isFixedSize;
            IsSynchronized = isSynchronized;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Length")]
        public int Length { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LongLength")]
        public long LongLength { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Rank")]
        public int Rank { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SyncRoot")]
        public object SyncRoot { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsReadOnly")]
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsFixedSize")]
        public bool IsFixedSize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSynchronized")]
        public bool IsSynchronized { get; set; }

    }
}
