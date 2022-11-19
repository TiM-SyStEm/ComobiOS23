using System;
using System.IO;
using Sys = Cosmos.System;

namespace ComobiOS23.src.System
{
    internal class FileSystem
    {
        private Sys.FileSystem.CosmosVFS FS;
        public FileSystem() 
        {
            try
            {
                FS = new();
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(FS);
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.DriveFormat != "FAT32")
                    {
                        IOsteram.OutLN("[not FAT32]", ConsoleColor.Red);
                    }
                    IOsteram.OutLN("[DONE]", ConsoleColor.Green);
                }
            }
            catch(Exception) 
            {
                IOsteram.OutLN("[FS INIT ERROR]", ConsoleColor.Red);
            }
        }
    }
}
