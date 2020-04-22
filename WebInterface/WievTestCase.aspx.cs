using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CheckEngine;
using DataService;

namespace WebInterface
{
    public partial class WievTestCase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RadioButton1.Checked==false)
                 FileUpload1.Visible = false;

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxId.Visible = false;
            Label1.Text = "";
            Label2.Text = "";
            FileUpload1.Visible = true;
        }
        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxId.Visible = true;
            TextBoxId.Height = default;
            TextBoxId.Width = default;
            TextBoxId.Text = "";
            TextBoxId.TextMode = TextBoxMode.SingleLine;
            Label1.Text = "Введите Id тестового примера";
            FileUpload1.Visible = false;
            Label2.Text = "";

        }
        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxId.Visible = true;
            TextBoxId.Height = 500;
            TextBoxId.Width = 500;
            TextBoxId.TextMode = TextBoxMode.MultiLine;
            TextBoxId.Text = "";
            Label1.Text = "Введите тестовый пример";
            FileUpload1.Visible = false;
            Label2.Text = "";
        }

        protected void CheckButton_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            if (RadioButton1.Checked)
            {
                if (FileUpload1.HasFile)
                {
                    string fileExtension = Path.GetExtension(FileUpload1.FileName);
                    
                    if (fileExtension!= ".txt")
                    {
                        Label1.Text = "Файл не является txt документом";
                    }
                    else
                    {
                        int fileSize = FileUpload1.PostedFile.ContentLength;
                        if (fileSize > 5242880)
                        {
                            Label1.Text = "Размер текстового файла не должен превышать 5 Мб";
                        }
                        else
                        {
                            string text;
                            using (StreamReader sr = new StreamReader(FileUpload1.FileContent))
                            {
                                text = sr.ReadToEnd();
                            }
                            GetResult(text);
                        }
                    }
                }
            }
            else if(RadioButton2.Checked)
            {
                try
                {
                    DataServiceContext dataService = new DataServiceContext();
                    GetResult(dataService.GetTestCaseById(Convert.ToInt32(TextBoxId.Text)));
                }
                catch (Exception ex)
                {
                    Label2.Text = ($"Ошибка при вводе Id: {ex.Message}");
                    return;
                }
            }
            else if (RadioButton3.Checked)
            {
                try
                {
                    GetResult(TextBoxId.Text);
                }

                catch (Exception ex)
                {
                    Label2.Text = ($"Ошибка при вводе текста: {ex.Message}");
                    return;
                }             
            }
            

        }
        public void GetResult(string text)
        {
            IVerification verification = new VerificationWeb();
            bool searchResult=verification.CheckOnCorrectPlacement(text);
            Label2.Text = $"Результат проверки: {searchResult}";
        }



    }
}