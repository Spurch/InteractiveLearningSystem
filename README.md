# Interactive Learning System project

## Current status
  - Ongoing development.
  - Database models - currently stable with some ideas for future changes.
    - DB Diagram ![alt tag](https://raw.githubusercontent.com/Spurch/InteractiveLearningSystem/master/docs/dbSchema.jpg).
  - Administration panel and functionalities under development - 70/80% ready :)
  - Some common/shared functionalities ready.
  - Messaging system - working.
  - Layout menus are partial based and ajax loaded.
  - Common layout menus are customized on user role basis.
  - Kendo Grid and Autocomplete added and partialy customized.
  - Database filtration based on user role&id ready.
  - Panels for the other users are still at 20-25% ready :(
  - Planing to add UnitOfWork pattern in the near future.
  - Custom 403 page for unauthorized access to different areas.
  - Custom 404 page for resource not found for the details pages.
  - Logic for generating random data for dev/test purposes(There is an open issue to move this into a separate project for further development)

## Project Overview
  The Interactive Learning System (ILS for short) is an idea I have been considering for some time. On its current stage/level my idea is to implement a simple/basic system for creating and managing Schools, Groups and User accounts with different roles, views, functions etc. Some basic functionality for messaging, CRUD for Tasks, Problems, Answers etc. 
  For the future the ILS will support a logging system and a functionality to store history records for the students/teachers activity.
  
## Project Architecture
  - 7 Projects.
    - 3 Test projects.
    - Data project.
    - Database models project.
    - Services project.
    - Web project.
  - 9 Database models.
    - User
    - School
    - Group
    - Image
    - Log
    - Answer
    - Problem
    - Prolem statistics
  - Dedicated services for accessing the Database context.
  - Custom ViewModels for CRUD operations.
  - Implemented Repository pattern.
  - 5 Areas
    - Separate area for each user role.
    - Some common features separated in a Common area.
    - Very litte public/unauthroized access pages.
  
## Details
  - Used technologies:
    - ASP .NET MVC
    - EntityFramework
    - SQL Server
    - Ninject
    - Automapper
    - Boostrap
    - jQuery
    - Unobtrusive Ajax for ASP NET MVC
    - HtmlSanitizer
    - Kendo UI for MVC
    
## Summary
  - Project requirements can be found [here](https://github.com/TelerikAcademy/ASP.NET-MVC/tree/master/Final%20Project/2016)
  - The ILS uses/requires some additional assets like:
    - Kendo UI for ASP .NET MVC.
    - Images and other graphics.
    - Others.
    - Those assets have pending licence agreements hence are property of their respective owners and are not included in this repo.
    - NOTE: The project won't behave as expected without those assets.

