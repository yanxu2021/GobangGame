# GobangGame (MSSA Project SD9)
>ASP.NET web application for Gobang online game.
>Gobang is a two-player abstract strategy game generally played with Go pieces(either in black or white color) on a 15*15 Go board. Also know by the name Five in a Row.
>It is a traditional oriental game, originally from China. 
>Black plays first, and players alternate in placing the Go piece of their color on an empty intersection. 
>The winner is the first player to get an unbroken row of five Go pieces horizontally, vertically, or diagonally.

## Table of contents
* [Step 1 Concept Investigation](#Step1)
* [Step 2 Project Selection](#Step2)
* [Step 3 Concept Presentation](#step3)
* [Step 4 Database Conceptual Design](#step4)
* [Step 5 Database Entity (ERD) Design](#step5)
* [Step 6 Interface Elements](#step6)
* [Step 7 Requirements & Use Case](#step7)
* [Step 8 Test Planning & RTM](#step8)
* [Step 9 Application Prototype](#step9)
* [Step 10 In-Process Review (IPR)](#step10)
* [Step 11 Model Classes](#Step11)
* [Step 12 Data Integration](#Step12)
* [Step 13 Sprint Planning](#Step13)
* [Step 14 Sprint Review](#Step14)
* [Step 15 Sprint Execution](#Step15)

## Step11
<p>Working from the design, and implement the data model components of the project using Entity Framework to map the classes to the database table entities and the tables to the classes.</p>
<p>Deliverable requirements:
  <ul>
    <li>Project folders for Models,Views, and Controllers.</a></li>
    <img src="https://github.com/yanxu2021/GobangGame/blob/master/ScreenShots/1Folders%20for%20MVC.JPG">
    <li><a href="https://github.com/yanxu2021/GobangGame/tree/master/GobangGame/Models">Within Models folder-C# class files which describe and map to database table entities</a></li>
    <li><a href='https://github.com/yanxu2021/GobangGame/blob/master/GobangGame/Models/IGameRepository.cs'>Develop the interface.</a></li>
    <li>The primary data model, which the data model implements.</li>
    <li>Create a "Fake" or "TestDouble"class which also implements the data interface.</li>
    <li>Auto-generate a databse diagram.</li>
    <img src="https://github.com/yanxu2021/Gobang-Game-With-Computer/blob/main/Gobang%20Game%20ERD.JPG">
    </ul>
  </p>
  
## Step12
<p>The project database tables and model classes are connected. Using code, connect to the database and create a controller and simple view which displays data read from tables and enables data taken from a simple user interface and storing the new or modified data back to the databse.</p>
<p>Deliverable requirements:
  <ul>
    <li>Screenshot of SSMS showing data stored in tables</li>
    <img src="https://github.com/yanxu2021/GobangGame/blob/master/ScreenShots/9.JPG">
    <img src="https://github.com/yanxu2021/GobangGame/blob/master/ScreenShots/17%20View%20Tabels.JPG">
    <li>Screenshot of application view showing data retrieved from the database and displayed on the page.</li>
       <img src="https://github.com/yanxu2021/GobangGame/blob/master/ScreenShots/12.JPG">
    <li>Screenshot of the application demonstrating how the data is collected from the application(a form?).</li>
       <img src="https://github.com/yanxu2021/GobangGame/blob/master/ScreenShots/17%20View%20Tabels.JPG">
    <li>Screenshot of the view showing how the data has changed.</li>
       <img src="https://github.com/yanxu2021/GobangGame/blob/master/ScreenShots/13.JPG"> 
    </ul>
  </p>

## Step13
<p>Accordingly,plan the remaining work and the upcoming sprint starting with creating the formal prioritized product backlog items(PBIs) in the project repository.</p>
<p>Deliverable requirements:
  <ul>
    <li><a href="">From the issues tab in GitHub, add new issues. A well-constructed issue contain: A user story/Acceptance criteria/Additional supporting information such as diagrams, descriptions, screen captures, error messages, etc.</a></li>
    <li><a href="">Create a project board from the repository and add prioritized issues from the backlog. ToDo/InProcess/Done.</a></li>
    </ul>
  </p>

## Step14

Sprint plan(Backlog updated)
<p>Use the EF Database First with ASP.NET MVC approach to create the Gobang Game web application.</p>
<ui>Task 1 Create an ASP.NET web application with Visual Studio and set up the database.</ui>
<ui>Task 2 Generate the models.</ui>
<ui>Task 3 Generate the Views</ui>
<ui><li>Add scaffold.</li>
<li>Add links to new views.</li>
<li>Display game views.</li>
<li>Display record views.<li><ui>
Task 4 change the database.
1.	Add a column.
2.	Add the property to the views.
Task 5 Customize view.
1.	Add record detail page.
2.	Confirm that new record added to the page.
Task 6 Enhance data validation.
1.	Add data annotations.
2.	Add metadata classes.
Task 7 Deploy Gobang Game app to Azure with Azure SQL Database
1.	Within Visual Studio solution Explorer-publish to Azure as target.
2.	Sign in and add an app.
3.	Configure the web app name.
4.	Create a resource group.
5.	Create an App service plan.
6.	Create a server and database.
7.	Configure database connection.
8.	Deploy Gobang Game app.
Task 8 Access the database locally.
1.	Create a database connection.
2.	Configure the database connection.
3.	Create a new firewall to allow client connection.
Task 9 Update app with Code First Migration.
1.	Update data model.
2.	Run Code First Migrations locally.
3.	Use the new property.
4.	Enable Code First Migrations in Azure.
5.	Publish changes.
Task 10 Stream application logs.
1.	Enable log streaming.
2.	Change trace levels.
3.	Stop log streaming.
Task 11 Manage Azure app.



## Step15

## Contact
Created by [@yanxu2021](https://www.linkedin.com/in/yanxu2021/) - feel free to contact me!
