//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: NetCG.proto
// Note: requires additional types generated from: NetHeader.proto
using NetHeader;

namespace NetCG
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ErrMsg_ToKen")]
  public partial class ErrMsg_ToKen : global::ProtoBuf.IExtensible
  {
    public ErrMsg_ToKen() {}
    
    [global::ProtoBuf.ProtoContract(Name=@"ErrEnum")]
    public enum ErrEnum
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"sys", Value=2)]
      sys = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"errorcode", Value=1)]
      errorcode = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGPing")]
  public partial class CGPing : global::ProtoBuf.IExtensible
  {
    public CGPing() {}
    
    private long _time = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long time
    {
      get { return _time; }
      set { _time = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=1)]
      MRID = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=50)]
      GROUPID = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=1)]
      UNITID = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGTime")]
  public partial class CGTime : global::ProtoBuf.IExtensible
  {
    public CGTime() {}
    
    private int _index = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private long _time = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long time
    {
      get { return _time; }
      set { _time = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=1)]
      MRID = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=50)]
      GROUPID = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=2)]
      UNITID = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGToKen")]
  public partial class CGToKen : global::ProtoBuf.IExtensible
  {
    public CGToKen() {}
    
    private string _token;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string token
    {
      get { return _token; }
      set { _token = value; }
    }
    private ulong _playerid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"playerid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong playerid
    {
      get { return _playerid; }
      set { _playerid = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=1)]
      MRID = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=1)]
      GROUPID = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=2)]
      UNITID = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGSelectRole")]
  public partial class CGSelectRole : global::ProtoBuf.IExtensible
  {
    public CGSelectRole() {}
    
    private int _index = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=1)]
      MRID = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=2)]
      GROUPID = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=1)]
      UNITID = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GCSelectRole")]
  public partial class GCSelectRole : global::ProtoBuf.IExtensible
  {
    public GCSelectRole() {}
    
    private int _index = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private long _rid = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=2)]
      MRID = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=2)]
      GROUPID = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=1)]
      UNITID = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GCToKen")]
  public partial class GCToKen : global::ProtoBuf.IExtensible
  {
    public GCToKen() {}
    
    private CurrencyResult _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public CurrencyResult result
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
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=2)]
      MRID = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=1)]
      GROUPID = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=2)]
      UNITID = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GCTime")]
  public partial class GCTime : global::ProtoBuf.IExtensible
  {
    public GCTime() {}
    
    private int _index = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private long _time = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long time
    {
      get { return _time; }
      set { _time = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=2)]
      MRID = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=50)]
      GROUPID = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=2)]
      UNITID = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GCPong")]
  public partial class GCPong : global::ProtoBuf.IExtensible
  {
    public GCPong() {}
    
    private long _time = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long time
    {
      get { return _time; }
      set { _time = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MRID", Value=2)]
      MRID = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUPID", Value=50)]
      GROUPID = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNITID", Value=1)]
      UNITID = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}