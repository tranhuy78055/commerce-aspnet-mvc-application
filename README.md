🎬 eTickets - Online Movie Ticket Booking Demo

eTickets is a Blazor-based web application for buying movie tickets online. The application is built using .NET 8 and SQL Server, following Object-Oriented Programming (OOP) principles.

📌  Features

- Browse and search for movies
- View movie details, including description, price, and showtimes
- Book tickets for movies
- Manage user accounts and profiles
- Admin panel for managing movies, cinemas, actors, and producers

🚀  Technologies Used

- **Frontend**: Blazor
- **Backend**: .NET 8
- **Database**: SQL Server
- **Architecture**: Object-Oriented Programming (OOP)

📦 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Docker](https://www.docker.com/get-started) (optional, for running the application in containers)

### Installation

**1. Clone the repository:**
- git clone https://github.com/tranhuy78055/commerce-aspnet-mvc-application.git

**2. Set up the database:**
   Update the connection string in `appsettings.json` to point to your SQL Server instance.
   Run the database migrations to create the necessary tables:  
    - dotnet ef database update
  
**3. Run the application:**
- dotnet run

🐳 **Docker Setup**
**1. Build and run the Docker containers:**
- docker-compose up --build
Download the Docker Compose file [here](https://drive.google.com/file/d/1QC2wD1A8mVTSeZamUANQVBImu_3sDkso/view?usp=drive_link) if you just want to check it out.
- docker-compose up -d


**2. Access the application at `http://localhost:8001/Movies`.**

## Usage

- Navigate to the homepage to browse available movies.
- Click on a movie to view its details and book tickets.
- Use the admin panel to manage movies, cinemas, actors, and producers.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your changes.

## License

This project is licensed under the MIT License.


    
