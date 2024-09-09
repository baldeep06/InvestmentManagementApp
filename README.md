Investment Management App
This project is a full-stack investment management system developed using C#, SQL, and .NET. The app allows users to manage their financial portfolios in real-time, integrating live stock data and providing a secure interface for updating and maintaining their investments.

Features
Dynamic CRUD Functionality: Users can Create, Read, Update, and Delete stock entries in their portfolio, managing their investments with ease.
Real-Time Data Integration: Fetch live stock data (open and close prices) for multiple tickers through the Alpha Vantage API, allowing users to track market trends with up to 500 API requests daily.
Secure Authentication: Implemented security protocols using an SQL Database, protecting user credentials and investment data.
Intuitive UI Design: Designed a 7-page user interface with seamless navigation, making the app easy to use for users managing multiple financial instruments.
Techniques and Skills
C# and .NET Programming: The entire application is built using C# and .NET, leveraging the framework for full-stack development.
SQL Database Management: SQL is used to handle user data, stock portfolios, and secure login information.
API Integration: The Alpha Vantage API is utilized to fetch real-time stock prices and display them within the app.
Security and Authentication: SQL-based user authentication ensures that all sensitive data is encrypted and stored securely.
User Interface Design: The app includes a visually appealing and user-friendly interface designed to optimize the user experience.
How to Run the App
Ensure the Following are Installed:

Visual Studio with .NET support.
SQL Server for managing the database.
An API key from Alpha Vantage (you can get one here).
Clone the Repository:

bash
Copy code
git clone https://github.com/yourusername/investment-management-app.git
Configure the API:

Add your Alpha Vantage API key to the configuration settings within the app.
Run the Application:

Open the project in Visual Studio.
Ensure that your database connection string is correctly configured.
Build and run the app to start managing your investments.
Use the App:

Log in with your credentials.
Enter stock tickers and view live prices.
Create, update, or delete portfolio entries to manage your investments.
