using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboSharp;
using System.IO;

namespace FP2LongCore
{
    public class File
    {
        private string _source;
        private string _destination;
        public string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            return tempDirectory;
        }

        public Task Delete(string dirpath)
        {
            RoboCommand rc = new RoboCommand();
            rc.CopyOptions.Purge = true;
            rc.CopyOptions.Source = _source = GetTemporaryDirectory();
            rc.CopyOptions.Destination = _destination = dirpath;

            rc.OnCommandError += Rc_OnCommandError;
            rc.OnCommandCompleted += Rc_OnCommandCompleted;
            rc.OnFileProcessed += Rc_OnFileProcessed;
            return rc.Start();
        }

        private void Rc_OnFileProcessed(object sender, FileProcessedEventArgs e)
        {
            Console.WriteLine(e.ProcessedFile.Name);
        }

        private void Rc_OnCommandCompleted(object sender, RoboCommandCompletedEventArgs e)
        {
            Console.WriteLine(e.ToString());
            try
            {
                Directory.Delete(_source);
                Directory.Delete(_destination);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void Rc_OnCommandError(object sender, RoboSharp.ErrorEventArgs e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}
