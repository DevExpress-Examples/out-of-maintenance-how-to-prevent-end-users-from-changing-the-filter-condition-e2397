<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/HowToCancelFilterChange/Form1.cs) (VB: [Form1.vb](./VB/HowToCancelFilterChange/Form1.vb))
<!-- default file list end -->
# How to prevent end-users from changing the filter condition


<p>The following example shows how to prevent end-users from changing the filter condition.</p><p>In this example, the FieldFilterChanging event is handled to prevent an end-user from hiding the 'Beverages' field value. If an end-user tries to hide the 'Beverages' field value, the event handler sets the event parameter's Cancel property to true to cancel changing the filter condition.</p>

<br/>


