using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectUploadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "压缩包(*.zip)|*.zip|Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx|所有文件|*.*";
            openFileDialog1.ValidateNames   = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.showFile.Text  = openFileDialog1.FileName;
            this.upload.Enabled = true;
        }

        private void upload_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(this.uploadAddress.Text) )
            {
                MessageBox.Show("请先设置上传地址。");
                return;
            }

            this.selectUploadFile.Enabled = false;
            this.upload.Enabled = false;
            
            FileInfo   v_File  = null;
            FileStream v_Input = null;

            try
            {
                v_File  = new FileInfo(this.showFile.Text);
                v_Input = new FileStream(this.showFile.Text, FileMode.Open);

                int    v_DataNo    = 0;
                byte[] v_Data      = new byte[1024 * 100];
                double v_DataCount = (double)v_File.Length / (double)v_Data.Length;
                string v_FileName  = DateTime.Now.ToFileTimeUtc().ToString() + v_File.Extension;

                v_DataCount = Math.Ceiling(v_DataCount);

                this.uploadProgress.Value   = 0;
                this.uploadProgress.Minimum = 0;
                this.uploadProgress.Maximum = (int)v_DataCount;

                while (true)
                {
                    int v_DataLen = v_Input.Read(v_Data, 0, v_Data.Length);
                    if (v_DataLen == 0)
                    {
                        break;
                    }
                    else
                    {
                        v_DataNo++;
                        string v_SendData = v_FileName
                                          + ";" + v_DataCount
                                          + ";" + v_DataNo
                                          + ";" + ByteHelp.bytesToHex(v_Data ,0 , v_DataLen)
                                          + ";" + "new"
                                          + ";" + "用户名称";
                        sendHttpPost(this.uploadAddress.Text, v_SendData);
                        this.uploadProgress.Value = v_DataNo;
                    }
                }

                MessageBox.Show("上传完成");
            }
            catch (Exception exce)
            {
                Console.WriteLine("{0} Second exception.", exce.Message);
                MessageBox.Show("上传出现异常");
            }
            finally
            {
                if (v_Input != null)
                {
                    v_Input.Close();
                }
            }


            this.selectUploadFile.Enabled = true;
            this.upload.Enabled = true;
        }



        public static string sendHttpPost(string Url, string postDataStr)
        {
            byte[] postData = Encoding.UTF8.GetBytes(postDataStr);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded;charset=utf8";
            request.ContentLength = postData.Length;
            request.Timeout = 30000;

            Stream v_Out = request.GetRequestStream();
            v_Out.Write(postData ,0 , postData.Length);
            v_Out.Flush();


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string encoding = response.ContentEncoding;
            if (encoding == null || encoding.Length < 1)
            {
                encoding = "UTF-8"; //默认编码 
            }
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();
            return retString;
        }

    }
}
