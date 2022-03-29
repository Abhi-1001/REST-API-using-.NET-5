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
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
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
