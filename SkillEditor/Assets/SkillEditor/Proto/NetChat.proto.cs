//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: NetChat.proto
// Note: requires additional types generated from: NetHeader.proto
namespace NetChat
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ParamData")]
  public partial class ParamData : global::ProtoBuf.IExtensible
  {
    public ParamData() {}
    
    private ParamType _paramType = ParamType.CHAT_PARAM_PLAYER;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"paramType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(ParamType.CHAT_PARAM_PLAYER)]
    public ParamType paramType
    {
      get { return _paramType; }
      set { _paramType = value; }
    }
    private string _paramString = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"paramString", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string paramString
    {
      get { return _paramString; }
      set { _paramString = value; }
    }
    private int _paramInt = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"paramInt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int paramInt
    {
      get { return _paramInt; }
      set { _paramInt = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCHATRegister")]
  public partial class CCHATRegister : global::ProtoBuf.IExtensible
  {
    public CCHATRegister() {}
    
    private long _pid = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"pid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long pid
    {
      get { return _pid; }
      set { _pid = value; }
    }
    private long _rid = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    private string _token = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string token
    {
      get { return _token; }
      set { _token = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=21)]
      MRID = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=5)]
      GROUPID = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=1)]
      UNITID = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCHATSendMessage")]
  public partial class CCHATSendMessage : global::ProtoBuf.IExtensible
  {
    public CCHATSendMessage() {}
    
    private ChatType _msgType = ChatType.CHAT_CHANNEL_WORLD;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msgType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(ChatType.CHAT_CHANNEL_WORLD)]
    public ChatType msgType
    {
      get { return _msgType; }
      set { _msgType = value; }
    }
    private string _msg = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string msg
    {
      get { return _msg; }
      set { _msg = value; }
    }
    private readonly global::System.Collections.Generic.List<ParamData> _msgParams = new global::System.Collections.Generic.List<ParamData>();
    [global::ProtoBuf.ProtoMember(3, Name=@"msgParams", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ParamData> msgParams
    {
      get { return _msgParams; }
    }
  
    private long _receiverId = default(long);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"receiverId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long receiverId
    {
      get { return _receiverId; }
      set { _receiverId = value; }
    }
    private string _voice = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"voice", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string voice
    {
      get { return _voice; }
      set { _voice = value; }
    }
    private string _extData = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"extData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string extData
    {
      get { return _extData; }
      set { _extData = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=21)]
      MRID = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=5)]
      GROUPID = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=2)]
      UNITID = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CHATCreateGroup")]
  public partial class CHATCreateGroup : global::ProtoBuf.IExtensible
  {
    public CHATCreateGroup() {}
    
    private GroupType _groupType = GroupType.CHAT_NORMAL_GROUP;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"groupType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(GroupType.CHAT_NORMAL_GROUP)]
    public GroupType groupType
    {
      get { return _groupType; }
      set { _groupType = value; }
    }
    private readonly global::System.Collections.Generic.List<long> _playerIdList = new global::System.Collections.Generic.List<long>();
    [global::ProtoBuf.ProtoMember(2, Name=@"playerIdList", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<long> playerIdList
    {
      get { return _playerIdList; }
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=21)]
      MRID = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=5)]
      GROUPID = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=3)]
      UNITID = 3
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CHATOperationGroup")]
  public partial class CHATOperationGroup : global::ProtoBuf.IExtensible
  {
    public CHATOperationGroup() {}
    
    private OperationChatType _operateType = OperationChatType.CHAT_JOIN_GROUP;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"operateType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(OperationChatType.CHAT_JOIN_GROUP)]
    public OperationChatType operateType
    {
      get { return _operateType; }
      set { _operateType = value; }
    }
    private long _groupId = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"groupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long groupId
    {
      get { return _groupId; }
      set { _groupId = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=21)]
      MRID = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=5)]
      GROUPID = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=4)]
      UNITID = 4
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CHATNotifyConnect")]
  public partial class CHATNotifyConnect : global::ProtoBuf.IExtensible
  {
    public CHATNotifyConnect() {}
    
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=21)]
      MRID = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=5)]
      GROUPID = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=5)]
      UNITID = 5
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CHATCRegister")]
  public partial class CHATCRegister : global::ProtoBuf.IExtensible
  {
    public CHATCRegister() {}
    
    private int _result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private long _pid = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"pid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long pid
    {
      get { return _pid; }
      set { _pid = value; }
    }
    private long _rid = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    private string _sdkToken = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"sdkToken", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sdkToken
    {
      get { return _sdkToken; }
      set { _sdkToken = value; }
    }
    private string _chatServerIp = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"chatServerIp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string chatServerIp
    {
      get { return _chatServerIp; }
      set { _chatServerIp = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=22)]
      MRID = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=5)]
      GROUPID = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=1)]
      UNITID = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CHATCBroadCastMessage")]
  public partial class CHATCBroadCastMessage : global::ProtoBuf.IExtensible
  {
    public CHATCBroadCastMessage() {}
    
    private ChatType _msgType = ChatType.CHAT_CHANNEL_WORLD;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msgType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(ChatType.CHAT_CHANNEL_WORLD)]
    public ChatType msgType
    {
      get { return _msgType; }
      set { _msgType = value; }
    }
    private int _msgID = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"msgID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int msgID
    {
      get { return _msgID; }
      set { _msgID = value; }
    }
    private readonly global::System.Collections.Generic.List<ParamData> _msgParams = new global::System.Collections.Generic.List<ParamData>();
    [global::ProtoBuf.ProtoMember(3, Name=@"msgParams", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ParamData> msgParams
    {
      get { return _msgParams; }
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=22)]
      MRID = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=5)]
      GROUPID = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=2)]
      UNITID = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"ChatType")]
    public enum ChatType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_CHANNEL_WORLD", Value=1)]
      CHAT_CHANNEL_WORLD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_CHANNEL_SYSTEM", Value=2)]
      CHAT_CHANNEL_SYSTEM = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ParamType")]
    public enum ParamType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_PARAM_PLAYER", Value=1)]
      CHAT_PARAM_PLAYER = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_PARAM_ITEM", Value=2)]
      CHAT_PARAM_ITEM = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_PARAM_EQUIP", Value=3)]
      CHAT_PARAM_EQUIP = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"GroupType")]
    public enum GroupType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_NORMAL_GROUP", Value=1)]
      CHAT_NORMAL_GROUP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_GUILD_GROUP", Value=2)]
      CHAT_GUILD_GROUP = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"OperationChatType")]
    public enum OperationChatType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_JOIN_GROUP", Value=1)]
      CHAT_JOIN_GROUP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_LEAVE_GROUP", Value=2)]
      CHAT_LEAVE_GROUP = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_DESTROY_GROUP", Value=3)]
      CHAT_DESTROY_GROUP = 3
    }
  
}