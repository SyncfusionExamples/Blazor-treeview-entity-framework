# Blazor TreeView Entity Framework Integration

## Overview

This sample demonstrates how to populate a Syncfusion [Blazor TreeView](https://www.syncfusion.com/blazor-components/blazor-treeview) using data stored in a SQL Server database and accessed through Entity Framework. The application uses a database-backed hierarchical data source to render nodes in the TreeView component, allowing developers to manage and display relational data in a structured tree format. The sample is useful for applications that require navigation structures, category hierarchies, organizational trees, or database-driven parent-child relationships.

## Key Features

- Uses `SfTreeView` to display hierarchical data.
- Uses `SfContextMenu` to expose node editing actions.
- Handles node interactions through `NodeClickEventArgs`.
- Retrieves the next available record identifier from `api/Default/index`.
- Uses `tree.AddNodes()` to dynamically create child nodes.
- Uses `tree.RemoveNodes()` to delete selected nodes.
- Uses `tree.BeginEdit()` to rename existing nodes.
- Maintains selected node information through the TreeView node UID.
- Demonstrates integration between Blazor UI components and Entity Framework-backed data services.
- Supports hierarchical parent-child record relationships.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework
- SQL Server LocalDB
- Entity Framework
- Syncfusion Blazor components
- Access to the sample database used by the project

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution file:

   `SQLTreeView.sln`

3. Restore all NuGet packages.
4. Set the startup project to:

   `SQLTreeView`

5. Open the following file and update the database connection string as required:

   `Shared/DataAccess/DataContext.cs`

6. Ensure the referenced SQL Server database is available.
7. Build the solution.
8. Run the application using `Ctrl+F5`.
9. Open the application URL displayed by Visual Studio after launch.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the project directory.

```bash
cd SQLTreeView
```

4. Restore NuGet packages.

```bash
dotnet restore
```

5. Run the project.

```bash
dotnet run
```

6. Open the local URL displayed in the terminal.
7. Verify that data from the configured database is displayed in the TreeView component.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Official documentation: https://blazor.syncfusion.com/documentation/treeview/getting-started

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
