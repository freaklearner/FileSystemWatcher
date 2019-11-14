using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Watcher Test: ");
            var wtch = Run(@"C:\Users\instaclickuser\Desktop\Json_Location\watcherLoc\");
            while (Console.Read() != 'q')
            {

            }
            wtch.Dispose();
        }

        private static FileSystemWatcher Run(string path)
        {
            string args = Path.GetFullPath(path);
            FileSystemWatcher watcher = new FileSystemWatcher();
           
            watcher.Path = args;

            watcher.NotifyFilter = NotifyFilters.Size;

            watcher.Filter = "*.*";

            watcher.Changed += (s, e) => change(s, e, path);

            watcher.EnableRaisingEvents = true;

            return watcher;

            
        }

        private static void change(object source, FileSystemEventArgs e, string path)
        {

        }
    }
}
