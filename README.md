# **Pierre Bakery Vendor and Order Tracker**
### This is a web application in order to track order details pertaining to vendors of Pierre Bakery

 ### _Contributor(s) and Contact Info_
> Logan Roth diamondintheroth@gmail.com - [GitHub(Lo-GR)](https://github.com/Lo-GR)

<br/>

## _Technologies Used_

* **C# 9**
* **.NET 5.0.102**
* **SDK 8.0.19**
* **MS Test**
* **Razor**
* **Bootstrap 4.5**
* **HTML 5 (CS version)/CSS3**

## _Concepts Used_

* **MVC**
* **TDD**

## _Description_
This MVC webpage will present it's user with a splash screen and options to view current vendor orders. Both vendors and orders have separate webpage views and will be explorable by various links. The user is able to navigate to a new form for entering new vendors into the webpage. When navigating in the vendor pages, the user can then create a new order with various details pertaining to it. The orders will be associated with the vendors and kept within the vendors pages. 

This is a practice project for practicing C#, Razor, ASP .NET framework, and MVC for a course at Epicodus.

## _Use Guide and Installation_

> Repository: https://github.com/Lo-GR/PeirreBakery2.git
1. In your terminal of choice or [GitHub's Desktop Application](https://desktop.github.com/) , clone the above repository from Github. For further explanation on how to clone this repository, please visit [GitHub's Documentation](https://docs.github.com/en/github/using-git/which-remote-url-should-i-use).
2. Ensure you are running .NET Core SDK by using the command dotnet --version in your terminal. If a version number is not presented, please visit [this download page for .NET 5 and install the applicable software for your OS](https://dotnet.microsoft.com/download/dotnet/5.0). 
3. Once you verify you are running a .NET 5, navigate in your terminal to PierreBakery2 directory within the PierreBakery2.Solution directory you just cloned. Once there, run "dotnet build" in your terminal to build application within directory. 
4. In your terminal, while still in PierreBakery2 directory, run "dotnet restore" and then "dotnet run." The terminal will present local host routes for you to navigate to in your browser. An example would be "http://localhost:5000." Enter this into a web browser of choice to use this application. Keep the terminal running as it is being used to control the local server.
5. When finished, exit the terminal or use the command "CTRL C"(Windows) or "CMD C"(Mac) to shut down the local server.
6. Open the PierreBakery.Solution directory in a text editor of your choice to view the code.

To engage with testing regarding this application, please read below.

### _Testing Guide_
1. Navigate to the PierreBakery2.Tests directory within your terminal. Once there, run the command "dotnet restore" in order restore the required features for testing.
2. "dotnet test" will test the Models programmed in PierreBakery2.

## _Known Bugs_
* No known bugs at this time. Please contact a contributor to report any bugs found during use.

## _Future Updates_
* Additional UI
* A feature to edit or remove Orders
* A feature to edit or remove Vendors and all associated Orders

## _Preplanning/Whiteboard Work_
```
Objectives/Expectations___
- Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
- Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
- The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.
- The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.
- Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
- Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".

Functionality___
- Vendor Class Constructor that holds Name, and List of Order objects belonging to vendor.
- Order Class Constructor that includes Title, Description, Price, Date. Stored in Vendor Constructor.
- Vendor class objects housed in static list.
- Set may not be necessary without update feature

DateTime in c#___
- " create an object of the DateTime struct using the new keyword. The following creates a DateTime object with the default value. "
//assigns year, month, day
DateTime dt2 = new DateTime(2015, 12, 31); 
- Throws error if dates out of range, verify cshtml can lock valid dates.

https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-5.0

User Interface___
- Homepage splashpage that includes a link to Vendors Page.
- Vendor Page should include link to new form.
- New form page should return to homepage.
- Vendor page should include links to each Vendor's page.
- Vendor's page lists Orders housed in Vendor.
- Vendor's page should include a link to new Order Form.
- New order form should return to Vendor's Page.
```

## _License_

[_MIT_](https://opensource.org/licenses/MIT)

Copyright (c) 2021, Logan Roth.

Please contact Contributor for further use information or if you would like to make a contribution.