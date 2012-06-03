/**
Copyright (C) 2012 KryptonX.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files
(the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

- The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO
THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
**/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace appkraker
{
    public partial class Form1 : Form
    {
        public static Int32 ILength = (-1);
        internal const string stdpath = @"[.target app path here]";
        
        public static char[] alphabet = {
                              'a', 'b','c','d',
                              'e', 'f', 'g', 'h',
                              'i', 'j', 'k', 'l', 
                              'm', 'n', 'o', 'p',
                              'q', 'r', 's', 't',
                              'u', 'v', 'w', 'x',
                              'y', 'z', '1', '2',
                              '3', '4', '5', '6',
                              '7', '8', '9', '{', '}',
        };

        private enum PassTypes
        {           
            UnknownLength,
            KnownLength,
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool isSet()
        {
            bool ret = true;
            if (this.printLog.Checked == true)
                if (this.outPutFileLocation.Text.Length < 2)
                    ret = false;
            if (this.targetText.Text.Length < 2)
                ret = false;
            if (this.wrongpass.Text.Length < 1)
                ret = false;
            return ret;
        }

      
        private void printLog_CheckedChanged(object sender, EventArgs e)
        {
            if (this.printLog.Checked == true)
            {
                this.fileOptionsPanel.Enabled = true;
            }
            else
            {
                this.fileOptionsPanel.Enabled = false;                
            }
        }

        private void targetText_TextChanged(object sender, EventArgs e)
        {
            if (this.targetText.Text.Length > 2 && this.Text != stdpath.ToString())
                this.mainButton.Enabled = true;
            else
                this.mainButton.Enabled = false;
        }

        public string ExecAndGet(string s)
        {  
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = s;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;

        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            if (digitOnly.Checked == true)
            {
                if (isSet() == true)
                {
                    if (printLog.Checked == false)
                    {
                        int _val = 0;
                        string s;
                        while ((s = systemfunctions.ExecCmd(targetText.Text + " " + _val.ToString())).IndexOf(wrongpass.Text) != (-1))
                            _val++;
                        outputBox.Text = "";
                        outputBox.Text += "Report: " + s;
                        outputBox.Text += "\n\nPassword: " + _val.ToString();
                    }
                    else
                    {
                        if (outPutFileLocation.Text.Length > 0)
                        {
                            int _val = 0;
                            string s;
                            using (System.IO.StreamWriter wObj = new System.IO.StreamWriter(this.outPutFileLocation.Text.ToString()))
                            {
                                while ((s = systemfunctions.ExecCmd(targetText.Text + " " + _val.ToString())).IndexOf(wrongpass.Text) != (-1))
                                {
                                    wObj.WriteLine(_val.ToString() + "\tdoes not correspond.");
                                    _val++;
                                }
                                wObj.Dispose();
                            }
                            outputBox.Text = "";
                            outputBox.Text += "Report: " + s;
                            outputBox.Text += "\n\nPassword: " + _val.ToString();
                        }
                        else
                            MessageBox.Show("error: fill in all required areas correctly.\n", "Formatting error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error, 0);
                    }
                }
                else
                {
                    MessageBox.Show("error: fill in all required areas correctly.\n", "Formatting error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, 0);
                }
            }
            else
            {
                int _stage;
                if (isSet() == true)
                {
                    if (this.printLog.Checked == false)
                    {
                        string code = "";
                        for (int length = 0; ; length++)
                        {
                            _stage = 0;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("error: fill in all required areas correctly.\n", "Formatting error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, 0);
                }
            }
        }

        private void digitOnly_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public class systemfunctions
    {
        public static string ExecCmd(string cmd)
        {
            /**
             * http://www.codeproject.com/KB/cs/Execute_Command_in_CSharp.aspx
             * 
             * Thanks to CodeProject!
             * 
             */
            string ret = "null";
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                   new System.Diagnostics.ProcessStartInfo("cmd", "/c " + cmd);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                ret = result.ToString();
                // Display the command output.
                Console.WriteLine(result);

            }
            catch (Exception objException)
            {
                // Log the exception
                MessageBox.Show(objException.Message, "Exception", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning, 0, MessageBoxOptions.ServiceNotification);
            }
            return ret;
        }
    }

}
