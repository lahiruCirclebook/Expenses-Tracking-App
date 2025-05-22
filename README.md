# Expense Tracker

A modern expense tracking web application built with ASP.NET Core MVC, Entity Framework Core, and Syncfusion UI components. The app allows users to manage categories, record transactions, and visualize their financial data with interactive charts and grids.

## Features

- **Category Management**: Create, edit, and delete income/expense categories with icons.
- **Transaction Management**: Add, edit, and delete transactions, assign them to categories, and add notes.
- **Dashboard**: Visual summary of income, expenses, and balance for the last 7 days.
- **Charts**: 
  - Doughnut chart for expense breakdown by category.
  - Spline chart for daily income vs. expense trends.
- **Recent Transactions**: Quick view of the latest transactions.
- **Responsive UI**: Built with Bootstrap 5 and Syncfusion controls for a modern, mobile-friendly experience.
- **Validation**: Server-side and client-side validation for all forms.

## Tech Stack

- **.NET 8** / **ASP.NET Core MVC**
- **Entity Framework Core** (SQL Server)
- **Syncfusion EJ2** UI components
- **Bootstrap 5**
- **Font Awesome** icons

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or compatible SQL Server)
- Visual Studio 2022 (recommended)

### Setup

1. **Clone the repository:**
2. **Configure the database:**
   - Update the connection string in `appsettings.json` if needed:
3. **Apply migrations and create the database:**
4. **Run the application:**
   Or use Visual Studio's "Start Debugging" (F5).
5. **Access the app:**
   - Open your browser and navigate to `https://localhost:5001` (or the port shown in the console).

## Project Structure

- `Controllers/` - MVC controllers for Categories, Transactions, and Dashboard.
- `Models/` - Entity models and DbContext.
- `Views/` - Razor views for all pages.
- `wwwroot/` - Static files (CSS, JS, images).
- `Migrations/` - Entity Framework Core migrations.

## Customization

- **Syncfusion License**: Syncfusion components require a free community or commercial license. See [Syncfusion Licensing](https://www.syncfusion.com/kb/2326/how-to-generate-syncfusion-license-key) for details.
- **UI Theme**: Change the Syncfusion theme in `_Layout.cshtml` by updating the CSS link.

## Screenshots

> _Add screenshots of the dashboard, category, and transaction pages here._

## License

This project is licensed under the MIT License.

---

**Credits:**  
- [Syncfusion](https://www.syncfusion.com/) for UI components  
- [Bootstrap](https://getbootstrap.com/)  
- [Font Awesome](https://fontawesome.com/)


   
   
