<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication24/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication24/Form1.vb))
* [MyXtraTabbedMdiManager.cs](./CS/WindowsFormsApplication24/MyXtraTabbedMdiManager.cs) (VB: [MyXtraTabbedMdiManager.vb](./VB/WindowsFormsApplication24/MyXtraTabbedMdiManager.vb))
<!-- default file list end -->
# Custom XtraTabbedMdiManager - How to enable XtraTabbedMdiManager to draw page images with a specific size


<p>This sample illustrates how to change page images sizes to a specified one. This functionality is especially actual when being used with the <i>UseFormIconAsPageImage</i> property. To introduce it, we created an XtraTabbedMdiManager descendant and provided it with two additional properties. The <strong>UseDefaultPageImageSize</strong> property controls whether this functionality is enabled. The <strong>PageImageSize</strong> property sets the page images size. When the <i>UseDefaultPageImageSize</i> property is set to true, the <i>PageImageSize</i> property values are ignored.</p>

<br/>


