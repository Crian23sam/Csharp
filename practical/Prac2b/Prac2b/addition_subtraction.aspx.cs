using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2b
{
    public partial class addition_subtraction : System.Web.UI.Page
    {
        TextBox tbx1, tbx2;
        Button btn1, btn2;
        Label lbl1;

        public delegate int ArithOper(int x, int y);

        protected void Page_Load(object sender, EventArgs e)
        {
            tbx1 = new TextBox();
            tbx2 = new TextBox();
            btn1 = new Button();
            btn1.Text = "Add";
            btn1.Click += new EventHandler(btn1_Click);
            btn2 = new Button();
            btn2.Text = "Subtract";
            btn2.Click += new EventHandler(btn2_Click);
            
            lbl1 = new Label();

            this.form1.Controls.Add(new Literal { Text = "Enter a number" });
            this.form1.Controls.Add(tbx1);

            this.form1.Controls.Add(new Literal { Text = "</br>Enter second Number" });
            this.form1.Controls.Add(tbx2);
            this.form1.Controls.Add(new Literal { Text = "</br></br>" });
            this.form1.Controls.Add(btn1);
            this.form1.Controls.Add(btn2);
            this.form1.Controls.Add(new Literal { Text = "</br></br>" });
            this.form1.Controls.Add(lbl1);
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            PerfOper((x,y)=>x+y);
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            PerfOper((x,y)=>x-y);
        }

        protected void PerfOper(ArithOper operation)
        {
            int num1;
            int num2;
            bool Num1Valid = int.TryParse(tbx1.Text, out num1);
            bool Num2Valid = int.TryParse(tbx2.Text, out num2);

            if (Num1Valid && Num2Valid)
            {
                int result = operation(num1, num2);
                lbl1.Text = "Result:" + result;
            }
            else
            {
                lbl1.Text = "Please enter a valid Number";
            }
        }
    }
}