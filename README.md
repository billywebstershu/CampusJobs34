# CampusJobs34 - MySQL Setup Guide for Developers (Windows)

This guide provides step-by-step instructions on how to set up a MySQL server on a Windows machine for local development of the CampusJobs34 project. 

## Step 1: Install MySQL Server

1.  **Download MySQL Installer:**
    *   Go to the official MySQL website: [https://dev.mysql.com/downloads/installer/](https://dev.mysql.com/downloads/installer/)
    *   Download the "MySQL Installer for Windows."  Choose the online or offline installer based on your preference. The offline installer is larger but contains all necessary files.

2.  **Run the Installer:**
    *   Execute the downloaded installer.
    

3.  **Setup Type:**
    *   The installer will ask you to choose a setup type. For development purposes, select "Developer Default". This installs MySQL Server, MySQL Shell, MySQL Router, MySQL Workbench, connectors, and other development tools.
        *   MySQL Server
        *   MySQL Workbench (optional but highly recommended)
        *   MySQL Shell (optional)

5.  **Installation:**
    *   Click "Execute" to begin the installation process.  This may take some time.

## Step 2: Configure MySQL Server

1.  **Configuration Type:**
    *   After the installation, the MySQL Server Configuration wizard will launch.
    *   Choose "Development Computer" as the configuration type. This is suitable for development environments and uses minimal resources.

2.  **Networking:**
    *   Leave the default port as `3306`.
    *   Ensure "Open Windows Firewall port for network access" is checked.

3.  **Authentication Method:**
    *   For the purpose of our prototype, we are using a simple password, so select no for password authentication, the password can be found in the repo.

4.  **Root Account Password:**
    *   Enter a strong and memorable password for the `root` user.  **Important:** Store this password securely, You'll need it to manage your MySQL server.
    *   Optionally, you can add additional MySQL user accounts at this stage.  However, we'll create a specific user for the CampusJobs34 project later.

5.  **Windows Service:**
    *   Configure MySQL Server to start automatically when Windows starts. This is usually the default setting and is convenient for development.

6.  **Apply Configuration:**
    *   Click "Execute" to apply all the configuration settings.  This might take a few minutes.

7.  **Finish:**
    *   Click "Finish" to complete the configuration.

## Step 3: Create the CampusJobs34 Database

There are multiple ways to accomplish this.  I recommend using MySQL Workbench, as it provides a graphical interface.

### Option 1: Using MySQL Workbench (Recommended)

1.  **Launch MySQL Workbench:**
    *   Open MySQL Workbench from the Start Menu.

2.  **Connect to the Server:**
    *   Click the "+" button to add a new connection.
    *   Enter a connection name (e.g., "Local MySQL Server").
    *   Set the hostname to `127.0.0.1` or `localhost`.
    *   Set the port to `3306`.
    *   Enter `root` as the username.
    *   Click "Store in Keychain..." and enter the root password you set during configuration.
    *   Click "Test Connection" to verify the connection. If successful, click "OK".
    *   Double-click the newly created connection to connect to the MySQL server.

3.  **Create the Database:**
    *   Click the "Create a new schema" icon in the toolbar .
    *   Enter `campusjobs34` as the schema name.
    *   Set the Collation to `utf8mb4_unicode_ci`.
    *   Click "Apply" and then "Finish".

4.  **Import Tables (Optional, if you have a SQL dump):**
    *   If you have a `.sql` file containing the database schema (can be found in the db folder), you can import it.
    *   Go to `File` -> `Open SQL Script...` and select the `.sql` file.
    *   Click the "Execute" button to run the script and create the tables.  The `sql_queries.sql` file contains the table creation scripts.

### Option 2: Using MySQL Shell

1.  **Launch MySQL Shell:**
    *   Open MySQL Shell from the Start Menu.

2.  **Connect to the Server:**
    ```
    mysqlsh --host=localhost --port=3306 --user=root --password
    ```
    *   Enter the root password when prompted.

3.  **Create the Database:**
    ```
    CREATE DATABASE campusjobs34 CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
    USE campusjobs34;
    ```

4.  **Import Tables (Optional, if you have a SQL dump):**
    ```
    SOURCE path/to/your/sql_queries.sql;  // Replace path/to/your/sql_queries.sql with the actual path
    ```

## Step 4: Create a User for the Application

Since we need a user login for the mvc application to connect to, we must create a new user.

### Using MySQL Workbench:

1.  **Navigate to Users and Privileges:**
    *   In MySQL Workbench, in the Navigator panel, click on "Administration" then "Users and Privileges".

2.  **Add Account:**
    *   Click "Add Account".

3.  **Login Information:**
    *   Enter `remote_user` as the Login Name.
    *   Set the Authentication Type to "Standard".
    *   Enter `password` as the password.

4.  **Schema Privileges:**
    *   Go to the "Schema Privileges" tab.
    *   Select the `campusjobs34` schema.
    *   Grant the following privileges: `SELECT`, `INSERT`, `UPDATE`, `DELETE`, `CREATE`, `DROP`, `ALTER`. (Allows us to view and alter data from our web application.)
    *   Click "Apply".

### Using MySQL Shell:

1.  **Connect to the Server (as root):** (See instructions in previous step)

2.  **Create the User and Grant Privileges:**
    ```
    CREATE USER 'remote_user'@'localhost' IDENTIFIED BY 'password';
    GRANT ALL PRIVILEGES ON campusjobs34.* TO 'remote_user'@'localhost';
    FLUSH PRIVILEGES;
    ```

## Step 5: Configure the Application

1.  This should aready be done in main, however if 'appsettings.json' is incorrect, please use the code below:
    ```
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=campusjobs34;User ID=remote_user;Password=password;"
      },
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
        }
      },
      "AllowedHosts": "*"
    }
    ```

    *   Ensure the `Server`, `Database`, `User ID`, and `Password` values are correct.

## Step 6: Test the Connection and Verify Data Display

1.  **Run the Application:**
    *   Build and run the `CampusJobsProject - Group 34` application in Visual Studio.

2.  **Verify Data Access:**
    *   Navigate to the home page, as of the writing of this document there should be a message verifying the successful connection to the database.
    *   In the future however, other indicaters will be populated tables containing user data for example.

3.  **Database Connection Error:**
    *    Error Display: If there's a database connection error, the application may display an error message. 

    
    

## Troubleshooting

*   **Connection Refused:**
    *   Ensure the MySQL server is running. Check the Windows Services Manager (`services.msc`).
    *   Verify the port number in the connection string is correct (usually `3306`).
    *   Check the Windows Firewall to ensure port `3306` is open for MySQL.

*   **Authentication Errors:**
    *   Double-check the username and password in the connection string.
    *   Make sure the user account has the necessary privileges for the `campusjobs34` database.

*   **Missing MySQL Connector:**
    *   The `.csproj` file includes the necessary MySQL connector packages:
        ```
        <PackageReference Include="Microsoft.EntityFrameworkCore" Version="9.0.2" />
        <PackageReference Include="MySql.Data" Version="9.2.0" />
        <PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="8.0.2" />
        ```
    *   Ensure these packages are correctly installed by restoring the NuGet packages for the solution.


