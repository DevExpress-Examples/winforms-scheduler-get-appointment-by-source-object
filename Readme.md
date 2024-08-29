<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128635662/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3143)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Scheduler - Obtain appointments by an object in the data source

The [PersistentObject.GetSourceObject](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraScheduler.PersistentObject.GetSourceObject(DevExpress.XtraScheduler.ISchedulerStorageBase)) method allows you to obtain a source object that corresponds to a specific appointment. This example shows how to obtain an appointment by an object in the data source.

The example handles the [SchedulerStorageBase.AppointmentCollectionLoaded](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraScheduler.SchedulerStorageBase.AppointmentCollectionLoaded) event to create a Hashtable/Dictionary where source objects are keys and appointments are values.

For recurring patterns, you should iterate through exceptions using the [Appointment.GetExceptions]() method.


## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-scheduler-get-appointment-by-source-object&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-scheduler-get-appointment-by-source-object&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
