﻿# DefaultTextFormatter Class

**Namespace:** [Grynwald.MarkdownGenerator](../index.md)

**Assembly:** Grynwald.MarkdownGenerator

Default implementation of [ITextFormatter](../ITextFormatter/index.md).

```csharp
public sealed class DefaultTextFormatter : ITextFormatter
```

**Inheritance:** object → DefaultTextFormatter

**Implements:** [ITextFormatter](../ITextFormatter/index.md)

## Remarks

DefaultTextFormatter escapes all characters with a function in the Markdown syntax             using a backslash.

## Fields

| Name                           | Description                                         |
| ------------------------------ | --------------------------------------------------- |
| [Instance](fields/Instance.md) | Gets the singleton instance of DefaultTextFormatter |

## Methods

| Name                                        | Description                 |
| ------------------------------------------- | --------------------------- |
| [EscapeText(string)](methods/EscapeText.md) | Escapes the specified text. |

___

*Documentation generated by [MdDocs](https://github.com/ap0llo/mddocs)*
