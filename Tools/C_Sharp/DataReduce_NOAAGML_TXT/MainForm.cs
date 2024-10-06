
using System.Threading;
using System.IO;
using System.Runtime;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataReduce_NOAAGML_TXT
{
    public partial class MainForm : Form
    {
        Thread converter = null;
        Boolean cv_stop = false;
        Boolean cv_running = false;

        // Headers name->line_pos
        Dictionary<String, int> headers_by_name = new Dictionary<String, int>();
        // Headers line_pos->name
        Dictionary<int, String> headers_by_pos = new Dictionary<int, String>();
        // Data Lines lineNo->Header->Value
        Dictionary<int, Dictionary<String, String>> data_by_line = new Dictionary<int, Dictionary<string, string>>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Button_MF_InputTxt_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBox_MF_InputFile.Text = openFileDialog1.FileName;
                TextBox_MF_InputFile.Refresh();
            }
        }

        private void Button_MF_OutputFIle_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBox_MF_OutputFIle.Text = openFileDialog1.FileName;
                TextBox_MF_OutputFIle.Refresh();
            }
        }

        private void Button_MF_Convert_Click(object sender, EventArgs e)
        {
            if (converter != null)
            {
                MessageBox.Show("Converter Running - Stop First");
                return;
            }

            converter = new Thread(ConvertThread);
            converter.Start();

        }

        private void Button_MF_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Post_Status(string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => { Post_Status(msg); })); // <-- this is very cumbersome
            }
            else
            {
                ListBox_MF_Status.Items.Insert(0, msg);
            }
        }

        private void Post_Stats(int lines, int comments, int dataCnt)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => { Post_Stats(lines, comments, dataCnt); })); // <-- this is very cumbersome
            }
            else
            {
                TextBox_MF_LinesRead.Text = lines.ToString();
                TextBox_Comment_Lines.Text = comments.ToString();
                TextBox_Data_Lines.Text = dataCnt.ToString();
            }
        }

        private void Post_ThreadDone()
        {
            Post_Status("Conversion Complete");
            converter = null;
        }

        private void ConvertThread()
        {
            cv_running = true;
            Post_Status("Starting Conversion");
            Post_Stats(0, 0, 0);

            Post_Status("Reading File " + TextBox_MF_InputFile.Text);
            ReadInputIntoDictionary();
            if (!cv_stop)
            {
                Post_Status("Input File read");
                Post_Status("Converting");
                ConvertToOutputFile();
            }

            Post_ThreadDone();

            cv_running = false;
        }

        private void ReadInputIntoDictionary()
        {
            StreamReader inHandle = new StreamReader(TextBox_MF_InputFile.Text);
            String line = "";
            int lineCounter = 0;
            int commentLines = 0;
            int dataLines = 0;
            bool headersFound = false;

            while (((line = inHandle.ReadLine()) != null) && (!cv_stop))
            {
                if (line != "")
                {
                    if (line.ElementAt(0) != '#')
                    {
                        String[] items = line.Split(' ');
                        if (!headersFound)  // Headers
                        {
                            for (int itemLoop = 0; itemLoop < items.Length; itemLoop++)
                            {
                                headers_by_name.Add(items[itemLoop], itemLoop);
                                headers_by_pos.Add(itemLoop, items[itemLoop]);
                            }
                            headersFound = true;
                        }
                        else // Data
                        {
                            Dictionary<String, String> dataItems = new Dictionary<string, string>();
                            for (int dataItemLoop = 0; dataItemLoop < items.Length; dataItemLoop++)
                            {
                                String headerName = headers_by_pos[dataItemLoop];
                                if (!dataItems.ContainsKey(headerName))
                                {
                                    dataItems.Add(headerName, items[dataItemLoop]);
                                }

                            }
                            dataLines++;
                            data_by_line.Add(lineCounter, dataItems);
                        }
                    }
                    else
                    {
                        commentLines++;
                    }
                }
                else
                {
                    commentLines++;
                }
                lineCounter++;
                Post_Stats(lineCounter, commentLines, dataLines);
            }

            inHandle.Close();
        }

        private void WriteHeader(StreamWriter handle)
        {
            String header = "City/Station, Lat, Long, Value";
            handle.WriteLine(header);
        }

        private void ConvertToOutputFile()
        {
            StreamWriter outHandle = new StreamWriter(TextBox_MF_OutputFIle.Text);
            if (CheckBox_MF_AddHeader.Checked)
            {
                WriteHeader(outHandle);
            }

            for (int dataOutLoop = 0; dataOutLoop < data_by_line.Count; dataOutLoop++)
            {
                // site_code year month day hour minute second datetime time_decimal midpoint_time value value_std_dev value_unc nvalue latitude longitude altitude elevation intake_height instrument qcflag profile_id flight_id temperature pressure rh
                Dictionary<String, String> dataItems = data_by_line.ElementAt(dataOutLoop).Value;
                String cityStation = "";
                String latitude = "";
                String longitude = "";
                String value = "";
                for (int dataItemLoop = 0; dataItemLoop < dataItems.Count; dataItemLoop++)
                {
                    String itemName = dataItems.ElementAt(dataItemLoop).Key;
                    String itemValue = dataItems[itemName];
                    if (headers_by_pos[dataItemLoop] == "site_code")
                    {
                        cityStation = itemValue;
                    }
                    if (headers_by_pos[dataItemLoop] == "latitude")
                    {
                        latitude = itemValue;
                    }
                    if (headers_by_pos[dataItemLoop] == "longitude")
                    {
                        longitude = itemValue;
                    }
                    if (headers_by_pos[dataItemLoop] == "value")
                    {
                        value = itemValue;
                    }
                }

                String outString = cityStation + "," + latitude + "," + longitude + "," + value;
                outHandle.WriteLine(outString);
            }

            outHandle.Close();
        }
    }
}