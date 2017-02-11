/*
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Powerpoint (ppt) and PDF slide changer through speech recognition
                        28th Feb 2015
                            Tilak D
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

1) Run speech-ppt.exe or click start
2) Browse and select the PPT of PDF
3) Click start presentation
4) Voice commands: 
    a) Go to full screen: Goes to full screen mode
    b) Next slide: Goes to next slide
    c) Previous slide: Goes to previous slide
    d) Hey presentation you can exit now: To exit out of the presentation
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;

namespace speech_ppt
{
    public partial class Form1 : Form
    {
        PowerPoint.Application oPPT;
        PowerPoint.Presentations objPresSet;
        PowerPoint.Presentation objPres;

        bool showRunning = false;
        public Form1()
        {
            InitializeComponent();

            PowerPoint.Application oPPT = new PowerPoint.Application();
            oPPT.Visible = MsoTriState.msoTrue;
            oPPT.WindowState = PowerPoint.PpWindowState.ppWindowMinimized;
            objPresSet = oPPT.Presentations;
            oPPT.SlideShowEnd +=
                new PowerPoint.EApplication_SlideShowEndEventHandler(oPPT_SlideShowEnd);
        }

        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();

        private void oPPT_SlideShowEnd(PowerPoint.Presentation Pres)
        {
            showRunning = false;
            objPres.Close();
            //this.WindowState = FormWindowState.Normal;
            //this.WindowState = FormWindowState.Maximized;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter =
                "All PowerPoint Presentations (*ppt;*.pptx)|*.ppt;*.pptx";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
                ppt_file.Text = dlgOpen.FileName;
        }

        /// <summary>
        ///  Start presentation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Choices sList = new Choices();
            sList.Add(new string[] { "Next slide", "Previous slide", "Hey presentation you can exit now" });
            Grammar gr = new Grammar(new GrammarBuilder(sList));
            try
            {
                sRecognize.RequestRecognizerUpdate();
                sRecognize.LoadGrammar(gr);
                sRecognize.SpeechRecognized += sRecognize_SpeechRecognized;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.RecognizeAsync(RecognizeMode.Multiple);
                sRecognize.Recognize();
            }

            catch
            {
                //return;  // comment this to avoid unnecessarry exiting.
            }

            if (ppt_file.Text.Equals(""))
            {
                MessageBox.Show("No PowerPoint file selected",
                    "PPT Viewer", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                objPres = objPresSet.Open(ppt_file.Text,
                    MsoTriState.msoFalse, MsoTriState.msoTrue,
                    MsoTriState.msoTrue);
                objPres.SlideShowSettings.Run();
                this.WindowState = FormWindowState.Minimized;
                showRunning = true;
            }
        }


        private void sRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string command = e.Result.Text;
            switch (command)
            {
                case "Next slide":
                    objPres.SlideShowWindow.View.Next();
                    break;

                case "Previous slide":
                    objPres.SlideShowWindow.View.Previous();
                    break;

                case "Hey presentation you can exit now":
                    objPres.SlideShowWindow.View.Exit();
                    break;

                default:
                    MessageBox.Show("Unidentified command : " + command,
                        "PPT Viewer", MessageBoxButtons.OK,
                        MessageBoxIcon.Information); ;
                    break;
            }
        }

        private void MainForm_FormClosed(object sender,
    FormClosedEventArgs e)
        {
            objPres = null;
            objPresSet = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            oPPT.Quit();
        }

        private void ppt_file_TextChanged(object sender, EventArgs e)
        {

        }


        // To open PDF
        private void pdf_brouse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter =
                "All Adobe PDF files (*.pdf)|*.pdf";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
                pdf_file.Text = dlgOpen.FileName;
        }

        private void pdf_present_Click(object sender, EventArgs e)
        {
            Choices ssList = new Choices();
            ssList.Add(new string[] { "Next slide", "Previous slide", "Hey presentation you can exit now", "Go to full screen" });
            Grammar gra = new Grammar(new GrammarBuilder(ssList));
            try
            {
                sRecognize.RequestRecognizerUpdate();
                sRecognize.LoadGrammar(gra);
                sRecognize.SpeechRecognized += ssRecognize_SpeechRecognized;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.RecognizeAsync(RecognizeMode.Multiple);
                sRecognize.Recognize();
            }

            catch
            {
                //return;  // comment this to avoid unnecessarry exiting.
            }

            if (pdf_file.Text.Equals(""))
            {
                MessageBox.Show("No PDF file selected",
                    "PDF Viewer", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                string pdfPath = pdf_file.Text;

                if (System.IO.File.Exists(pdfPath))
                {
                    System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
                    myProcess.StartInfo.FileName = "AcroRd32.exe";
                    myProcess.StartInfo.Arguments = string.Format("/A \"page=1=OpenActions\" \"{0}\"", pdfPath);
                    myProcess.Start();
                }
            }
        
        }
        private void ssRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string commandd = e.Result.Text;
            switch (commandd)
            {
                case "Next slide":
                    SendKeys.SendWait("{DOWN}");
                    break;

                case "Previous slide":
                    SendKeys.SendWait("{UP}");
                    break;

                case "Hey presentation you can exit now":
                    SendKeys.SendWait("^{q}");
                    Application.Exit();
                    break;

                case "Go to full screen":
                    SendKeys.SendWait("^{l}");
                    break;

                default:
                    //SendKeys.SendWait("^{L}");
                    break;
            }
        }
        private void pdf_file_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



    }
}
