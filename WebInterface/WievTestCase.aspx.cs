using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CheckOnCorrectPlacement;
using DataService;

namespace WebInterface
{
    public partial class WievTestCase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        private void change(object sender, EventArgs e)
        {

        }



        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxId.Visible = false;
            Label1.Text = "";
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
                            

                            FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                            WorkWithWeb verification = new WorkWithWeb();
                            string text= verification.ReadText(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                            verification.CheckOnCorrectPlacement(text) ;
                            Label2.Text = "Проверка произошла успешно";
                        }
                    }
                }
            }
            else if(RadioButton2.Checked)
            {
                try
                {
                    FileUpload1.Visible = false;
                    DataServiceContext dataService = new DataServiceContext();
                    WorkWithWeb verification = new WorkWithWeb();   
                    verification.CheckOnCorrectPlacement(dataService.ReadId(Convert.ToInt32(TextBoxId.Text)));
                    Label2.Text = "Проверка произошла успешно";
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
                    FileUpload1.Visible = false;
                    WorkWithWeb verification = new WorkWithWeb();
                    verification.CheckOnCorrectPlacement(TextBoxId.Text);
                    Label2.Text = "Проверка произошла успешно";
                }

                catch (Exception ex)
                {
                    Label2.Text = ($"Ошибка при вводе текста: {ex.Message}");
                    FileUpload1.Visible = false;
                    return;
                }             
            }

        }

       

       
    }
}