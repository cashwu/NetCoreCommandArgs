using System;
using McMaster.Extensions.CommandLineUtils;

namespace testCommand
{
    class Program
    {
        static int Main(string[] args)
        {
            return CommandLineApplication.Execute<Program>(args);
        }

        [Option(Description = "subject")]
        public string Subject { get; set; }
        
        [Option(Description = "nn")]
        public int Count { get; set; }

        private void OnExecute()
        {
            var name = Prompt.GetString("what's ur name ?");

            Console.WriteLine($"==== ur name is {name} =====");
            
            var subject = Subject ?? "Hello World";

            Console.WriteLine(subject);
            Console.WriteLine(Count);
        }
        
        // dotnet testCommand.dll -help
        // dotnet testCommand.dll -s cash -c 123
    }
}