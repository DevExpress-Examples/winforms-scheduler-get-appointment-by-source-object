<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128635662/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3143)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to obtain appointments based on the source data object


<p><strong>Problem:</strong> There is a <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerPersistentObject_GetSourceObjecttopic"><u>PersistentObject.GetSourceObject Method</u></a> that allows retrieving a source object, associated with a specified appointment. However, there is no "reverse" method that allows retrieving an appointment by the source object which might be useful in some scenarios.<br />
<strong>Solution:</strong> The most efficient method to implement this functionality is to build a Hashtable/Dictionary with source objects as keys and appointments as values. This can be done in the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerSchedulerStorageBase_AppointmentCollectionLoadedtopic"><u>SchedulerStorageBase.AppointmentCollectionLoaded Event</u></a> handler. Note that for recurring patterns, you should iterate through their exceptions manually (use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerAppointment_GetExceptionstopic"><u>Appointment.GetExceptions Method</u></a> to obtain exceptions of the specified appointment).</p><p><strong>See also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E792">How to get XtraScheduler synchronized with XtraGrid</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E1249">How to obtain a particular appointment from the Appointments collection that meets the specified criteria</a></p>

<br/>


