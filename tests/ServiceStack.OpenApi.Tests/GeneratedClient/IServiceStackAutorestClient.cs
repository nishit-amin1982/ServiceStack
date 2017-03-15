// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public partial interface IServiceStackAutorestClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Gets the IGetRequest1.
        /// </summary>
        IGetRequest1 GetRequest1 { get; }

        /// <summary>
        /// Gets the IGetRequest2.
        /// </summary>
        IGetRequest2 GetRequest2 { get; }

        /// <summary>
        /// Gets the IHelloOperations.
        /// </summary>
        IHelloOperations Hello { get; }

        /// <summary>
        /// Gets the IHelloListOperations.
        /// </summary>
        IHelloListOperations HelloList { get; }

        /// <summary>
        /// Gets the IHelloArrayOperations.
        /// </summary>
        IHelloArrayOperations HelloArray { get; }

        /// <summary>
        /// Gets the IAllowedAttributesOperations.
        /// </summary>
        IAllowedAttributesOperations AllowedAttributes { get; }

        /// <summary>
        /// Gets the IHelloAllTypesOperations.
        /// </summary>
        IHelloAllTypesOperations HelloAllTypes { get; }

        /// <summary>
        /// Gets the IHelloAllTypesWithResultOperations.
        /// </summary>
        IHelloAllTypesWithResultOperations HelloAllTypesWithResult { get; }

        /// <summary>
        /// Gets the IHelloStringOperations.
        /// </summary>
        IHelloStringOperations HelloString { get; }

        /// <summary>
        /// Gets the IHelloDateTimeOperations.
        /// </summary>
        IHelloDateTimeOperations HelloDateTime { get; }

        /// <summary>
        /// Gets the IHelloVoidOperations.
        /// </summary>
        IHelloVoidOperations HelloVoid { get; }

        /// <summary>
        /// Gets the IHelloWithRouteOperations.
        /// </summary>
        IHelloWithRouteOperations HelloWithRoute { get; }

        /// <summary>
        /// Gets the IHelloTypesOperations.
        /// </summary>
        IHelloTypesOperations HelloTypes { get; }

        /// <summary>
        /// Gets the IHelloZipOperations.
        /// </summary>
        IHelloZipOperations HelloZip { get; }

        /// <summary>
        /// Gets the IGetSession.
        /// </summary>
        IGetSession GetSession { get; }

        /// <summary>
        /// Gets the IUpdateSessionOperations.
        /// </summary>
        IUpdateSessionOperations UpdateSession { get; }

        /// <summary>
        /// Gets the IAuthenticateOperations.
        /// </summary>
        IAuthenticateOperations Authenticate { get; }

        /// <summary>
        /// Gets the IAssignRolesOperations.
        /// </summary>
        IAssignRolesOperations AssignRoles { get; }

        /// <summary>
        /// Gets the IUnAssignRolesOperations.
        /// </summary>
        IUnAssignRolesOperations UnAssignRoles { get; }

    }
}
