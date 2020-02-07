// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents_envs/communicator_objects/engine_configuration.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents_envs/communicator_objects/engine_configuration.proto</summary>
  public static partial class EngineConfigurationReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents_envs/communicator_objects/engine_configuration.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EngineConfigurationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1tbGFnZW50c19lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL2VuZ2luZV9j",
            "b25maWd1cmF0aW9uLnByb3RvEhRjb21tdW5pY2F0b3Jfb2JqZWN0cyKVAQoY",
            "RW5naW5lQ29uZmlndXJhdGlvblByb3RvEg0KBXdpZHRoGAEgASgFEg4KBmhl",
            "aWdodBgCIAEoBRIVCg1xdWFsaXR5X2xldmVsGAMgASgFEhIKCnRpbWVfc2Nh",
            "bGUYBCABKAISGQoRdGFyZ2V0X2ZyYW1lX3JhdGUYBSABKAUSFAoMc2hvd19t",
            "b25pdG9yGAYgASgIQh+qAhxNTEFnZW50cy5Db21tdW5pY2F0b3JPYmplY3Rz",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.CommunicatorObjects.EngineConfigurationProto), global::MLAgents.CommunicatorObjects.EngineConfigurationProto.Parser, new[]{ "Width", "Height", "QualityLevel", "TimeScale", "TargetFrameRate", "ShowMonitor" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EngineConfigurationProto : pb::IMessage<EngineConfigurationProto> {
    private static readonly pb::MessageParser<EngineConfigurationProto> _parser = new pb::MessageParser<EngineConfigurationProto>(() => new EngineConfigurationProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EngineConfigurationProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MLAgents.CommunicatorObjects.EngineConfigurationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EngineConfigurationProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EngineConfigurationProto(EngineConfigurationProto other) : this() {
      width_ = other.width_;
      height_ = other.height_;
      qualityLevel_ = other.qualityLevel_;
      timeScale_ = other.timeScale_;
      targetFrameRate_ = other.targetFrameRate_;
      showMonitor_ = other.showMonitor_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EngineConfigurationProto Clone() {
      return new EngineConfigurationProto(this);
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 1;
    private int width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Width {
      get { return width_; }
      set {
        width_ = value;
      }
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 2;
    private int height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    /// <summary>Field number for the "quality_level" field.</summary>
    public const int QualityLevelFieldNumber = 3;
    private int qualityLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int QualityLevel {
      get { return qualityLevel_; }
      set {
        qualityLevel_ = value;
      }
    }

    /// <summary>Field number for the "time_scale" field.</summary>
    public const int TimeScaleFieldNumber = 4;
    private float timeScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float TimeScale {
      get { return timeScale_; }
      set {
        timeScale_ = value;
      }
    }

    /// <summary>Field number for the "target_frame_rate" field.</summary>
    public const int TargetFrameRateFieldNumber = 5;
    private int targetFrameRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TargetFrameRate {
      get { return targetFrameRate_; }
      set {
        targetFrameRate_ = value;
      }
    }

    /// <summary>Field number for the "show_monitor" field.</summary>
    public const int ShowMonitorFieldNumber = 6;
    private bool showMonitor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ShowMonitor {
      get { return showMonitor_; }
      set {
        showMonitor_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EngineConfigurationProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EngineConfigurationProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Width != other.Width) return false;
      if (Height != other.Height) return false;
      if (QualityLevel != other.QualityLevel) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TimeScale, other.TimeScale)) return false;
      if (TargetFrameRate != other.TargetFrameRate) return false;
      if (ShowMonitor != other.ShowMonitor) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Width != 0) hash ^= Width.GetHashCode();
      if (Height != 0) hash ^= Height.GetHashCode();
      if (QualityLevel != 0) hash ^= QualityLevel.GetHashCode();
      if (TimeScale != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TimeScale);
      if (TargetFrameRate != 0) hash ^= TargetFrameRate.GetHashCode();
      if (ShowMonitor != false) hash ^= ShowMonitor.GetHashCode();
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
      if (Width != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Width);
      }
      if (Height != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Height);
      }
      if (QualityLevel != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(QualityLevel);
      }
      if (TimeScale != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(TimeScale);
      }
      if (TargetFrameRate != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(TargetFrameRate);
      }
      if (ShowMonitor != false) {
        output.WriteRawTag(48);
        output.WriteBool(ShowMonitor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Width != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Width);
      }
      if (Height != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Height);
      }
      if (QualityLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(QualityLevel);
      }
      if (TimeScale != 0F) {
        size += 1 + 4;
      }
      if (TargetFrameRate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TargetFrameRate);
      }
      if (ShowMonitor != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EngineConfigurationProto other) {
      if (other == null) {
        return;
      }
      if (other.Width != 0) {
        Width = other.Width;
      }
      if (other.Height != 0) {
        Height = other.Height;
      }
      if (other.QualityLevel != 0) {
        QualityLevel = other.QualityLevel;
      }
      if (other.TimeScale != 0F) {
        TimeScale = other.TimeScale;
      }
      if (other.TargetFrameRate != 0) {
        TargetFrameRate = other.TargetFrameRate;
      }
      if (other.ShowMonitor != false) {
        ShowMonitor = other.ShowMonitor;
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
            Width = input.ReadInt32();
            break;
          }
          case 16: {
            Height = input.ReadInt32();
            break;
          }
          case 24: {
            QualityLevel = input.ReadInt32();
            break;
          }
          case 37: {
            TimeScale = input.ReadFloat();
            break;
          }
          case 40: {
            TargetFrameRate = input.ReadInt32();
            break;
          }
          case 48: {
            ShowMonitor = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
