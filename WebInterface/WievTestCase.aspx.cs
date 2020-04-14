using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CheckOnCorrectPlacement;



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
      

        

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
                TextBoxId.Visible = true;
                Label1.Text = "Введите Id тестового примера";
                FileUpload1.Visible = false;
          
        }
 

        protected void CheckButton_Click(object sender, EventArgs e)
        {
           
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
                            IVerification verification = new Verification();
                            FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                            verification.InputData = Server.MapPath("~/Uploads/" + FileUpload1.FileName);        
                            verification.CheckOnCorrectPlacement("FileSource") ;
                            Label1.Text = "Проверка произошла успешно";
                        }
                    }
                }
            }
            else if(RadioButton2.Checked)
            {
                Verification verification = new Verification();
                verification.InputData = TextBoxId.Text;
                verification.CheckOnCorrectPlacement("DatabaseSource");
                FileUpload1.Visible = false;
            }
          
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
                TextBoxId.Visible = false;
                Label1.Text = "";
                FileUpload1.Visible = true;  
        }

     
    }
}