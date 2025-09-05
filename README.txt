For the projects to run correctly, you will have to store both projects locally on your computer
and create a reference to SimpleDB from Chirp.CLI
This is done because we want to make Chirp.CLI dependent of SimpleDB.

When you clone your SimpleDB, make sure to clone it so that it is in the same folder as your cloned Chirp.CLI. 
This is due to when referring to SimpleDB, which stored locally,just as Chirp.CLI is, it is required
to have both the projects within the same folder to create the reference.

After you have put both projects within same folder stored on your computer. You will have to build SimpleDB. This is due to Chirp.CLI being dependent of SimpleDB to work.

Building can be done through the terminal running the code: dotnet build