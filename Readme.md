<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/153616220/18.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830506)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WinForms Accordion Control - Custom filter UI

This example creates a custom filter control and assigns it to the [AccordionControl.FilterControl](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraBars.Navigation.AccordionControl.FilterControl.property) property to filter accordion items:

```csharp
this.accordionControl1.FilterControl = this.customFilterControl1;
```

![Custom FilterContrel](HelpResources/Custom.png)


## Files to Review

* [CustomFilterControl.cs](./CS/WindowsFormsApp7/CustomFilterControl.cs) (VB: [CustomFilterControl.vb](./VB/WindowsFormsApp7/CustomFilterControl.vb))
