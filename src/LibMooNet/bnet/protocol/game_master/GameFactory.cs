// Generated by ProtoGen, Version=2.4.1.473, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bnet.protocol.game_master {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public static partial class GameFactory {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_game_master_GameProperties__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.game_master.GameProperties, global::bnet.protocol.game_master.GameProperties.Builder> internal__static_bnet_protocol_game_master_GameProperties__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static GameFactory() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "ChdibmV0L2dhbWVfZmFjdG9yeS5wcm90bxIZYm5ldC5wcm90b2NvbC5nYW1l" + 
          "X21hc3RlchoUYm5ldC9hdHRyaWJ1dGUucHJvdG8aEWJuZXQvZW50aXR5LnBy" + 
          "b3RvIsoBCg5HYW1lUHJvcGVydGllcxI/ChNjcmVhdGlvbl9hdHRyaWJ1dGVz" + 
          "GAEgAygLMiIuYm5ldC5wcm90b2NvbC5hdHRyaWJ1dGUuQXR0cmlidXRlEjgK" + 
          "BmZpbHRlchgCIAEoCzIoLmJuZXQucHJvdG9jb2wuYXR0cmlidXRlLkF0dHJp" + 
          "YnV0ZUZpbHRlchIVCgZjcmVhdGUYAyABKAg6BWZhbHNlEhIKBG9wZW4YBCAB" + 
          "KAg6BHRydWUSEgoKcHJvZ3JhbV9pZBgFIAEoBw==");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_bnet_protocol_game_master_GameProperties__Descriptor = Descriptor.MessageTypes[0];
        internal__static_bnet_protocol_game_master_GameProperties__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.game_master.GameProperties, global::bnet.protocol.game_master.GameProperties.Builder>(internal__static_bnet_protocol_game_master_GameProperties__Descriptor,
                new string[] { "CreationAttributes", "Filter", "Create", "Open", "ProgramId", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::bnet.protocol.attribute.Proto.Attribute.Descriptor, 
          global::bnet.protocol.Entity.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class GameProperties : pb::GeneratedMessage<GameProperties, GameProperties.Builder> {
    private GameProperties() { }
    private static readonly GameProperties defaultInstance = new GameProperties().MakeReadOnly();
    private static readonly string[] _gamePropertiesFieldNames = new string[] { "create", "creation_attributes", "filter", "open", "program_id" };
    private static readonly uint[] _gamePropertiesFieldTags = new uint[] { 24, 10, 18, 32, 45 };
    public static GameProperties DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override GameProperties DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override GameProperties ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.game_master.GameFactory.internal__static_bnet_protocol_game_master_GameProperties__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<GameProperties, GameProperties.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.game_master.GameFactory.internal__static_bnet_protocol_game_master_GameProperties__FieldAccessorTable; }
    }
    
    public const int CreationAttributesFieldNumber = 1;
    private pbc::PopsicleList<global::bnet.protocol.attribute.Attribute> creationAttributes_ = new pbc::PopsicleList<global::bnet.protocol.attribute.Attribute>();
    public scg::IList<global::bnet.protocol.attribute.Attribute> CreationAttributesList {
      get { return creationAttributes_; }
    }
    public int CreationAttributesCount {
      get { return creationAttributes_.Count; }
    }
    public global::bnet.protocol.attribute.Attribute GetCreationAttributes(int index) {
      return creationAttributes_[index];
    }
    
    public const int FilterFieldNumber = 2;
    private bool hasFilter;
    private global::bnet.protocol.attribute.AttributeFilter filter_;
    public bool HasFilter {
      get { return hasFilter; }
    }
    public global::bnet.protocol.attribute.AttributeFilter Filter {
      get { return filter_ ?? global::bnet.protocol.attribute.AttributeFilter.DefaultInstance; }
    }
    
    public const int CreateFieldNumber = 3;
    private bool hasCreate;
    private bool create_;
    public bool HasCreate {
      get { return hasCreate; }
    }
    public bool Create {
      get { return create_; }
    }
    
    public const int OpenFieldNumber = 4;
    private bool hasOpen;
    private bool open_ = true;
    public bool HasOpen {
      get { return hasOpen; }
    }
    public bool Open {
      get { return open_; }
    }
    
    public const int ProgramIdFieldNumber = 5;
    private bool hasProgramId;
    private uint programId_;
    public bool HasProgramId {
      get { return hasProgramId; }
    }
    public uint ProgramId {
      get { return programId_; }
    }
    
    public override bool IsInitialized {
      get {
        foreach (global::bnet.protocol.attribute.Attribute element in CreationAttributesList) {
          if (!element.IsInitialized) return false;
        }
        if (HasFilter) {
          if (!Filter.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _gamePropertiesFieldNames;
      if (creationAttributes_.Count > 0) {
        output.WriteMessageArray(1, field_names[1], creationAttributes_);
      }
      if (hasFilter) {
        output.WriteMessage(2, field_names[2], Filter);
      }
      if (hasCreate) {
        output.WriteBool(3, field_names[0], Create);
      }
      if (hasOpen) {
        output.WriteBool(4, field_names[3], Open);
      }
      if (hasProgramId) {
        output.WriteFixed32(5, field_names[4], ProgramId);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        foreach (global::bnet.protocol.attribute.Attribute element in CreationAttributesList) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, element);
        }
        if (hasFilter) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, Filter);
        }
        if (hasCreate) {
          size += pb::CodedOutputStream.ComputeBoolSize(3, Create);
        }
        if (hasOpen) {
          size += pb::CodedOutputStream.ComputeBoolSize(4, Open);
        }
        if (hasProgramId) {
          size += pb::CodedOutputStream.ComputeFixed32Size(5, ProgramId);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static GameProperties ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static GameProperties ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static GameProperties ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static GameProperties ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static GameProperties ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static GameProperties ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static GameProperties ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static GameProperties ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static GameProperties ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static GameProperties ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private GameProperties MakeReadOnly() {
      creationAttributes_.MakeReadOnly();
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(GameProperties prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<GameProperties, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(GameProperties cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private GameProperties result;
      
      private GameProperties PrepareBuilder() {
        if (resultIsReadOnly) {
          GameProperties original = result;
          result = new GameProperties();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override GameProperties MessageBeingBuilt {
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
        get { return global::bnet.protocol.game_master.GameProperties.Descriptor; }
      }
      
      public override GameProperties DefaultInstanceForType {
        get { return global::bnet.protocol.game_master.GameProperties.DefaultInstance; }
      }
      
      public override GameProperties BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is GameProperties) {
          return MergeFrom((GameProperties) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(GameProperties other) {
        if (other == global::bnet.protocol.game_master.GameProperties.DefaultInstance) return this;
        PrepareBuilder();
        if (other.creationAttributes_.Count != 0) {
          result.creationAttributes_.Add(other.creationAttributes_);
        }
        if (other.HasFilter) {
          MergeFilter(other.Filter);
        }
        if (other.HasCreate) {
          Create = other.Create;
        }
        if (other.HasOpen) {
          Open = other.Open;
        }
        if (other.HasProgramId) {
          ProgramId = other.ProgramId;
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
            int field_ordinal = global::System.Array.BinarySearch(_gamePropertiesFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _gamePropertiesFieldTags[field_ordinal];
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
            case 10: {
              input.ReadMessageArray(tag, field_name, result.creationAttributes_, global::bnet.protocol.attribute.Attribute.DefaultInstance, extensionRegistry);
              break;
            }
            case 18: {
              global::bnet.protocol.attribute.AttributeFilter.Builder subBuilder = global::bnet.protocol.attribute.AttributeFilter.CreateBuilder();
              if (result.hasFilter) {
                subBuilder.MergeFrom(Filter);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Filter = subBuilder.BuildPartial();
              break;
            }
            case 24: {
              result.hasCreate = input.ReadBool(ref result.create_);
              break;
            }
            case 32: {
              result.hasOpen = input.ReadBool(ref result.open_);
              break;
            }
            case 45: {
              result.hasProgramId = input.ReadFixed32(ref result.programId_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public pbc::IPopsicleList<global::bnet.protocol.attribute.Attribute> CreationAttributesList {
        get { return PrepareBuilder().creationAttributes_; }
      }
      public int CreationAttributesCount {
        get { return result.CreationAttributesCount; }
      }
      public global::bnet.protocol.attribute.Attribute GetCreationAttributes(int index) {
        return result.GetCreationAttributes(index);
      }
      public Builder SetCreationAttributes(int index, global::bnet.protocol.attribute.Attribute value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.creationAttributes_[index] = value;
        return this;
      }
      public Builder SetCreationAttributes(int index, global::bnet.protocol.attribute.Attribute.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.creationAttributes_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddCreationAttributes(global::bnet.protocol.attribute.Attribute value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.creationAttributes_.Add(value);
        return this;
      }
      public Builder AddCreationAttributes(global::bnet.protocol.attribute.Attribute.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.creationAttributes_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangeCreationAttributes(scg::IEnumerable<global::bnet.protocol.attribute.Attribute> values) {
        PrepareBuilder();
        result.creationAttributes_.Add(values);
        return this;
      }
      public Builder ClearCreationAttributes() {
        PrepareBuilder();
        result.creationAttributes_.Clear();
        return this;
      }
      
      public bool HasFilter {
       get { return result.hasFilter; }
      }
      public global::bnet.protocol.attribute.AttributeFilter Filter {
        get { return result.Filter; }
        set { SetFilter(value); }
      }
      public Builder SetFilter(global::bnet.protocol.attribute.AttributeFilter value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasFilter = true;
        result.filter_ = value;
        return this;
      }
      public Builder SetFilter(global::bnet.protocol.attribute.AttributeFilter.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasFilter = true;
        result.filter_ = builderForValue.Build();
        return this;
      }
      public Builder MergeFilter(global::bnet.protocol.attribute.AttributeFilter value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasFilter &&
            result.filter_ != global::bnet.protocol.attribute.AttributeFilter.DefaultInstance) {
            result.filter_ = global::bnet.protocol.attribute.AttributeFilter.CreateBuilder(result.filter_).MergeFrom(value).BuildPartial();
        } else {
          result.filter_ = value;
        }
        result.hasFilter = true;
        return this;
      }
      public Builder ClearFilter() {
        PrepareBuilder();
        result.hasFilter = false;
        result.filter_ = null;
        return this;
      }
      
      public bool HasCreate {
        get { return result.hasCreate; }
      }
      public bool Create {
        get { return result.Create; }
        set { SetCreate(value); }
      }
      public Builder SetCreate(bool value) {
        PrepareBuilder();
        result.hasCreate = true;
        result.create_ = value;
        return this;
      }
      public Builder ClearCreate() {
        PrepareBuilder();
        result.hasCreate = false;
        result.create_ = false;
        return this;
      }
      
      public bool HasOpen {
        get { return result.hasOpen; }
      }
      public bool Open {
        get { return result.Open; }
        set { SetOpen(value); }
      }
      public Builder SetOpen(bool value) {
        PrepareBuilder();
        result.hasOpen = true;
        result.open_ = value;
        return this;
      }
      public Builder ClearOpen() {
        PrepareBuilder();
        result.hasOpen = false;
        result.open_ = true;
        return this;
      }
      
      public bool HasProgramId {
        get { return result.hasProgramId; }
      }
      public uint ProgramId {
        get { return result.ProgramId; }
        set { SetProgramId(value); }
      }
      public Builder SetProgramId(uint value) {
        PrepareBuilder();
        result.hasProgramId = true;
        result.programId_ = value;
        return this;
      }
      public Builder ClearProgramId() {
        PrepareBuilder();
        result.hasProgramId = false;
        result.programId_ = 0;
        return this;
      }
    }
    static GameProperties() {
      object.ReferenceEquals(global::bnet.protocol.game_master.GameFactory.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
