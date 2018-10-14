using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CatUnitStudio
{
    public class GccRunnetClass
    {

        Process cmd;
        public GccRunnetClass()
        {
            cmd = new Process();
            cmd.StartInfo = new ProcessStartInfo(@"cmd.exe");
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
        }

        public void SendCommand(string command)
        {
            cmd.StandardInput.WriteLine(command);
        }


        public string ReceiveAnswer()
        {
            if (cmd.StandardOutput.BaseStream.CanRead == true)
            {
                return cmd.StandardOutput.ReadLine();
            }
            else
            {
                return "";
            }

        }
    }
}
