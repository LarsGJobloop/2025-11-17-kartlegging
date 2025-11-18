Console.WriteLine("Starting Program");

// Services available (setup phase)
var profileService = new ProfileService();

// The actual program flow
var quit = false;
while (!quit)
{
  var userInput = Console.ReadLine();

  if (userInput == null)
  {
    Console.WriteLine("Could not read user input");
    throw new Exception(); // Crash program
  }

  if (userInput == "exit")
  {
    quit = true;
  }

  Console.WriteLine($"User entered: {userInput}");

  // Here you can try figuring out how to make use of the service
  // and have the user fill in what's needed.
  // Mind this is somewhat awkward for this type of CLI (Command Line Interfaces)
  // don't worry to much, frameworks (ex. ASP .NET Web API)
  // helps with this type of setup

  // var registrationInfo = new RegistrationInfo();
  // var result = profileService.RegisterNewProfile(registrationInfo);
}
