# Quiet Attic Films - Production Database

## Overview
Quiet Attic Films is a film production company based in London, England, specializing in short informational films and television advertisements. This database system is designed to efficiently manage and organize their productions, clients, locations, properties, and staff assignments.

## Features

- **Client Management**: Stores details of clients, allowing each client to have multiple productions.
- **Production Tracking**: Each production is linked to a client and consists of various components like locations, properties, and staff.
- **Location Management**: Keeps records of where productions take place.
- **Property Tracking**: Manages all properties (e.g., buildings, costumes, and props) used in a production.
- **Staff Assignments**: Maintains records of staff types assigned to productions.
- **Relational Database Design**: Ensures all entities (clients, productions, locations, properties, and staff) are well-structured and connected.

## Technologies Used

- **MySQL** (or another relational database system) for database management
- **PHP** for back-end interaction (if applicable)
- **HTML/CSS/JavaScript** for front-end (if a web-based interface is included)

## Database Schema

### Tables:
1. **Clients** (`client_id`, `name`, `contact_info`, `email`)
2. **Productions** (`production_id`, `client_id`, `title`, `description`, `start_date`, `end_date`)
3. **Locations** (`location_id`, `production_id`, `address`, `city`, `country`)
4. **Properties** (`property_id`, `name`, `description`, `category`)
5. **Production_Properties** (`production_id`, `property_id`, `location_id`)
6. **Staff** (`staff_id`, `name`, `role`, `contact_info`)
7. **Production_Staff** (`production_id`, `staff_id`, `role`, `assigned_date`)

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Sandyy68/Quiet-Attic-Films-Production-Database.git
