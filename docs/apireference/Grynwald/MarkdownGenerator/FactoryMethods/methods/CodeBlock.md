﻿# FactoryMethods.CodeBlock Method

**Declaring Type:** [FactoryMethods](../index.md)

## Overloads

| Signature                                            | Description                                                                                  |
| ---------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| [CodeBlock(string)](#codeblockstring)                | Creates a new instance of [MdCodeBlock](../../MdCodeBlock/index.md) with the specified text. |
| [CodeBlock(string, string)](#codeblockstring-string) | Creates a new instance of [MdCodeBlock](../../MdCodeBlock/index.md).                         |

## CodeBlock(string)

Creates a new instance of [MdCodeBlock](../../MdCodeBlock/index.md) with the specified text.

```csharp
public static MdCodeBlock CodeBlock(string text);
```

### Parameters

`text`  string

The code blocks content

### Returns

[MdCodeBlock](../../MdCodeBlock/index.md)

## CodeBlock(string, string)

Creates a new instance of [MdCodeBlock](../../MdCodeBlock/index.md).

```csharp
public static MdCodeBlock CodeBlock(string text, string infoString);
```

### Parameters

`text`  string

The code blocks content

`infoString`  string

The code blocks info string, typically used to indicate the language of the code block

### Returns

[MdCodeBlock](../../MdCodeBlock/index.md)

___

*Documentation generated by [MdDocs](https://github.com/ap0llo/mddocs)*