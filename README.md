# Dmytro_Taran
## A branch with WebApi task code

### Requirements
1. .NET 3.1 Core
2. Visual Studio 2019
3. SpecFlow for Visual Studio 2019 (you also will need an account on SpecFlow.com to run the tests)

### How to run
1. Clone repository to your device
2. Go to WebApi branch
3. Run WebApi/WebApi.sln file 
4. Build the solution

### Run more command line
1. Clone repository to your device
2. Go to WebApi branch
3. Run WebApi/WebApi.sln file 
4. Open Command Prompt
5. Run *dotnet test [Folder where you cloned project]\Feature\WebApiFeature\bin\Debug\netcoreapp3.1\WebApiFeature.dll*

### Report
1. Clone repository to your device
2. Go to WebApi branch
3. Run WebApi/WebApi.sln file 
4. Intall LiveDoc from this guide https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html
5. Open Command Prompt
6. Run *livingdoc feature-folder [Folder where you cloned project]\Feature\WebApiFeature\bin\Debug\netcoreapp3.1\WebApiFeature.dll -t [Folder where you cloned project]\Feature\WebApiFeature\bin\Debug\netcoreapp3.1\TestExecution.json*

### Additional info
1. All of the object files used in this project are located under /WebApi folder
2. Factory design pattern was used to create objects
3. Feature files are located under Feature/WebApiFeature/Features folder
4. Steps definitions are located under Feature/WebApiFeature/Steps
5. File which gets uploaded to the Dropbox is located under WebApi/bin/Debug/netcoreapp3.1/FileName.txt 

Have a good day! ^_^
