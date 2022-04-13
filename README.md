<div id="top"></div>

<br />
<div align="center">
  <h3 align="center">README</h3>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

Clean Architecture core building blocks are:
- Application Core
- Infrastructure
- UI Application

In general business, logic depends on the data access layer or infrastructure layer. But in clean architecture data access layers or infrastructure layers depend on the business logic layer (the Application Core).

### Application Core:
Application Core contains `Entities`, `DTOs`, `Interfaces`, and the `Business Logic`

The `Domain` part of the project contains `Entities` (table entities) and the `Application` part of the project contains `DTOs`, `Interfaces`, `Business Logic`.

The `Domain` part can be shared with other projects as well since it is the parent of layers.

This is helpful when using the `Entities` (Driver, Car, Trip) in the Consumer / Producer Microservice.

### Infrastructure:
Infrastructure deals with `DataBases`. Infrastructure depends on the 'Interface' inside of the 'Application Core'.

### UI Application:
UI Application uses the `Application Core` to produce the results. UI Application does not depend on the infrastructure layer, but we refer the infrastructure layer into the UI project in the case of the services dependency injection. Used Swagger UI for the interaction with the ‘Application Core’.


### Project Structure:

| | |
|---|---|
|Catalog |Project for controllers, mapping between domain model and API model, API configuration   |
|Catalog.Entities   |Project Entities (Models)  |
|Catalog.Dtos   |Clients should not see or interact with Entities. So Dtos help in transferig data to/from remote (out of the process).   |
|Catalog.Controllers  |Handles incoming HTTP requests and send response back to the caller |
|Catalog.Repositories  |Hides the details of how exactly the data is saved or retrieved from the database. The details of how the data is stored and retrieved is in the respective repository for each entity |

### Driver Table Schema -

|   |type   |nullable   |
|---|---|---|
|id |string($uuid)   |   |
|name   |string   |true   |
|number   |string   |true   |

---

### Car Table Schema -

|   |type   |nullable   |
|---|---|---|
|car_id |string($uuid)   |   |
|cord   |string   |true   |
|speed   |double   |   |

---

### Trip Table Schema -

|   |type   |nullable   |
|---|---|---|
|trip_id |string($uuid)   |   |
|car_id   |string($uuid)   |true   |
|driver_id   |string($uuid)   |   |
|dest   |string   |   |

---

* The Drivwe Database has all the driver data stored, which is exposed to the internet using a RESTful API.
* The RESTful API allows other users to carry out CRUD operations on the database.

|Opoeration   |Http Request   |
|---|---|
|Create |Post   |
|Retrieve   |Get   |
|Update   |Put   |
|Delete   |Delete   |

* Run `dotnet new webapi -n Catalog` to create the WebApi template.

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started

### Installation

* Run the docker file to setup PostgrSQL database and PGAdmin
  ```sh
  docker-compose up -d
  ```
* Go to this url to login to PGAdmin http://localhost:5050/login use the credentials that are there in the docker file.
Email: `pgadmin4@pgadmin.org` and Password: `admin1234`.
* Connect to the database, by right clicking to Servers and then click Create then Server.
Put the name as `ProductsDb`.
* In Connection tab fill the fields with these values - 
  * Host name: postgresql_database
  * Port: 5432
  * database: productsDb
  * Username: admin
  * Password: admin1234
* Run `dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 5.0.2` to install Entity Framework for PostgreSQL.
* Run `dotnet tool install --global dotnet-ef` to install dotnet-ef tool.
* Run `dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.5`.
* Run `dotnet ef database update` to update the database.
* Do `dotnet run` to run the project and navigate to https://localhost:5001/swagger/index.html.

<p align="right">(<a href="#top">back to top</a>)</p>



