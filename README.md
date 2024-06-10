# Blazor-Test-2024

*Code Test: BlazorApp-DisplayColors from an API*

## Overview

This is a .NET 8.0 Blazor Web App.
It already has the backend code added to get some JSON color data.
Your challenge is to add a page to display the color data.

- Unzip directory
- Use Visual Studio 2022 **or** VS-Code (both apps are free)
  - VS-2022 is easier than VS-Code, only because when you have the ASP.NET and web development workload installed, that is all you need.
  - VS-Code requires a couple of C# Extensions and a few other things. If you skip over the prompts to get the needed extensions, it's harder to search and find what you need.
- Run and Debug
  - Once you have the app running, you're ready to add your new page and code.
- Goal: Consume the API and display the results on a new Color page that you build in the app.
  - Add a new navigation item called "Color"
  - Use the WebColorServices interface. This will get JSON data that is HTML colors from the API. 
  - Create a new page 
    - Display the colors and some text data on your new Color page in the app.
  
This will probably take an experienced developer an hour or two to hook this all up.


## Requirements for Visual Studio 2022 (VS-2022)

- Visual Studio 2022 version 17.8 or later. Go to the Visual Studio downloads page (https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) to install it for **free**. 
  - with the **ASP.NET and web development** workload installed. If you need to install the workload and already have Visual Studio, go to Tools > Get Tools and Features..., which opens the Visual Studio Installer. Choose the ASP.NET and web development workload, then choose Modify.


### Run

- Hit F5 or click the green Run button with https selected

Your default browser should open to the app on https://localhost:5001/.
You should see Hello, world! and navigation on the left: Home, Counter, and Weather.

**You are ready to begin the test...** (see Goal below)



## Goal

Consume the API and display the results on a new Color page that you built in the app.

- Create a new Razor component/page called "Colors" to display the colors.
- Add a new navigation item called "Colors" in the left-hand side and link it to your colors page.
- Use the WebColorServices interface. This will get JSON data that is HTML colors from the API. 
  - *Files already exist in this sample app.* Use these files to get the JSON data
  - IWebColorsService.cs
  - WebColorsService.cs
  - WebColors.cs (model that matches the JSON coming from the API)
  - Program.cs (already adds the WebColorsService interface)
- Display the colors and text (like color names or color codes) on your colors page.
  - Try to make it look nice, but don't spend hours formatting and styling it.
  









-----------------------------------------------------

## If you prefer to use Visual Studio Code (VS-Code)

Here's some guidance to use VS-Code instead of Visual Studio 2022 (VS-2022)

### Requirements for VS-Code

If you would rather use VS-Code, download and install the free text editor: https://code.visualstudio.com/download

Then **Open folder...**: BlazorApp-DisplayColor

**When you do, wait and watch for the prompts.**
VS-Code will recognize the app code and prompt you to install any missing tools/extensions that you need to run the project.

#### Install Extensions

If you don't have the extensions installed, VS-Code should prompt you to install the following.
If it doesn't prompt you, click the Extensions button and search and add

- **C#**
- **C# Dev Kit**
- you might need '.NET Install Tool'
- it may install 'Razor Language Server Telemetry'

The first two C# Extensions should be enough to get it started and it may add the other two.

#### VS-Code: Run and Debug

- Click the Run and Debug icon on the left
- Click the `Run and Debug` button
  - Select C# in the drop-down
  - C#:BlazorApp-DisplayColors [Default Configuration]


Your default browser should open to the app on http://localhost:5078.
You should see Hello, world! and navigation on the left: Home, Counter, and Weather.

Then next time you go to debug hit F5 or click the green Start Debugging arrow.

**You are ready to begin the test...** See *Goal* section above.

-----------------------------------------------------
