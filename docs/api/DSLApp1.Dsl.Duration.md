# <a id="DSLApp1_Dsl_Duration"></a> Class Duration

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record Duration : IEquatable<Duration>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Duration](DSLApp1.Dsl.Duration.md)

#### Implements

[IEquatable<Duration\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_Duration__ctor_DSLApp1_Dsl_DurationType_System_Int32_System_Nullable_DSLApp1_Dsl_TimingEvent__"></a> Duration\(DurationType, int, TimingEvent?\)

```csharp
public Duration(DurationType DurationType, int Amount, TimingEvent? TimingEvent = null)
```

#### Parameters

`DurationType` [DurationType](DSLApp1.Dsl.DurationType.md)

`Amount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`TimingEvent` [TimingEvent](DSLApp1.Dsl.TimingEvent.md)?

## Properties

### <a id="DSLApp1_Dsl_Duration_Amount"></a> Amount

```csharp
public int Amount { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Dsl_Duration_DurationType"></a> DurationType

```csharp
public DurationType DurationType { get; init; }
```

#### Property Value

 [DurationType](DSLApp1.Dsl.DurationType.md)

### <a id="DSLApp1_Dsl_Duration_TimingEvent"></a> TimingEvent

```csharp
public TimingEvent? TimingEvent { get; init; }
```

#### Property Value

 [TimingEvent](DSLApp1.Dsl.TimingEvent.md)?

