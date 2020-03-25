// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/graphdefinitionservice.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SensorSystem.GraphDefinitions.Protos {

  /// <summary>Holder for reflection information generated from Protos/graphdefinitionservice.proto</summary>
  public static partial class GraphdefinitionserviceReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/graphdefinitionservice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GraphdefinitionserviceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNQcm90b3MvZ3JhcGhkZWZpbml0aW9uc2VydmljZS5wcm90bxIWR3JhcGhE",
            "ZWZpbml0aW9uU2VydmljZSInCgpHZXRSZXF1ZXN0EhkKEWdyYXBoRGVmaW5p",
            "dGlvbklkGAEgASgFIk4KC0dldFJlc3BvbnNlEj8KDmdyYXBoRGVmbml0aW9u",
            "GAEgASgLMicuR3JhcGhEZWZpbml0aW9uU2VydmljZS5HcmFwaERlZmluaXRp",
            "b24iIQoNR2V0QWxsUmVxdWVzdBIQCghzeXN0ZW1JZBgBIAEoCSJTCg5HZXRB",
            "bGxSZXNwb25zZRJBChBncmFwaERlZmluaXRpb25zGAEgAygLMicuR3JhcGhE",
            "ZWZpbml0aW9uU2VydmljZS5HcmFwaERlZmluaXRpb24iZwoPR3JhcGhEZWZp",
            "bml0aW9uEgoKAmlkGAEgASgJEgwKBG5hbWUYAiABKAkSOgoFaXRlbXMYAyAD",
            "KAsyKy5HcmFwaERlZmluaXRpb25TZXJ2aWNlLkdyYXBoRGVmaW5pdGlvbkl0",
            "ZW0iPgoTR3JhcGhEZWZpbml0aW9uSXRlbRIKCgJpZBgBIAEoCRIMCgR0eXBl",
            "GAIgASgFEg0KBWNvbG9yGAMgASgFMrsBChBHcmFwaERlZmluaXRpb25zEk4K",
            "A0dldBIiLkdyYXBoRGVmaW5pdGlvblNlcnZpY2UuR2V0UmVxdWVzdBojLkdy",
            "YXBoRGVmaW5pdGlvblNlcnZpY2UuR2V0UmVzcG9uc2USVwoGR2V0QWxsEiUu",
            "R3JhcGhEZWZpbml0aW9uU2VydmljZS5HZXRBbGxSZXF1ZXN0GiYuR3JhcGhE",
            "ZWZpbml0aW9uU2VydmljZS5HZXRBbGxSZXNwb25zZUInqgIkU2Vuc29yU3lz",
            "dGVtLkdyYXBoRGVmaW5pdGlvbnMuUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SensorSystem.GraphDefinitions.Protos.GetRequest), global::SensorSystem.GraphDefinitions.Protos.GetRequest.Parser, new[]{ "GraphDefinitionId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SensorSystem.GraphDefinitions.Protos.GetResponse), global::SensorSystem.GraphDefinitions.Protos.GetResponse.Parser, new[]{ "GraphDefnition" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SensorSystem.GraphDefinitions.Protos.GetAllRequest), global::SensorSystem.GraphDefinitions.Protos.GetAllRequest.Parser, new[]{ "SystemId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SensorSystem.GraphDefinitions.Protos.GetAllResponse), global::SensorSystem.GraphDefinitions.Protos.GetAllResponse.Parser, new[]{ "GraphDefinitions" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SensorSystem.GraphDefinitions.Protos.GraphDefinition), global::SensorSystem.GraphDefinitions.Protos.GraphDefinition.Parser, new[]{ "Id", "Name", "Items" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SensorSystem.GraphDefinitions.Protos.GraphDefinitionItem), global::SensorSystem.GraphDefinitions.Protos.GraphDefinitionItem.Parser, new[]{ "Id", "Type", "Color" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetRequest : pb::IMessage<GetRequest> {
    private static readonly pb::MessageParser<GetRequest> _parser = new pb::MessageParser<GetRequest>(() => new GetRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SensorSystem.GraphDefinitions.Protos.GraphdefinitionserviceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRequest(GetRequest other) : this() {
      graphDefinitionId_ = other.graphDefinitionId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRequest Clone() {
      return new GetRequest(this);
    }

    /// <summary>Field number for the "graphDefinitionId" field.</summary>
    public const int GraphDefinitionIdFieldNumber = 1;
    private int graphDefinitionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int GraphDefinitionId {
      get { return graphDefinitionId_; }
      set {
        graphDefinitionId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GraphDefinitionId != other.GraphDefinitionId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (GraphDefinitionId != 0) hash ^= GraphDefinitionId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (GraphDefinitionId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(GraphDefinitionId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (GraphDefinitionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GraphDefinitionId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetRequest other) {
      if (other == null) {
        return;
      }
      if (other.GraphDefinitionId != 0) {
        GraphDefinitionId = other.GraphDefinitionId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            GraphDefinitionId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetResponse : pb::IMessage<GetResponse> {
    private static readonly pb::MessageParser<GetResponse> _parser = new pb::MessageParser<GetResponse>(() => new GetResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SensorSystem.GraphDefinitions.Protos.GraphdefinitionserviceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResponse(GetResponse other) : this() {
      graphDefnition_ = other.graphDefnition_ != null ? other.graphDefnition_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResponse Clone() {
      return new GetResponse(this);
    }

    /// <summary>Field number for the "graphDefnition" field.</summary>
    public const int GraphDefnitionFieldNumber = 1;
    private global::SensorSystem.GraphDefinitions.Protos.GraphDefinition graphDefnition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::SensorSystem.GraphDefinitions.Protos.GraphDefinition GraphDefnition {
      get { return graphDefnition_; }
      set {
        graphDefnition_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GraphDefnition, other.GraphDefnition)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (graphDefnition_ != null) hash ^= GraphDefnition.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (graphDefnition_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(GraphDefnition);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (graphDefnition_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GraphDefnition);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetResponse other) {
      if (other == null) {
        return;
      }
      if (other.graphDefnition_ != null) {
        if (graphDefnition_ == null) {
          GraphDefnition = new global::SensorSystem.GraphDefinitions.Protos.GraphDefinition();
        }
        GraphDefnition.MergeFrom(other.GraphDefnition);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (graphDefnition_ == null) {
              GraphDefnition = new global::SensorSystem.GraphDefinitions.Protos.GraphDefinition();
            }
            input.ReadMessage(GraphDefnition);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetAllRequest : pb::IMessage<GetAllRequest> {
    private static readonly pb::MessageParser<GetAllRequest> _parser = new pb::MessageParser<GetAllRequest>(() => new GetAllRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAllRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SensorSystem.GraphDefinitions.Protos.GraphdefinitionserviceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest(GetAllRequest other) : this() {
      systemId_ = other.systemId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest Clone() {
      return new GetAllRequest(this);
    }

    /// <summary>Field number for the "systemId" field.</summary>
    public const int SystemIdFieldNumber = 1;
    private string systemId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SystemId {
      get { return systemId_; }
      set {
        systemId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAllRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAllRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SystemId != other.SystemId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SystemId.Length != 0) hash ^= SystemId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SystemId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SystemId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SystemId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SystemId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAllRequest other) {
      if (other == null) {
        return;
      }
      if (other.SystemId.Length != 0) {
        SystemId = other.SystemId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SystemId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetAllResponse : pb::IMessage<GetAllResponse> {
    private static readonly pb::MessageParser<GetAllResponse> _parser = new pb::MessageParser<GetAllResponse>(() => new GetAllResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAllResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SensorSystem.GraphDefinitions.Protos.GraphdefinitionserviceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllResponse(GetAllResponse other) : this() {
      graphDefinitions_ = other.graphDefinitions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllResponse Clone() {
      return new GetAllResponse(this);
    }

    /// <summary>Field number for the "graphDefinitions" field.</summary>
    public const int GraphDefinitionsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::SensorSystem.GraphDefinitions.Protos.GraphDefinition> _repeated_graphDefinitions_codec
        = pb::FieldCodec.ForMessage(10, global::SensorSystem.GraphDefinitions.Protos.GraphDefinition.Parser);
    private readonly pbc::RepeatedField<global::SensorSystem.GraphDefinitions.Protos.GraphDefinition> graphDefinitions_ = new pbc::RepeatedField<global::SensorSystem.GraphDefinitions.Protos.GraphDefinition>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::SensorSystem.GraphDefinitions.Protos.GraphDefinition> GraphDefinitions {
      get { return graphDefinitions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAllResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAllResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!graphDefinitions_.Equals(other.graphDefinitions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= graphDefinitions_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      graphDefinitions_.WriteTo(output, _repeated_graphDefinitions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += graphDefinitions_.CalculateSize(_repeated_graphDefinitions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAllResponse other) {
      if (other == null) {
        return;
      }
      graphDefinitions_.Add(other.graphDefinitions_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            graphDefinitions_.AddEntriesFrom(input, _repeated_graphDefinitions_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GraphDefinition : pb::IMessage<GraphDefinition> {
    private static readonly pb::MessageParser<GraphDefinition> _parser = new pb::MessageParser<GraphDefinition>(() => new GraphDefinition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GraphDefinition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SensorSystem.GraphDefinitions.Protos.GraphdefinitionserviceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphDefinition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphDefinition(GraphDefinition other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      items_ = other.items_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphDefinition Clone() {
      return new GraphDefinition(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::SensorSystem.GraphDefinitions.Protos.GraphDefinitionItem> _repeated_items_codec
        = pb::FieldCodec.ForMessage(26, global::SensorSystem.GraphDefinitions.Protos.GraphDefinitionItem.Parser);
    private readonly pbc::RepeatedField<global::SensorSystem.GraphDefinitions.Protos.GraphDefinitionItem> items_ = new pbc::RepeatedField<global::SensorSystem.GraphDefinitions.Protos.GraphDefinitionItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::SensorSystem.GraphDefinitions.Protos.GraphDefinitionItem> Items {
      get { return items_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GraphDefinition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GraphDefinition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if(!items_.Equals(other.items_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= items_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      items_.WriteTo(output, _repeated_items_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += items_.CalculateSize(_repeated_items_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GraphDefinition other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      items_.Add(other.items_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GraphDefinitionItem : pb::IMessage<GraphDefinitionItem> {
    private static readonly pb::MessageParser<GraphDefinitionItem> _parser = new pb::MessageParser<GraphDefinitionItem>(() => new GraphDefinitionItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GraphDefinitionItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SensorSystem.GraphDefinitions.Protos.GraphdefinitionserviceReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphDefinitionItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphDefinitionItem(GraphDefinitionItem other) : this() {
      id_ = other.id_;
      type_ = other.type_;
      color_ = other.color_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphDefinitionItem Clone() {
      return new GraphDefinitionItem(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private int type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "color" field.</summary>
    public const int ColorFieldNumber = 3;
    private int color_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Color {
      get { return color_; }
      set {
        color_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GraphDefinitionItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GraphDefinitionItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Type != other.Type) return false;
      if (Color != other.Color) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Color != 0) hash ^= Color.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Type);
      }
      if (Color != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Color);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Type);
      }
      if (Color != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Color);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GraphDefinitionItem other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Color != 0) {
        Color = other.Color;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 16: {
            Type = input.ReadInt32();
            break;
          }
          case 24: {
            Color = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code