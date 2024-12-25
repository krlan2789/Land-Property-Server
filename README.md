# 1. Land-Property-Server

ASP.NET Project - REST API for Land Property Project

## 1.1. **Concepts**

### 1.1.1. Roles and Actions

| No  | Buyer                      | Seller                     |
| --- | -------------------------- | -------------------------- |
| 1   | Create Account             | Create Account             |
| 1   | Manage Account Information | Manage Account Information |
| 2   | Show Active Ads            | Register Ads               |
| 3   | Favorite Ads               | Manage Ads                 |
| 4   | Communication with Seller  | Communication with Buyer   |
| 5   | -                          |                            |
|     |                            |                            |

## 1.2. **Database**

### 1.2.1. Table Users

|     | Name         | Type     |                                   |
| --- | ------------ | -------- | --------------------------------- |
| PK  | **Id**       | int      | Auto-increament                   |
|     | Name         | string   | Length(255)                       |
|     | Email        | string   | Length(128), unique               |
|     | PasswordHash | string   | Length(64)                        |
|     | PhoneNumber  | string   | Length(32), unique                |
|     | Address      | string   | nullable                          |
|     | CreatedAt    | DateTime | Length(20), 'yyyy-MM-dd HH:mm:ss' |
|     | UpdatedAt    | DateTime | Length(20), 'yyyy-MM-dd HH:mm:ss' |

### 1.2.2. Table UserSessionLogs

|     | Name       | Type   |                                   |
| --- | ---------- | ------ | --------------------------------- |
| PK  | **Id**     | int    | Auto-increament                   |
|     | IpAddress  | string | Length(64), nullable              |
|     | UserAgent  | string | nullable                          |
|     | Action     | string | nullable                          |
| FK  | **UserId** | int    |                                   |
|     | CreatedAt  | string | Length(20), 'yyyy-MM-dd HH:mm:ss' |

### 1.2.3. Table PropertyTypes

|     | Name        | Type   |                                   |
| --- | ----------- | ------ | --------------------------------- |
| PK  | **Id**      | int    | Auto-increament                   |
|     | Name        | string | Length(64)                        |
|     | Description | string | nullable                          |
|     | CreatedAt   | string | Length(20), 'yyyy-MM-dd HH:mm:ss' |
|     | UpdatedAt   | string | Length(20), 'yyyy-MM-dd HH:mm:ss' |

### 1.2.4. Table AdvertisementTypes

|     | Name        | Type   |                                   |
| --- | ----------- | ------ | --------------------------------- |
| PK  | **Id**      | int    | Auto-increament                   |
|     | Name        | string | Length(64)                        |
|     | Description | string | nullable                          |
|     | CreatedAt   | string | Length(20), 'yyyy-MM-dd HH:mm:ss' |
|     | UpdatedAt   | string | Length(20), 'yyyy-MM-dd HH:mm:ss' |

### 1.2.5. Table Properties

|     | Name                    | Type     |                                   |
| --- | ----------------------- | -------- | --------------------------------- |
| PK  | **Id**                  | int      | Auto-increament                   |
|     | Title                   | string   | Length(255)                       |
|     | Address                 | string   |                                   |
|     | BuildingArea            | float    |                                   |
|     | LandArea                | Vector2  |                                   |
|     | Bedroom                 | byte     |                                   |
|     | Bathroom                | byte     |                                   |
|     | Floor                   | byte     |                                   |
|     | Price                   | ulong    |                                   |
|     | Description             | string   | nullable                          |
|     | Images                  | string[] | nullable                          |
| FK  | **UserId**              | int      |                                   |
| FK  | **BuildingTypeId**      | int      |                                   |
| FK  | **AdvertisementTypeId** | int      |                                   |
|     | CreatedAt               | string   | Length(20), 'yyyy-MM-dd HH:mm:ss' |
|     | UpdatedAt               | string   | Length(20), 'yyyy-MM-dd HH:mm:ss' |

### 1.2.6. Table PropertyViewLogs

|     | Name           | Type   |                                   |
| --- | -------------- | ------ | --------------------------------- |
| PK  | **Id**         | int    | Auto-increament                   |
| FK  | **PropertyId** | int    |                                   |
| FK  | **UserId**     | int    |                                   |
|     | CreatedAt      | string | Length(20), 'yyyy-MM-dd HH:mm:ss' |
