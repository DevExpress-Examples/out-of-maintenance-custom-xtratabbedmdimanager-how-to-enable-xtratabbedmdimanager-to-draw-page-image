<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128615789/10.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3172)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication24/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication24/Form1.vb))
* [MyXtraTabbedMdiManager.cs](./CS/WindowsFormsApplication24/MyXtraTabbedMdiManager.cs) (VB: [MyXtraTabbedMdiManager.vb](./VB/WindowsFormsApplication24/MyXtraTabbedMdiManager.vb))
<!-- default file list end -->
# Custom XtraTabbedMdiManager - How to enable XtraTabbedMdiManager to draw page images with a specific size


<p>This sample illustrates how to change page images sizes to a specified one. This functionality is especially actual when being used with the <i>UseFormIconAsPageImage</i> property. To introduce it, we created an XtraTabbedMdiManager descendant and provided it with two additional properties. The <strong>UseDefaultPageImageSize</strong> property controls whether this functionality is enabled. The <strong>PageImageSize</strong> property sets the page images size. When the <i>UseDefaultPageImageSize</i> property is set to true, the <i>PageImageSize</i> property values are ignored.</p>

<br/>


