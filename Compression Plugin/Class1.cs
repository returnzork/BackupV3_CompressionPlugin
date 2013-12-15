using System;

using System.ComponentModel.Composition;
using returnzork.BackupV3_API;

using Ionic.Zip;

namespace Compression_Plugin
{
    [Export(typeof(BackupV3API))]
    public class Class1 : BackupV3API
    {

        Settings settings = new Settings();


        public string Author()
        {
            return "Returnzork";
        }

        public void Initialize()
        {
            string libFolder = System.IO.Path.Combine(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\BackupV3\\PluginLib\\");
            if (!System.IO.Directory.Exists(libFolder + "\\Compression"))
                System.IO.Directory.CreateDirectory(libFolder + "\\Compression");
            if (!System.IO.File.Exists(libFolder + "\\Compression\\Ionic.Zip.dll"))
            {
                //TODO extract the file from resources
                using (System.IO.FileStream fs = new System.IO.FileStream(libFolder + "\\Compression\\Ionic.Zip.dll", System.IO.FileMode.CreateNew))
                {
                    System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Compression_Plugin.Ionic.Zip.dll");
                    for(int i = 0; i < stream.Length; i++)
                        fs.WriteByte((byte)stream.ReadByte());
                }
            }
            System.Reflection.Assembly.LoadFrom(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\BackupV3\\PluginLib\\Compression\\Ionic.Zip.dll");
        }

        public void Interface()
        {
            settings_form sf = new settings_form();
            sf.Show();
        }

        public string Name()
        {
            return "Compression";
        }

        public int Priority()
        {
            return 0;
        }

        public TimeToRun RunTime
        {
            get
            {
                return TimeToRun.After;
            }
        }

        public string Version()
        {
            return "1.0.0 indev";
        }

        public void Work(string[] Imports)
        {
            using (ZipFile zip = new ZipFile())
            {
                //index 1 of imports is the world to location
                //index 3 is the name of the world

                zip.ParallelDeflateThreshold = -1;  //fixes the compression never finishing for some reason

                zip.AddDirectory(Imports[1] + Imports[3]);
                zip.Save(Imports[1] + Imports[3] + ".zip");
            }

            if (settings.DeleteUnCompressedWorld)
                if(System.IO.Directory.Exists(Imports[1]))
                    System.IO.Directory.Delete(Imports[1], true);
        }
    }
}