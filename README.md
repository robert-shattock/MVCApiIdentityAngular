# MVCApiIdentityAngular
This repository contains a full stack solution using MVC, Web API, Identity, Angular and SQL Server

It has been published to Azure for testing but depending on when you view this it may not be available: https://dutchtreat20200709102749.azurewebsites.net/

This website was built while following along with the Pluralsight course **Building a Web App with ASP.NET Core, MVC, Entity Framework Core, Bootstrap, and Angular by Shawn Wildermuth**

A brief summary of the course is as follows:
> ASP.NET Core is a mature, stable platform for developing web applications and APIs. This course will walk you through building a web app from scratch using ASP.NET Core 3.0, Visual Studio, Entity Framework Core 3.0, Bootstrap 4, and Angular (v8)

More info can be found here: [https://app.pluralsight.com/library/courses/aspnetcore-mvc-efcore-bootstrap-angular-web](https://app.pluralsight.com/library/courses/aspnetcore-mvc-efcore-bootstrap-angular-web)

The Dutch Treat website is an MVC website for all views except for the Shop and for the web APIs.  The shop pages have been created using Angular.  There is a SQL Azure database backing the website.

The course material was originally written for ASP.NET Core 2.1 I believe and then updated to ASP.NET Core 3.0... but not all the course material has been
updated appropriately, and libraries and frameworks and .NET Core itself has obviously progressed on since even the course update.

I've used ASP.NET Core 3.1, EF Core 3.1.3, Bootstrap 4.5 and Angular 10.0.2

Overall the course (while frustrating because of the gaps between when it was written and how things are now) was a great example showing the core concepts
for building an end to end web app using some key technologies.  It paired back things to basics to give you an understanding of how everything works from
setting up the middleware pipeline, to setting up MVC controllers and views, basic HTML, CSS and JS concepts, expanded to cover bootstrap and TypeScript and
how they relate, repository pattern with EF, dependency injection, Web API, standard responses, authentication and authorization with cookies and JWT, Angular
components and services, publishing to a server or Azure etc.  As with any course it's a lot to cover and is more intended to make you aware of what's
possible so you can then go out and find out more information on each area as required.

Some screenshots in case the website isn't running in Azure:

Dutch Treat Shop Page (Angular)

![Dutch Treat Shop Page](/DutchTreatShop.JPG)

Dutch Treat Checkout Login Page (Angular)

![Dutch Treat Login Page](/DutchTreatLogin.JPG)

Dutch Treat Checkout Page (Angular)

![Dutch Treat Checkout Page](/DutchTreatCheckout.JPG)

Dutch Treat Shop Page (MVC - readonly)

![Dutch Treat MVC Shop Page](/DutchTreatMVCShop.JPG)

Dutch Treat Contact Page (MVC)

![Dutch Treat Contact Page](/DutchTreatContact.JPG)
