<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620898/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T380359)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms LookupEdit - Filter a standalone lookup based on a value in another lookup

This example demonstrates how to implement cascading lookups. When a user selects a category in the first lookup, the second lookup filters its items to display only products that match the selected category.

Use the secondary lookup’s [CascadingOwner](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.LookUpEditBase.CascadingOwner) property to specify the primary lookup. Lookups use an internal algorithm that identifies a key field in a data source. The algorithm checks the names of data objects, the key attributes, and the data type of the primary keys. The algorithm is based on a common naming convention of key fields (for example, `ID`, `Key`, and `OID`).

```csharp
lookUpEdit2.CascadingOwner = lookUpEdit1;
```

> **Note**
>
> The `CascadingOwner` property is supported only for standalone lookup editors. Read the following help topic for information on how to create cascading in-place lookups: [Cascading Lookups](https://docs.devexpress.com/WindowsForms/116018/controls-and-libraries/editors-and-simple-controls/lookup-editors/cascading-lookups).


## Files to Review

* [Form1.cs](./CS/Lookup-Cascading/Form1.cs) (VB: [Form1.vb](./VB/Lookup-Cascading/Form1.vb))


## Documentation

* [Lookup Editors](https://docs.devexpress.com/WindowsForms/116008/controls-and-libraries/editors-and-simple-controls/lookup-editors)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-cascading-standalone-lookups&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-cascading-standalone-lookups&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
