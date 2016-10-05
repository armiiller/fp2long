using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;
using System.Threading;

namespace FP2LongCLI
{
    class Options
    {
        [Option('p', "path", Required = true,
          HelpText = "Directory path to delete")]
        public string Path { get; set; }

        [Option('v', "verbose", DefaultValue = true,
          HelpText = "Prints all messages to standard output.")]
        public bool Verbose { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            System.Console.CancelKeyPress += (s, e) =>
            {
                e.Cancel = true;
                cts.Cancel();
            };

            MainAsync(args, cts.Token).Wait();
        }

        static async Task MainAsync(string[] args, CancellationToken token)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                // Values are available here
                if (options.Verbose) Console.WriteLine("Path: {0}", options.Path);

                var fp2long = new FP2LongCore.File();
                await fp2long.Delete(options.Path);
            }
        }
    }
}
