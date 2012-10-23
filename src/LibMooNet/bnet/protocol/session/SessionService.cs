// Generated by ProtoGen, Version=2.4.1.473, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bnet.protocol.session {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public static partial class SessionService {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_session_SessionNotification__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.session.SessionNotification, global::bnet.protocol.session.SessionNotification.Builder> internal__static_bnet_protocol_session_SessionNotification__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static SessionService() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "ChpibmV0L3Nlc3Npb25fc2VydmljZS5wcm90bxIVYm5ldC5wcm90b2NvbC5z" + 
          "ZXNzaW9uGhRibmV0L2F0dHJpYnV0ZS5wcm90bxoOYm5ldC9ycGMucHJvdG8a" + 
          "EWJuZXQvZW50aXR5LnByb3RvItUBChNTZXNzaW9uTm90aWZpY2F0aW9uEhQK" + 
          "DHNlc3Npb25fdHlwZRgBIAIoDRIcChRleHBpcmF0aW9uX3RpbWVzdGFtcBgC" + 
          "IAEoBhIZChFtaW51dGVzX3JlbWFpbmluZxgDIAEoDRIbChNjYWlzX3BsYXll" + 
          "ZF9taW51dGVzGAQgASgNEhsKE2NhaXNfcmVzdGVkX21pbnV0ZXMYBSABKA0S" + 
          "EgoKYmVuZWZhY3RvchgGIAEoCBIhChliaWxsaW5nX21pbnV0ZXNfcmVtYWlu" + 
          "aW5nGAcgASgNMmcKDVNlc3Npb25Ob3RpZnkSVgoGVXBkYXRlEiouYm5ldC5w" + 
          "cm90b2NvbC5zZXNzaW9uLlNlc3Npb25Ob3RpZmljYXRpb24aGi5ibmV0LnBy" + 
          "b3RvY29sLk5PX1JFU1BPTlNFIgSAtRgBQgOAAQA=");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_bnet_protocol_session_SessionNotification__Descriptor = Descriptor.MessageTypes[0];
        internal__static_bnet_protocol_session_SessionNotification__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.session.SessionNotification, global::bnet.protocol.session.SessionNotification.Builder>(internal__static_bnet_protocol_session_SessionNotification__Descriptor,
                new string[] { "SessionType", "ExpirationTimestamp", "MinutesRemaining", "CaisPlayedMinutes", "CaisRestedMinutes", "Benefactor", "BillingMinutesRemaining", });
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        global::bnet.protocol.attribute.Proto.Attribute.RegisterAllExtensions(registry);
        global::bnet.protocol.Rpc.RegisterAllExtensions(registry);
        global::bnet.protocol.Entity.RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::bnet.protocol.attribute.Proto.Attribute.Descriptor, 
          global::bnet.protocol.Rpc.Descriptor, 
          global::bnet.protocol.Entity.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class SessionNotification : pb::GeneratedMessage<SessionNotification, SessionNotification.Builder> {
    private SessionNotification() { }
    private static readonly SessionNotification defaultInstance = new SessionNotification().MakeReadOnly();
    private static readonly string[] _sessionNotificationFieldNames = new string[] { "benefactor", "billing_minutes_remaining", "cais_played_minutes", "cais_rested_minutes", "expiration_timestamp", "minutes_remaining", "session_type" };
    private static readonly uint[] _sessionNotificationFieldTags = new uint[] { 48, 56, 32, 40, 17, 24, 8 };
    public static SessionNotification DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override SessionNotification DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override SessionNotification ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.session.SessionService.internal__static_bnet_protocol_session_SessionNotification__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<SessionNotification, SessionNotification.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.session.SessionService.internal__static_bnet_protocol_session_SessionNotification__FieldAccessorTable; }
    }
    
    public const int SessionTypeFieldNumber = 1;
    private bool hasSessionType;
    private uint sessionType_;
    public bool HasSessionType {
      get { return hasSessionType; }
    }
    public uint SessionType {
      get { return sessionType_; }
    }
    
    public const int ExpirationTimestampFieldNumber = 2;
    private bool hasExpirationTimestamp;
    private ulong expirationTimestamp_;
    public bool HasExpirationTimestamp {
      get { return hasExpirationTimestamp; }
    }
    public ulong ExpirationTimestamp {
      get { return expirationTimestamp_; }
    }
    
    public const int MinutesRemainingFieldNumber = 3;
    private bool hasMinutesRemaining;
    private uint minutesRemaining_;
    public bool HasMinutesRemaining {
      get { return hasMinutesRemaining; }
    }
    public uint MinutesRemaining {
      get { return minutesRemaining_; }
    }
    
    public const int CaisPlayedMinutesFieldNumber = 4;
    private bool hasCaisPlayedMinutes;
    private uint caisPlayedMinutes_;
    public bool HasCaisPlayedMinutes {
      get { return hasCaisPlayedMinutes; }
    }
    public uint CaisPlayedMinutes {
      get { return caisPlayedMinutes_; }
    }
    
    public const int CaisRestedMinutesFieldNumber = 5;
    private bool hasCaisRestedMinutes;
    private uint caisRestedMinutes_;
    public bool HasCaisRestedMinutes {
      get { return hasCaisRestedMinutes; }
    }
    public uint CaisRestedMinutes {
      get { return caisRestedMinutes_; }
    }
    
    public const int BenefactorFieldNumber = 6;
    private bool hasBenefactor;
    private bool benefactor_;
    public bool HasBenefactor {
      get { return hasBenefactor; }
    }
    public bool Benefactor {
      get { return benefactor_; }
    }
    
    public const int BillingMinutesRemainingFieldNumber = 7;
    private bool hasBillingMinutesRemaining;
    private uint billingMinutesRemaining_;
    public bool HasBillingMinutesRemaining {
      get { return hasBillingMinutesRemaining; }
    }
    public uint BillingMinutesRemaining {
      get { return billingMinutesRemaining_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasSessionType) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _sessionNotificationFieldNames;
      if (hasSessionType) {
        output.WriteUInt32(1, field_names[6], SessionType);
      }
      if (hasExpirationTimestamp) {
        output.WriteFixed64(2, field_names[4], ExpirationTimestamp);
      }
      if (hasMinutesRemaining) {
        output.WriteUInt32(3, field_names[5], MinutesRemaining);
      }
      if (hasCaisPlayedMinutes) {
        output.WriteUInt32(4, field_names[2], CaisPlayedMinutes);
      }
      if (hasCaisRestedMinutes) {
        output.WriteUInt32(5, field_names[3], CaisRestedMinutes);
      }
      if (hasBenefactor) {
        output.WriteBool(6, field_names[0], Benefactor);
      }
      if (hasBillingMinutesRemaining) {
        output.WriteUInt32(7, field_names[1], BillingMinutesRemaining);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasSessionType) {
          size += pb::CodedOutputStream.ComputeUInt32Size(1, SessionType);
        }
        if (hasExpirationTimestamp) {
          size += pb::CodedOutputStream.ComputeFixed64Size(2, ExpirationTimestamp);
        }
        if (hasMinutesRemaining) {
          size += pb::CodedOutputStream.ComputeUInt32Size(3, MinutesRemaining);
        }
        if (hasCaisPlayedMinutes) {
          size += pb::CodedOutputStream.ComputeUInt32Size(4, CaisPlayedMinutes);
        }
        if (hasCaisRestedMinutes) {
          size += pb::CodedOutputStream.ComputeUInt32Size(5, CaisRestedMinutes);
        }
        if (hasBenefactor) {
          size += pb::CodedOutputStream.ComputeBoolSize(6, Benefactor);
        }
        if (hasBillingMinutesRemaining) {
          size += pb::CodedOutputStream.ComputeUInt32Size(7, BillingMinutesRemaining);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static SessionNotification ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static SessionNotification ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static SessionNotification ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static SessionNotification ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static SessionNotification ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static SessionNotification ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static SessionNotification ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static SessionNotification ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static SessionNotification ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static SessionNotification ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private SessionNotification MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(SessionNotification prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<SessionNotification, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(SessionNotification cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private SessionNotification result;
      
      private SessionNotification PrepareBuilder() {
        if (resultIsReadOnly) {
          SessionNotification original = result;
          result = new SessionNotification();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override SessionNotification MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bnet.protocol.session.SessionNotification.Descriptor; }
      }
      
      public override SessionNotification DefaultInstanceForType {
        get { return global::bnet.protocol.session.SessionNotification.DefaultInstance; }
      }
      
      public override SessionNotification BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is SessionNotification) {
          return MergeFrom((SessionNotification) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(SessionNotification other) {
        if (other == global::bnet.protocol.session.SessionNotification.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasSessionType) {
          SessionType = other.SessionType;
        }
        if (other.HasExpirationTimestamp) {
          ExpirationTimestamp = other.ExpirationTimestamp;
        }
        if (other.HasMinutesRemaining) {
          MinutesRemaining = other.MinutesRemaining;
        }
        if (other.HasCaisPlayedMinutes) {
          CaisPlayedMinutes = other.CaisPlayedMinutes;
        }
        if (other.HasCaisRestedMinutes) {
          CaisRestedMinutes = other.CaisRestedMinutes;
        }
        if (other.HasBenefactor) {
          Benefactor = other.Benefactor;
        }
        if (other.HasBillingMinutesRemaining) {
          BillingMinutesRemaining = other.BillingMinutesRemaining;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_sessionNotificationFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _sessionNotificationFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasSessionType = input.ReadUInt32(ref result.sessionType_);
              break;
            }
            case 17: {
              result.hasExpirationTimestamp = input.ReadFixed64(ref result.expirationTimestamp_);
              break;
            }
            case 24: {
              result.hasMinutesRemaining = input.ReadUInt32(ref result.minutesRemaining_);
              break;
            }
            case 32: {
              result.hasCaisPlayedMinutes = input.ReadUInt32(ref result.caisPlayedMinutes_);
              break;
            }
            case 40: {
              result.hasCaisRestedMinutes = input.ReadUInt32(ref result.caisRestedMinutes_);
              break;
            }
            case 48: {
              result.hasBenefactor = input.ReadBool(ref result.benefactor_);
              break;
            }
            case 56: {
              result.hasBillingMinutesRemaining = input.ReadUInt32(ref result.billingMinutesRemaining_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasSessionType {
        get { return result.hasSessionType; }
      }
      public uint SessionType {
        get { return result.SessionType; }
        set { SetSessionType(value); }
      }
      public Builder SetSessionType(uint value) {
        PrepareBuilder();
        result.hasSessionType = true;
        result.sessionType_ = value;
        return this;
      }
      public Builder ClearSessionType() {
        PrepareBuilder();
        result.hasSessionType = false;
        result.sessionType_ = 0;
        return this;
      }
      
      public bool HasExpirationTimestamp {
        get { return result.hasExpirationTimestamp; }
      }
      public ulong ExpirationTimestamp {
        get { return result.ExpirationTimestamp; }
        set { SetExpirationTimestamp(value); }
      }
      public Builder SetExpirationTimestamp(ulong value) {
        PrepareBuilder();
        result.hasExpirationTimestamp = true;
        result.expirationTimestamp_ = value;
        return this;
      }
      public Builder ClearExpirationTimestamp() {
        PrepareBuilder();
        result.hasExpirationTimestamp = false;
        result.expirationTimestamp_ = 0;
        return this;
      }
      
      public bool HasMinutesRemaining {
        get { return result.hasMinutesRemaining; }
      }
      public uint MinutesRemaining {
        get { return result.MinutesRemaining; }
        set { SetMinutesRemaining(value); }
      }
      public Builder SetMinutesRemaining(uint value) {
        PrepareBuilder();
        result.hasMinutesRemaining = true;
        result.minutesRemaining_ = value;
        return this;
      }
      public Builder ClearMinutesRemaining() {
        PrepareBuilder();
        result.hasMinutesRemaining = false;
        result.minutesRemaining_ = 0;
        return this;
      }
      
      public bool HasCaisPlayedMinutes {
        get { return result.hasCaisPlayedMinutes; }
      }
      public uint CaisPlayedMinutes {
        get { return result.CaisPlayedMinutes; }
        set { SetCaisPlayedMinutes(value); }
      }
      public Builder SetCaisPlayedMinutes(uint value) {
        PrepareBuilder();
        result.hasCaisPlayedMinutes = true;
        result.caisPlayedMinutes_ = value;
        return this;
      }
      public Builder ClearCaisPlayedMinutes() {
        PrepareBuilder();
        result.hasCaisPlayedMinutes = false;
        result.caisPlayedMinutes_ = 0;
        return this;
      }
      
      public bool HasCaisRestedMinutes {
        get { return result.hasCaisRestedMinutes; }
      }
      public uint CaisRestedMinutes {
        get { return result.CaisRestedMinutes; }
        set { SetCaisRestedMinutes(value); }
      }
      public Builder SetCaisRestedMinutes(uint value) {
        PrepareBuilder();
        result.hasCaisRestedMinutes = true;
        result.caisRestedMinutes_ = value;
        return this;
      }
      public Builder ClearCaisRestedMinutes() {
        PrepareBuilder();
        result.hasCaisRestedMinutes = false;
        result.caisRestedMinutes_ = 0;
        return this;
      }
      
      public bool HasBenefactor {
        get { return result.hasBenefactor; }
      }
      public bool Benefactor {
        get { return result.Benefactor; }
        set { SetBenefactor(value); }
      }
      public Builder SetBenefactor(bool value) {
        PrepareBuilder();
        result.hasBenefactor = true;
        result.benefactor_ = value;
        return this;
      }
      public Builder ClearBenefactor() {
        PrepareBuilder();
        result.hasBenefactor = false;
        result.benefactor_ = false;
        return this;
      }
      
      public bool HasBillingMinutesRemaining {
        get { return result.hasBillingMinutesRemaining; }
      }
      public uint BillingMinutesRemaining {
        get { return result.BillingMinutesRemaining; }
        set { SetBillingMinutesRemaining(value); }
      }
      public Builder SetBillingMinutesRemaining(uint value) {
        PrepareBuilder();
        result.hasBillingMinutesRemaining = true;
        result.billingMinutesRemaining_ = value;
        return this;
      }
      public Builder ClearBillingMinutesRemaining() {
        PrepareBuilder();
        result.hasBillingMinutesRemaining = false;
        result.billingMinutesRemaining_ = 0;
        return this;
      }
    }
    static SessionNotification() {
      object.ReferenceEquals(global::bnet.protocol.session.SessionService.Descriptor, null);
    }
  }
  
  #endregion
  
  #region Services
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public abstract class SessionNotify : pb::IService {
    public abstract void Update(
        pb::IRpcController controller,
        global::bnet.protocol.session.SessionNotification request,
        global::System.Action<global::bnet.protocol.NO_RESPONSE> done);
    
    public static pbd::ServiceDescriptor Descriptor {
      get { return SessionService.Descriptor.Services[0]; }
    }
    public pbd::ServiceDescriptor DescriptorForType {
      get { return Descriptor; }
    }
    
    public void CallMethod(
        pbd::MethodDescriptor method,
        pb::IRpcController controller,
        pb::IMessage request,
        global::System.Action<pb::IMessage> done) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.CallMethod() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          this.Update(controller, (global::bnet.protocol.session.SessionNotification) request,
              pb::RpcUtil.SpecializeCallback<global::bnet.protocol.NO_RESPONSE>(
              done));
          return;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public pb::IMessage GetRequestPrototype(pbd::MethodDescriptor method) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.GetRequestPrototype() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          return global::bnet.protocol.session.SessionNotification.DefaultInstance;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public pb::IMessage GetResponsePrototype(pbd::MethodDescriptor method) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.GetResponsePrototype() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          return global::bnet.protocol.NO_RESPONSE.DefaultInstance;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public static Stub CreateStub(pb::IRpcChannel channel) {
      return new Stub(channel);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public class Stub : global::bnet.protocol.session.SessionNotify {
      internal Stub(pb::IRpcChannel channel) {
        this.channel = channel;
      }
      
      private readonly pb::IRpcChannel channel;
      
      public pb::IRpcChannel Channel {
        get { return channel; }
      }
      
      public override void Update(
          pb::IRpcController controller,
          global::bnet.protocol.session.SessionNotification request,
          global::System.Action<global::bnet.protocol.NO_RESPONSE> done) {
        channel.CallMethod(Descriptor.Methods[0],
            controller, request, global::bnet.protocol.NO_RESPONSE.DefaultInstance,
            pb::RpcUtil.GeneralizeCallback<global::bnet.protocol.NO_RESPONSE, global::bnet.protocol.NO_RESPONSE.Builder>(done, global::bnet.protocol.NO_RESPONSE.DefaultInstance));
      }
    }
  }
  #endregion
  
}

#endregion Designer generated code
