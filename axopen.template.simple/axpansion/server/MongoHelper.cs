namespace axosimple.server
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    public class MongoHelper
    {       
        public static bool IsMongodRunning()
        {
            // Get all processes with the name "mongod"
            var mongodProcesses = Process.GetProcessesByName("mongod");

            // If any process with the name mongod is found, it is already running
            return mongodProcesses.Any();
        }
    }

}
