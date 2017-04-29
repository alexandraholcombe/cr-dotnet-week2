"Son of Cod" Seafood Company Website
=========================

**By Alexandra Holcombe**  
Webpage built with .NET Core using Entity Framework migrations, SQL Server, and Identity Authentication.  Individual project for Week 2 of Epicodus .NET module.

_Go to route localhost.#/admin/register to create initial admin account_
_Additional styling and features added post-deadline.  View branch before-due for one day product.

## Planning
### **1.  Configuration/Dependencies**  
  * .NET Core
  * Entity Framework
  * Identity Authorization Framework

### **2.  Specs**  
  * CRUD Admin
  * Admin can CRUD subscribers
  * Anon visitors can create a subscribers
  * No duplicate subscribers
  * Admin can CRUD page content

### **3.  Integration**  

 **Models**  
  * admin (email, password, name?)
  * subscriber (email, location, reasonForSubscribing)

  **Views**
  * Newsletter page
    > Admin: sees current mailing list  
    > Anon: sees newsletter signup  
  * Home/Landing page
    > Admin: sees forms to edit page
    > Anon: sees static page

### **4.  UX/UI**  
  * Uses Bootstrap
  * Styling inspired by [Pacific Seafood](https://www.pacseafood.com/)

### **5.  Polish**  
  * See if refactoring is needed
  * Delete unused code
  * Revisit README

***

## Installation

### Requirements
* Microsoft .NET Core Tools (Preview 2)
* (If using Visual Studio) Visual Studio 2015 Update 3

[Microsoft .NET Core 1.0.0 Release Notes](https://github.com/dotnet/core/blob/master/release-notes/1.0/1.0.0.md)  
[Release Announcement](https://blogs.msdn.microsoft.com/dotnet/2016/06/27/announcing-net-core-1-0/)

### To Build Database
In command line:  
    > dotnet ef database update


## Technologies Used
* C#
* Visual Studio 2015 Update 3
* Entity Framework 1.0.0 Preview 2
* .NET Core 1.0.0 Preview 2 003131
* Microsoft SQL Server Management Studio
* Identity User Authentication

## Support and contact details
Please contact Allie Holcombe at alexandra.holcombe@gmail.com with any questions, concerns, or suggestions

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe_**
