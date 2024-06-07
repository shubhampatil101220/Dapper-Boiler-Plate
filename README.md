# Steps to Create a .NET Web API

## 1. Open Visual Studio 2022
- Launch Visual Studio 2022 from your desktop or start menu.

## 2. Create ASP.NET Core Web API
- Click on **"Create a new project"**.
- Search for **"ASP.NET Core Web API"** and select it.
- Click **"Next"**.
- Configure your project details (e.g., project name, location, solution name).
- Click **"Create"**.
- Choose the **".NET Core"** and **"ASP.NET Core 8.0"** framework.
- Click **"Create"**.

## 3. Remove Weather Forecast Controller
- Open **Solution Explorer**.
- Navigate to the **Controllers** folder.
- Delete the **WeatherForecastController.cs** file.

## 4. Add BAL & DAL (Business Access Layer & Data Access Layer)
- In **Solution Explorer**, right-click on your project.
- Click **"Add"** > **"New Project"**.
- Select **"Class Library"**.
- Click **"Next"**.
- Name the project ending with **.BAL** (e.g., `MyProject.BAL`).
- Click **"Create"**.
- Repeat the above steps to add another class library project, but this time end the name with **.DAL** (e.g., `MyProject.DAL`).

## 5. Add NuGet Packages
- Right-click on the **Solution** in Solution Explorer.
- Select **"Manage NuGet Packages for Solution..."**.
- Go to the **"Browse"** tab.
- Search for the following packages and install them in the respective projects:

### For both BAL & DAL:
1. **Dapper**
   - Search for `Dapper`.
   - Click **"Install"**.

2. **Microsoft.Data.SqlClient**
   - Search for `Microsoft.Data.SqlClient`.
   - Click **"Install"**.

3. **System.Data.SqlClient**
   - Search for `System.Data.SqlClient`.
   - Click **"Install"**.

## Additional Configuration (If needed)
- Configure your **appsettings.json** for database connections.
- Add necessary services and configurations in **Startup.cs** or **Program.cs**.

## Conclusion
- You have now set up the basic structure of your .NET Web API with separate BAL and DAL layers, and necessary NuGet packages.
