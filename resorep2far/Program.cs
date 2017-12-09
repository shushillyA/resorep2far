using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace resorep2far
{
    class Program
    {
        static Dictionary<string, string> resoToFAR = new Dictionary<string, string>();

        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                string folderPath = args[0];
                int count = 0;
                
                InitKeys();
                
                foreach (string key in resoToFAR.Keys)
                {
                    string ddsFile = Path.Combine(folderPath, key);
                    if (File.Exists(ddsFile))
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(ddsFile, resoToFAR[key]);
                        Console.WriteLine(string.Format("{0} <-> {1}", ddsFile, resoToFAR[key]));
                        count++;
                    }
                }

                if(count == 0)
                {
                    Console.WriteLine("No files were replaced.");
                }
                else
                {
                    Console.WriteLine(string.Format("Replaced {0} files", count));
                }
            }
            else
            {
                Console.WriteLine("Usage: resorep2far {Texture Directory}");
                Console.WriteLine("Example: resorep2far C:\\Steam\\steamapps\\common\\NieRAutomata\\FAR_Res\\inject\\textures");
            }
        }

        static void InitKeys()
        {
            resoToFAR.Add("4294948969.dds", "04B54A16.dds");
            resoToFAR.Add("55245.dds", "9FE8CD9B.dds");
            resoToFAR.Add("72783.dds", "5B9E01BE.dds");
            resoToFAR.Add("1582983.dds", "2F20F8F2.dds");
            resoToFAR.Add("4265363328.dds", "CCDBA0C3.dds");
            resoToFAR.Add("4276294089.dds", "DB4E3F5B.dds");
            resoToFAR.Add("4282253727.dds", "A006408A.dds");
            resoToFAR.Add("4287763300.dds", "702E924F.dds");
            resoToFAR.Add("4291696353.dds", "69B699C9.dds");
            resoToFAR.Add("4292224047.dds", "3F7B855A.dds");
            resoToFAR.Add("4294451650.dds", "539158E6.dds");
            resoToFAR.Add("543545.dds", "2476FC78.dds");
            resoToFAR.Add("657439.dds", "87F0B90C.dds");
            resoToFAR.Add("1230913.dds", "65EE8175.dds");
            resoToFAR.Add("4289117691.dds", "C276DF30.dds");
            resoToFAR.Add("4292223498.dds", "5C08BF45.dds");
            resoToFAR.Add("4293315797.dds", "A1853C20.dds");
            resoToFAR.Add("4290421554.dds", "0637A441.dds");
            resoToFAR.Add("1572397.dds", "FB3F6D1F.dds");
            resoToFAR.Add("2101031.dds", "D34B210D.dds");
            resoToFAR.Add("4293858212.dds", "295346A0.dds");
            resoToFAR.Add("5213282.dds", "ED81C1F3.dds");
            resoToFAR.Add("2835480.dds", "353E20A3.dds");
            resoToFAR.Add("4293073871.dds", "4AC695AA.dds");
            resoToFAR.Add("1401399.dds", "669C85FD.dds");
            resoToFAR.Add("19129190.dds", "79799417.dds");
            resoToFAR.Add("2111783.dds", "B08FE0A4.dds");
            resoToFAR.Add("4289905153.dds", "A8A6B7E7.dds");
            resoToFAR.Add("4342784.dds", "BFC89861.dds");
        }
    }
}
