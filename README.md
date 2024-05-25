**SQL Permissions Tester**

Welcome to the **SQL Permissions Tester**! This application is designed
to be a comprehensive tool for testing SQL database permissions. Whether
you're an administrator verifying permissions or a developer checking
database interactions, this tool is perfect for ensuring that your SQL
permissions are correctly configured.

**Features**

-   **Connect to SQL Databases**: Easily connect to SQL databases by
    providing the server, user, password, database, and table details.

-   **Execute Queries**: Run custom SQL queries and view the results
    directly within the application.

-   **Predefined Tests**:

    -   **Select Test**: Quickly run a **SELECT** query on your table to
        check read permissions.

    -   **Insert Test**: Test your insert permissions by attempting to
        insert default/null values into the table.

    -   **Delete Test**: Check delete permissions with a harmless delete
        query.

    -   **Alter Test**: Verify alter table permissions by adding and
        then dropping a test column.

    -   **Database List Test**: List all databases on the connected SQL
        server.

    -   **Table List Test**: List all tables within the specified
        database.

-   **Profile Management**: Load and manage multiple SQL profiles from a
    configuration file (**def.txt**). Switch between profiles
    effortlessly to test different environments.

-   **Connection Management**: Connect and disconnect from databases
    with ease, and receive real-time status updates.

**Installation**

1.  **Clone the repository**:  git clone https://github.com/ahmedosama80/SQL_Perm_Tester.git

2.  **Open the project in Visual Studio**.

3.  **Build and run the application**.

**Usage**

**Loading SQL Profiles**

The application supports loading multiple SQL profiles from a
**def.txt** file. Each profile in the file should be defined in the
following format:

## Profile Name ##

hostname

username

password

databaseName

\[databaseName\].\[schema\].\[tableName\]

**Connecting to a Database**

1.  Enter the server hostname, username, password, database name, and
    table name.

2.  Click the **Connect** button.

3.  Once connected, the status will update to "Connected" and the button
    will turn green.

**Executing Queries**

-   **Select Test**: Click the **Select Test** button to execute a
    **SELECT TOP 5** query.

-   **Insert Test**: Click the **Insert Test** button to attempt
    inserting default values.

-   **Delete Test**: Click the **Delete Test** button to execute a
    harmless delete query.

-   **Alter Test**: Click the **Alter Test** button to add and then
    remove a test column.

-   **Database List Test**: Click the **Database List Test** button to
    list all databases.

-   **Table List Test**: Click the **Table List Test** button to list
    all tables in the database.

**Managing Profiles**

-   Load profiles from the **def.txt** file by clicking the **Refresh
    Profiles** button.

-   Select a profile from the dropdown and click **Load Profile** to
    populate the connection fields with the profile's data. For
    instance, you can switch between "SA" and "User 1" profiles to test
    different permissions and user access.

**Important Warning**

**Warning: This application is potentially dangerous and should be used
with caution. It is strongly recommended to use a test database, as data
loss may occur.**

**Contributing**

We welcome contributions! If you have suggestions for improvements or
want to report a bug, please create an issue or submit a pull request.

**License**

This project is licensed under the MIT License. See the LICENSE file for
details.

Feel free to customize this README to better suit your needs and the
specific details of your application. This draft provides a professional
and enthusiastic overview of your SQL permissions tester, highlighting
its features and usage instructions
