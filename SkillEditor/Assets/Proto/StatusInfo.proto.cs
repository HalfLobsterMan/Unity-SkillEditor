//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: StatusInfo.proto
// Note: requires additional types generated from: StringID.proto
using StringID;

namespace StatusInfo
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StatusUnit")]
  public partial class StatusUnit : global::ProtoBuf.IExtensible
  {
    public StatusUnit() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _addPriority = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"addPriority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int addPriority
    {
      get { return _addPriority; }
      set { _addPriority = value; }
    }
    private int _delPriority = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"delPriority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int delPriority
    {
      get { return _delPriority; }
      set { _delPriority = value; }
    }
    private StatusUnit.Status _status = StatusUnit.Status.STATUS_NONE;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(StatusUnit.Status.STATUS_NONE)]
    public StatusUnit.Status status
    {
      get { return _status; }
      set { _status = value; }
    }
    private int _value = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int value
    {
      get { return _value; }
      set { _value = value; }
    }
    private float _percent = (float)1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"percent", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)1)]
    public float percent
    {
      get { return _percent; }
      set { _percent = value; }
    }
    private int _interval = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"interval", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int interval
    {
      get { return _interval; }
      set { _interval = value; }
    }
    private int _count = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int count
    {
      get { return _count; }
      set { _count = value; }
    }
    private int _info = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int info
    {
      get { return _info; }
      set { _info = value; }
    }
    private int _maxNum = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"maxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int maxNum
    {
      get { return _maxNum; }
      set { _maxNum = value; }
    }
    private int _critRate = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"critRate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int critRate
    {
      get { return _critRate; }
      set { _critRate = value; }
    }
    private float _critMultiple = default(float);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"critMultiple", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float critMultiple
    {
      get { return _critMultiple; }
      set { _critMultiple = value; }
    }
    private int _hatredBase = default(int);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"hatredBase", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int hatredBase
    {
      get { return _hatredBase; }
      set { _hatredBase = value; }
    }
    private float _hatredCofficient = default(float);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"hatredCofficient", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float hatredCofficient
    {
      get { return _hatredCofficient; }
      set { _hatredCofficient = value; }
    }
    private int _delAddStatus = (int)-1;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"delAddStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int delAddStatus
    {
      get { return _delAddStatus; }
      set { _delAddStatus = value; }
    }
    private bool _initiative = default(bool);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"initiative", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool initiative
    {
      get { return _initiative; }
      set { _initiative = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"Type")]
    public enum Type
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NONE", Value=0)]
      NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HURT", Value=1)]
      HURT = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GAIN", Value=2)]
      GAIN = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEBUFFS", Value=4)]
      DEBUFFS = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LIMIT", Value=8)]
      LIMIT = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HURT_LIMIT", Value=5)]
      HURT_LIMIT = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GAIN_LIMIT", Value=10)]
      GAIN_LIMIT = 10
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"Status")]
    public enum Status
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"STATUS_NONE", Value=0)]
      STATUS_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HP", Value=1)]
      HP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MANA", Value=2)]
      MANA = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PROPERTY", Value=3)]
      PROPERTY = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SILENCE", Value=4)]
      SILENCE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FEAR", Value=5)]
      FEAR = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MOVESPEED", Value=6)]
      MOVESPEED = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RIDESPEED", Value=7)]
      RIDESPEED = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DIZZINESS", Value=8)]
      DIZZINESS = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FREEZE", Value=9)]
      FREEZE = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INVISIBLE", Value=10)]
      INVISIBLE = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"IMMUNE", Value=11)]
      IMMUNE = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GOD", Value=12)]
      GOD = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SKILL", Value=13)]
      SKILL = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DISPEL", Value=14)]
      DISPEL = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SNEER", Value=15)]
      SNEER = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHIELD", Value=16)]
      SHIELD = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HPCONTROL", Value=17)]
      HPCONTROL = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TOXIC", Value=18)]
      TOXIC = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TETANIC", Value=19)]
      TETANIC = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HATRED", Value=20)]
      HATRED = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SLEEP", Value=21)]
      SLEEP = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DAMAGE_BONUS", Value=22)]
      DAMAGE_BONUS = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEFENSIVE_BONUS", Value=23)]
      DEFENSIVE_BONUS = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PUSH_PULL", Value=24)]
      PUSH_PULL = 24
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AllStatusUnits")]
  public partial class AllStatusUnits : global::ProtoBuf.IExtensible
  {
    public AllStatusUnits() {}
    
    private readonly global::System.Collections.Generic.List<StatusUnit> _units = new global::System.Collections.Generic.List<StatusUnit>();
    [global::ProtoBuf.ProtoMember(1, Name=@"units", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<StatusUnit> units
    {
      get { return _units; }
    }
  
    private AllStringID _stringID = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"stringID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public AllStringID stringID
    {
      get { return _stringID; }
      set { _stringID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StatusInfo")]
  public partial class StatusInfo : global::ProtoBuf.IExtensible
  {
    public StatusInfo() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _desc = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private int _effect = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"effect", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int effect
    {
      get { return _effect; }
      set { _effect = value; }
    }
    private int _model = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"model", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int model
    {
      get { return _model; }
      set { _model = value; }
    }
    private string _action = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"action", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string action
    {
      get { return _action; }
      set { _action = value; }
    }
    private StatusInfo.Pos _effPos = StatusInfo.Pos.FEET;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"effPos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(StatusInfo.Pos.FEET)]
    public StatusInfo.Pos effPos
    {
      get { return _effPos; }
      set { _effPos = value; }
    }
    private StatusUnit.Type _type = StatusUnit.Type.NONE;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(StatusUnit.Type.NONE)]
    public StatusUnit.Type type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _dispelPriority = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"dispelPriority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int dispelPriority
    {
      get { return _dispelPriority; }
      set { _dispelPriority = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _units = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(11, Name=@"units", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> units
    {
      get { return _units; }
    }
  
    private int _rate = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"rate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int rate
    {
      get { return _rate; }
      set { _rate = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"Pos")]
    public enum Pos
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"FEET", Value=0)]
      FEET = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BODY", Value=1)]
      BODY = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HEAD", Value=2)]
      HEAD = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AllStatuses")]
  public partial class AllStatuses : global::ProtoBuf.IExtensible
  {
    public AllStatuses() {}
    
    private readonly global::System.Collections.Generic.List<StatusInfo> _statuses = new global::System.Collections.Generic.List<StatusInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"statuses", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<StatusInfo> statuses
    {
      get { return _statuses; }
    }
  
    private AllStringID _stringID = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"stringID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public AllStringID stringID
    {
      get { return _stringID; }
      set { _stringID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}