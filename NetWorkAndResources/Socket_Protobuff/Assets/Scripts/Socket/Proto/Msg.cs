// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: msg.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.Shapejoy.Remotecontrol.Proto {

  /// <summary>Holder for reflection information generated from msg.proto</summary>
  public static partial class MsgReflection {

    #region Descriptor
    /// <summary>File descriptor for msg.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgltc2cucHJvdG8SIGNvbS5zaGFwZWpveS5yZW1vdGVjb250cm9sLnByb3Rv",
            "IlcKB01lc3NhZ2USNgoFZXZlbnQYASABKA4yJy5jb20uc2hhcGVqb3kucmVt",
            "b3RlY29udHJvbC5wcm90by5FdmVudBIUCgxkZXZpY2VOdW1iZXIYAiABKAkq",
            "UwoFRXZlbnQSCAoETlVMTBAAEgkKBUhFQVJUEAESEAoMUkVDT05ORUNUSU9O",
            "EAMSEQoMREVWSUNFX0NIRUNLEJFOEhAKC1VTRVJfTE9HT1VUEJROYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Com.Shapejoy.Remotecontrol.Proto.Event), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Shapejoy.Remotecontrol.Proto.Message), global::Com.Shapejoy.Remotecontrol.Proto.Message.Parser, new[]{ "Event", "DeviceNumber" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Event {
    [pbr::OriginalName("NULL")] Null = 0,
    [pbr::OriginalName("HEART")] Heart = 1,
    [pbr::OriginalName("RECONNECTION")] Reconnection = 3,
    [pbr::OriginalName("DEVICE_CHECK")] DeviceCheck = 10001,
    [pbr::OriginalName("USER_LOGOUT")] UserLogout = 10004,
  }

  #endregion

  #region Messages
  public sealed partial class Message : pb::IMessage<Message> {
    private static readonly pb::MessageParser<Message> _parser = new pb::MessageParser<Message>(() => new Message());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Message> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Shapejoy.Remotecontrol.Proto.MsgReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Message() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Message(Message other) : this() {
      event_ = other.event_;
      deviceNumber_ = other.deviceNumber_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Message Clone() {
      return new Message(this);
    }

    /// <summary>Field number for the "event" field.</summary>
    public const int EventFieldNumber = 1;
    private global::Com.Shapejoy.Remotecontrol.Proto.Event event_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Shapejoy.Remotecontrol.Proto.Event Event {
      get { return event_; }
      set {
        event_ = value;
      }
    }

    /// <summary>Field number for the "deviceNumber" field.</summary>
    public const int DeviceNumberFieldNumber = 2;
    private string deviceNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceNumber {
      get { return deviceNumber_; }
      set {
        deviceNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Message);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Message other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Event != other.Event) return false;
      if (DeviceNumber != other.DeviceNumber) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Event != 0) hash ^= Event.GetHashCode();
      if (DeviceNumber.Length != 0) hash ^= DeviceNumber.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Event != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Event);
      }
      if (DeviceNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceNumber);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Event != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Event);
      }
      if (DeviceNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceNumber);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Message other) {
      if (other == null) {
        return;
      }
      if (other.Event != 0) {
        Event = other.Event;
      }
      if (other.DeviceNumber.Length != 0) {
        DeviceNumber = other.DeviceNumber;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            event_ = (global::Com.Shapejoy.Remotecontrol.Proto.Event) input.ReadEnum();
            break;
          }
          case 18: {
            DeviceNumber = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
