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
            Run(@"C:\Users\instaclickuser\Desktop\Json_Location\watcherLoc");
            while (Console.Read() != 'q')
            {

            }

        }

        private static void Run(string path)
        {
            using(FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = path;

                watcher.NotifyFilter = NotifyFilters.CreationTime;

                watcher.Filter = "*.*";

                watcher.Changed += (s, e) => change(s, e, path);

                watcher.EnableRaisingEvents = true;

            }
        }

        private static void change(object source, FileSystemEventArgs e, string path)
        {

        }
    }
}
