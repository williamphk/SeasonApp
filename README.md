# SeasonApp

This repo is to demonstrate the use of Regular Controller, API Controller, View (with CSS) and Model for a ASP.NET application

It will take an input of the temperature and output a webpage associated with season and related information. You can run the project by clicking F5 on your computer or the green play button.

Key Files for this Project:
- Models/Season.cs: A class that stores details about a season, such as its name and an associated URL of the image.
- Controllers/SeasonAPIController.cs: A API controller that handles the main logic. It accepts temperature input and returns a season object.
- Controllers/SeasonController.cs: A controller that establishes a connection between views. It accepts temperature data and generates a webpage for the corresponding season.
- Views/Season/Index.cshtml: A view that creates a webpage to allows the user to input temperature.
- Views/Season/Show.cshtml: A view that creates a webpage to display the season's image and name on a webpage.
