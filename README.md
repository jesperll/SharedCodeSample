#What is this?

This sample was created as an experiment after Microsoft released [Visual Studio 2013 Update 2 RC](http://www.microsoft.com/en-us/download/details.aspx?id=42307).

The idea is to see if using a shared code project rather than linking files between projects is feasible outside the project templates that comes with Visual Studio (these only support windows and Windows Phone apps) 

The solution contains a shared code project, a portable class library and platform specific libraries for desktop and Windows Phone.

It also contains a nuspec file for building a nuGet package that contains the 3 libraries. Referencing it from a portable library would include the portable library contaning just the classes and methods but no actual implementation. Referencing it from an app would use the platform specific implementation.

## Howto
1.  Create a universal c# project (Windows+WindowsPhone)
2.  Open one of the platform specific projects in notepad and make a copy of the import statement near the end of the file.
    `<Import Project="..\SharedCodeSample.Shared\SharedCodeSample.Shared.projitems" Label="Shared" />`
3.  Delete the platform specific app projects.
4.  Add platform specific (or portable) library project(s)
5.  Open each one in notepad and paste in the import statement at the same location as you copied in from in the other project.
6.  Build

## Good news
- It builds.
- Microsoft is working on making this easier to do (without resorting to hand editing project files)
https://twitter.com/davkean/status/456523129813098497

##Bad news
- ~~If you add a new class to the shared project Visual Studio goes into an infinite loop of trying to open the newly added file for each of the projects. Only way out is to kill it through Task Manager.~~

##Update
The bad news behavior was caused by a bug in VSCommands. Either update to the latest version (12.3.0.6) or disable it.
https://getsatisfaction.com/dpstudio/topics/bug_in_universal_app_project_support_in_vs2013_update_2_rc
http://visualstudiogallery.msdn.microsoft.com/c6d1c265-7007-405c-a68b-5606af238ece