# Dmytro_Taran
## A branch with Selenium task code

### Requirements
1. .NET 3.1 Core
2. Visual Studio 2019
3. SpecFlow for Visual Studio 2019 (you also will need an account on SpecFlow.com to run the tests)
4. Selenium.WebDriver
5. Selenium.Firefox.WebDriver

### How to run
1. Clone repository to your device
2. Go to WebUI branch
3. Run SeleniumHomeTask/SeleniumHomeTask.sln file 
4. Build the solution

### Run from command line
1. Clone repository to your device
2. Go to WebUI branch
3. Run SeleniumHomeTask/SeleniumHomeTask.sln file 
4. Open Command Prompt
5. Run *dotnet test [Folder where you cloned project]\Feature\SeleniumTask\bin\Debug\netcoreapp3.1\SeleniumTask.dll*

### Report
1. Clone repository to your device
2. Go to WebUI branch
3. Run SeleniumHomeTask/SeleniumHomeTask.sln file 
4. Intall LiveDoc from this guide https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html
5. Open Command Prompt
6. Run *livingdoc feature-folder [Folder where you cloned project]\Feature\SeleniumTask\bin\Debug\netcoreapp3.1\SeleniumTask.dll -t [Folder where you cloned project]\Feature\SeleniumTask\bin\Debug\netcoreapp3.1\TestExecution.json*

### Additional info
1. All of the object files used in this project are located under /SeleniumHomeTask folder
2. Page object design pattern was used to create objects
3. Feature files are located under Features/SeleniumTask/Features folder
4. Steps definitions are located under Features/SeleniumTask/Steps

Have a good day! ^_^
