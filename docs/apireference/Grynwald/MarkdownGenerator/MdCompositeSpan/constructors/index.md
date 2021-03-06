﻿# MdCompositeSpan Constructors

**Declaring Type:** [MdCompositeSpan](../index.md)

## Overloads

| Signature                                                                   | Description                                                                                       |
| --------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| [MdCompositeSpan(IEnumerable\<MdSpan\>)](#mdcompositespanienumerablemdspan) | Initializes a new instance of [MdCompositeSpan](../index.md) with the specified inline\-elements. |
| [MdCompositeSpan(MdSpan\[\])](#mdcompositespanmdspan)                       | Initializes a new instance of [MdCompositeSpan](../index.md) with the specified inline\-elements. |

## MdCompositeSpan(IEnumerable\<MdSpan\>)

Initializes a new instance of [MdCompositeSpan](../index.md) with the specified inline\-elements.

```csharp
public MdCompositeSpan(IEnumerable<MdSpan> spans);
```

### Parameters

`spans`  IEnumerable\<[MdSpan](../../MdSpan/index.md)\>

The spans to add to the composite span.

## MdCompositeSpan(MdSpan\[\])

Initializes a new instance of [MdCompositeSpan](../index.md) with the specified inline\-elements.

```csharp
public MdCompositeSpan(params MdSpan[] spans);
```

### Parameters

`spans`  [MdSpan](../../MdSpan/index.md)\[\]

The spans to add to the composite span.

___

*Documentation generated by [MdDocs](https://github.com/ap0llo/mddocs)*
