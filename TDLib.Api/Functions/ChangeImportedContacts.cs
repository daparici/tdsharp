using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public partial class TdApi
    {
        /// <summary>
        /// Changes imported contacts using the list of current user contacts saved on the device. Imports newly added contacts and, if at least the file database is enabled, deletes recently deleted contacts.
        /// </summary>
        public class ChangeImportedContacts : Function<ImportedContacts>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "changeImportedContacts";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The new list of contacts, contact's vCard are ignored and are not imported
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("contacts")]
            public Contact[] Contacts { get; set; }
        }
    }
}