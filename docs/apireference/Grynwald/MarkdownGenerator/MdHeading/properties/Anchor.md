﻿# MdHeading.Anchor Property

**Declaring Type:** [MdHeading](../index.md)

Gets or sets the HTML anchor for this heading.        

```csharp
public string Anchor { get; set; }
```

## Property Value

string

## Remarks

The HTML anchor can be used for linking to a heading within a page.

Property is initialized with an auto\-generated value derived from the heading text by removing all punctuation, replacing spaces with dashes and converting the text to lower case.

The anchor does not include the leading '\#' required for links.

Note: Text anchors are not part of the CommonMark spec so linking to this anchor might not work in  every markdown implementation. To explicitly include an anchor tag in the output, set [HeadingAnchorStyle](../../MdSerializationOptions/properties/HeadingAnchorStyle.md) to Tag.

___

*Documentation generated by [MdDocs](https://github.com/ap0llo/mddocs)*
