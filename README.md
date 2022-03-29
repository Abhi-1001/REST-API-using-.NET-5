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

<p align="right">(<a href="#top">back to top</a>)</p>



