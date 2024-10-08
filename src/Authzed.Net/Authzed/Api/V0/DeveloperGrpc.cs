// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: authzed/api/v0/developer.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Authzed.Api.V0 {
  public static partial class DeveloperService
  {
    static readonly string __ServiceName = "authzed.api.v0.DeveloperService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.EditCheckRequest> __Marshaller_authzed_api_v0_EditCheckRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.EditCheckRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.EditCheckResponse> __Marshaller_authzed_api_v0_EditCheckResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.EditCheckResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.ValidateRequest> __Marshaller_authzed_api_v0_ValidateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.ValidateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.ValidateResponse> __Marshaller_authzed_api_v0_ValidateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.ValidateResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.ShareRequest> __Marshaller_authzed_api_v0_ShareRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.ShareRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.ShareResponse> __Marshaller_authzed_api_v0_ShareResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.ShareResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.LookupShareRequest> __Marshaller_authzed_api_v0_LookupShareRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.LookupShareRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.LookupShareResponse> __Marshaller_authzed_api_v0_LookupShareResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.LookupShareResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.UpgradeSchemaRequest> __Marshaller_authzed_api_v0_UpgradeSchemaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.UpgradeSchemaRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.UpgradeSchemaResponse> __Marshaller_authzed_api_v0_UpgradeSchemaResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.UpgradeSchemaResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.FormatSchemaRequest> __Marshaller_authzed_api_v0_FormatSchemaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.FormatSchemaRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Authzed.Api.V0.FormatSchemaResponse> __Marshaller_authzed_api_v0_FormatSchemaResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Authzed.Api.V0.FormatSchemaResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Authzed.Api.V0.EditCheckRequest, global::Authzed.Api.V0.EditCheckResponse> __Method_EditCheck = new grpc::Method<global::Authzed.Api.V0.EditCheckRequest, global::Authzed.Api.V0.EditCheckResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "EditCheck",
        __Marshaller_authzed_api_v0_EditCheckRequest,
        __Marshaller_authzed_api_v0_EditCheckResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Authzed.Api.V0.ValidateRequest, global::Authzed.Api.V0.ValidateResponse> __Method_Validate = new grpc::Method<global::Authzed.Api.V0.ValidateRequest, global::Authzed.Api.V0.ValidateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Validate",
        __Marshaller_authzed_api_v0_ValidateRequest,
        __Marshaller_authzed_api_v0_ValidateResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Authzed.Api.V0.ShareRequest, global::Authzed.Api.V0.ShareResponse> __Method_Share = new grpc::Method<global::Authzed.Api.V0.ShareRequest, global::Authzed.Api.V0.ShareResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Share",
        __Marshaller_authzed_api_v0_ShareRequest,
        __Marshaller_authzed_api_v0_ShareResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Authzed.Api.V0.LookupShareRequest, global::Authzed.Api.V0.LookupShareResponse> __Method_LookupShared = new grpc::Method<global::Authzed.Api.V0.LookupShareRequest, global::Authzed.Api.V0.LookupShareResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LookupShared",
        __Marshaller_authzed_api_v0_LookupShareRequest,
        __Marshaller_authzed_api_v0_LookupShareResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Authzed.Api.V0.UpgradeSchemaRequest, global::Authzed.Api.V0.UpgradeSchemaResponse> __Method_UpgradeSchema = new grpc::Method<global::Authzed.Api.V0.UpgradeSchemaRequest, global::Authzed.Api.V0.UpgradeSchemaResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpgradeSchema",
        __Marshaller_authzed_api_v0_UpgradeSchemaRequest,
        __Marshaller_authzed_api_v0_UpgradeSchemaResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Authzed.Api.V0.FormatSchemaRequest, global::Authzed.Api.V0.FormatSchemaResponse> __Method_FormatSchema = new grpc::Method<global::Authzed.Api.V0.FormatSchemaRequest, global::Authzed.Api.V0.FormatSchemaResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FormatSchema",
        __Marshaller_authzed_api_v0_FormatSchemaRequest,
        __Marshaller_authzed_api_v0_FormatSchemaResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Authzed.Api.V0.DeveloperReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for DeveloperService</summary>
    public partial class DeveloperServiceClient : grpc::ClientBase<DeveloperServiceClient>
    {
      /// <summary>Creates a new client for DeveloperService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DeveloperServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DeveloperService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DeveloperServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DeveloperServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DeveloperServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.EditCheckResponse EditCheck(global::Authzed.Api.V0.EditCheckRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EditCheck(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.EditCheckResponse EditCheck(global::Authzed.Api.V0.EditCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_EditCheck, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.EditCheckResponse> EditCheckAsync(global::Authzed.Api.V0.EditCheckRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EditCheckAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.EditCheckResponse> EditCheckAsync(global::Authzed.Api.V0.EditCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_EditCheck, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.ValidateResponse Validate(global::Authzed.Api.V0.ValidateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Validate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.ValidateResponse Validate(global::Authzed.Api.V0.ValidateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Validate, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.ValidateResponse> ValidateAsync(global::Authzed.Api.V0.ValidateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ValidateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.ValidateResponse> ValidateAsync(global::Authzed.Api.V0.ValidateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Validate, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.ShareResponse Share(global::Authzed.Api.V0.ShareRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Share(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.ShareResponse Share(global::Authzed.Api.V0.ShareRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Share, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.ShareResponse> ShareAsync(global::Authzed.Api.V0.ShareRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ShareAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.ShareResponse> ShareAsync(global::Authzed.Api.V0.ShareRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Share, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.LookupShareResponse LookupShared(global::Authzed.Api.V0.LookupShareRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LookupShared(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.LookupShareResponse LookupShared(global::Authzed.Api.V0.LookupShareRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LookupShared, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.LookupShareResponse> LookupSharedAsync(global::Authzed.Api.V0.LookupShareRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LookupSharedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.LookupShareResponse> LookupSharedAsync(global::Authzed.Api.V0.LookupShareRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LookupShared, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.UpgradeSchemaResponse UpgradeSchema(global::Authzed.Api.V0.UpgradeSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpgradeSchema(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.UpgradeSchemaResponse UpgradeSchema(global::Authzed.Api.V0.UpgradeSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpgradeSchema, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.UpgradeSchemaResponse> UpgradeSchemaAsync(global::Authzed.Api.V0.UpgradeSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpgradeSchemaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.UpgradeSchemaResponse> UpgradeSchemaAsync(global::Authzed.Api.V0.UpgradeSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpgradeSchema, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.FormatSchemaResponse FormatSchema(global::Authzed.Api.V0.FormatSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FormatSchema(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Authzed.Api.V0.FormatSchemaResponse FormatSchema(global::Authzed.Api.V0.FormatSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FormatSchema, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.FormatSchemaResponse> FormatSchemaAsync(global::Authzed.Api.V0.FormatSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FormatSchemaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Authzed.Api.V0.FormatSchemaResponse> FormatSchemaAsync(global::Authzed.Api.V0.FormatSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FormatSchema, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override DeveloperServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DeveloperServiceClient(configuration);
      }
    }

  }
}
#endregion
