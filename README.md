# Bike Store
<!-- ABOUT THE PROJECT -->
## About The Project

This is a project I have been developing in order to familiarise myself with ASP.NET Core MVC and Entity Framework.

<!-- GETTING STARTED -->
## Getting Started
### Prerequisites

* Visual Studio
* SQL Database management software e.g. MS SQL, Azure Data Studio, DBeaver (if you are a Mac with M1 chip user)
* [Link](shorturl.at/sG689) to the database
* Docker (if you are a Mac user)

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/lorchik7/BikeStore-Final.git
   ```
2. After installing Docker pull MSSQL Docker Image
   ```sh
    sudo docker pull mcr.microsoft.com/mssql/server:2019-latest
   ```
3. Run the container (if you are a M1 user see step 4)
   ```sh
    docker run -d --name sql_server_demo -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=reallyStrongPwd123' -p 1433:1433 mcr.microsoft.com/mssql/server:2019-latest
   ```
4. Run the container (for a M1 Chip users)
   ```sh
    docker run -e "ACCEPT_EULA=1" -e "MSSQL_SA_PASSWORD=reallyStrongPwd123" -e "MSSQL_PID=Developer" -e "MSSQL_USER=SA" -p 1433:1433 -d --name=sql mcr.microsoft.com/azure-sql-edge
   ```
5. Install the client tools for sql if you want to query the db from terminal
   ```sh
    sudo npm install -g sql-cli
   ```
6. To log in the db from terminal:
  ```sh
    mssql -u sa -p reallyStrongPwd123
   ```
7. Build and Run the project in Visual Studio

<!-- ROADMAP -->
## Roadmap

- [x] Implement CRUD for stores
- [ ] Implement CRUD for products
- [ ] Login functionality

<!-- CONTRIBUTING -->
## Contributing

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<!-- LICENSE -->
## License

<!-- ACKNOWLEDGMENTS -->
## Acknowledgments
* [DBeaver](https://dbeaver.io/)
<!-- MARKDOWN LINKS & IMAGES -->

