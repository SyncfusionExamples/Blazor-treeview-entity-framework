# Blazor-treeview-entity-framework

**Repository Description**  
This repository contains a quick getting‑started Blazor sample that demonstrates how to build an Entity Framework–backed application using the Syncfusion Blazor TreeView component.

The Syncfusion Blazor TreeView component provides a graphical user interface for representing hierarchical data in a tree structure. It offers high performance along with advanced features such as load‑on‑demand, checkbox support, multiple selection, tree navigation, drag‑and‑drop, tree node editing, and template customization.

## Project Overview
The purpose of this project is to help developers understand how to integrate the Syncfusion Blazor TreeView component with Entity Framework to display hierarchical data from a database. It showcases how database‑driven data can be visualized in a structured tree format within a Blazor application.

## Features
- Integration of the Syncfusion Blazor TreeView component  
- Entity Framework–based data binding  
- Display hierarchical data in a tree structure  
- Load‑on‑demand support for large datasets  
- Checkbox, selection, and tree navigation features  
- Drag‑and‑drop and node editing capabilities  
- Template customization for tree nodes  

## Prerequisites
Ensure the following requirements are met before running this project:
- Visual Studio Code or Visual Studio 2022 (with the .NET 10 workload)
- .NET 10 SDK
- SQL Server LocalDB  

## Installation and Running the Application

### Clone and Open the Project
1. Clone the repository.
2. Open the solution file (SQLTreeView.sln) in Visual Studio 2022 or Visual Studio Code.

### Configure the Database Connection
By default, the sample connects to SQL Server LocalDB using the `SQLTreeView/Shared/App_Data/NORTHWND.MDF` file, resolved relative to the repository — no path changes are needed after cloning.

Connection details are configured in `Shared/DataAccess/OrganizationContext.cs`. To use a different SQL Server (e.g. SQL Server in Docker or a remote instance) without editing code, set the `TreeViewConnectionString` environment variable before running:
```bash
TreeViewConnectionString="Server=localhost,1433;Database=NORTHWND;User Id=sa;Password=YourPassword;TrustServerCertificate=True;Connect Timeout=30"
```
### Run the Application
1. Build the solution.
2. Run the project in Visual Studio.
3. Open the application in the browser to view the TreeView rendered with data from the database.

## Usage
Run the application to explore how hierarchical data from Entity Framework is displayed using the Blazor TreeView. You can expand nodes, load data dynamically, interact with checkboxes, and perform drag‑and‑drop operations.

## Documentation
- General Syncfusion documentation:
https://help.syncfusion.com/
- Blazor Introduction:
https://blazor.syncfusion.com/documentation/introduction
- Blazor TreeView Getting Started:
https://blazor.syncfusion.com/documentation/treeview/getting-started

## Troubleshooting
- Ensure the NORTHWND.MDF file exists at `SQLTreeView/Shared/App_Data/NORTHWND.MDF`.
- Verify that SQL Server LocalDB is installed and accessible (or set `TreeViewConnectionString` to point at another SQL Server).
- Rebuild the solution if Entity Framework or TreeView components fail to load.
- Check browser and application logs for runtime errors.

## Support
For detailed API references, configuration options, and advanced usage examples, refer to the Syncfusion Blazor TreeView documentation links provided above.