# <a id="DSLApp1_Dsl_InvokeEffectIR"></a> Class InvokeEffectIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record InvokeEffectIR : EffectIR, IEquatable<EffectIR>, IEquatable<InvokeEffectIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EffectIR](DSLApp1.Dsl.EffectIR.md) ← 
[InvokeEffectIR](DSLApp1.Dsl.InvokeEffectIR.md)

#### Implements

[IEquatable<EffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<InvokeEffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[EffectIR.Subject](DSLApp1.Dsl.EffectIR.md\#DSLApp1\_Dsl\_EffectIR\_Subject), 
[EffectIR.EffectType](DSLApp1.Dsl.EffectIR.md\#DSLApp1\_Dsl\_EffectIR\_EffectType), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_InvokeEffectIR__ctor_DSLApp1_Dsl_Subject_DSLApp1_Dsl_InvokeMechanic_"></a> InvokeEffectIR\(Subject, InvokeMechanic\)

```csharp
public InvokeEffectIR(Subject Subject, InvokeMechanic InvokeMechanic)
```

#### Parameters

`Subject` [Subject](DSLApp1.Dsl.Subject.md)

`InvokeMechanic` [InvokeMechanic](DSLApp1.Dsl.InvokeMechanic.md)

## Properties

### <a id="DSLApp1_Dsl_InvokeEffectIR_InvokeMechanic"></a> InvokeMechanic

```csharp
public InvokeMechanic InvokeMechanic { get; init; }
```

#### Property Value

 [InvokeMechanic](DSLApp1.Dsl.InvokeMechanic.md)

