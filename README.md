# Blazor-treeview-entity-framework
A quick getting started project to create an Entity Framework application with Blazor TreeView component. The Blazor TreeView is a graphical user interface Component that allows you to represent hierarchical data in a tree structure. It has great performance combined with advanced features like load on demand, checkbox support, multiple selection, tree navigation, drag and drop, tree node editing, and template support.

## Project pre-requisites
Make sure that you have the compatible versions of Visual Studio Code and .NET Core SDK 3.1.2 in your machine before starting to work on this project.

## How to run this application?
To run this application, you need to first clone the `Blazor-treeview-entity-framework` repository and then open the project or solution file in Visual Studio 2019. 

* Need to change the Database connection string in Shared/DataAccess/DataContext.cs

```
 optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\blazor\TreeView-EntityFramework\SQLTreeView\Shared\App_Data\NORTHWND.MDF';Integrated Security=True;Connect Timeout=30");

```

* Now, run the run the project Visual Studio and able to get the output in Browser.