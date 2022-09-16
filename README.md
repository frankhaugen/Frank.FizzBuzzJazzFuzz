# Frank.FizzBuzzJazzFuzz
A FizzBuzz application meant to be a technical execise

## Part 1
### Architecture
#### Project-dependencies
The architecture is based on the concept that "business logic" should never be aware of the platform or platform features execution of the logic is made from. This is why there is no Console.WriteLine() in the actual code, as it's rearly something you have available as a an actual resource in normal application execution (Web API or Desktop App).

I was contemplating using a "worker" project as the executing app and the inject ILogger and use it for output, but it's a bit over-kill for this application.

It is my optinion that a "clean architecture" means that your business-logic should be seen as Nuget-packages and then a webapi or WPF -app implements that "package", making it highly portable. I also see a Test -project as an Execution so it does not reference Cli -project as "executers" shouldn't be cross dependant.

##### Folder/namespace structure
I believe strongly that many files and folders with sensible naming is the best way to have a good piece of software.

### Patterns
I have not followed any "patterns", as in I have used what is my customary way of coding, and not made a "cookbook" of patterns that define my style in this case. I beleive I mostly write understandable, easy to follow code, and in many cases following patterns will make the code verbose and hard to maintain when doing something like this.

I do recognize that SOLID is a thing that was referenced in the "tasking" but I never bother to actually look "is my code SOLID", and in the case of this kind of application parts of it isn't really applicable.

### Testing
The task said that testing wasn't important but I disagree, as it's much quicker to run tests then it is to debug. I Haven't done TDD here but I should have