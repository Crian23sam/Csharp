using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2a
{
    public partial class boxing : System.Web.UI.Page
    {
        TextBox tbx1;
        Button btn1;
        Label lbl1;
        Literal ltr;

        protected void Page_Load(object sender, EventArgs e)
        {
            tbx1 = new TextBox();
            btn1 = new Button();
            btn1.Text = "Do Boxing & Unboxing";
            lbl1 = new Label();

            btn1.Click +=new EventHandler(btn1_Click);

            this.form1.Controls.Add(new Literal { Text = "Enter a Number" });
            this.form1.Controls.Add(tbx1);
            ltr = new Literal();
            ltr.Text = "</br></br>";
            this.form1.Controls.Add(ltr);

            this.form1.Controls.Add(btn1);
            ltr = new Literal();
            ltr.Text = "</br></br>";
            this.form1.Controls.Add(ltr);

            this.form1.Controls.Add(lbl1);
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string Value = tbx1.Text;
            int number;
            bool isNumeric = int.TryParse(Value, out number);

            if (isNumeric)
            {
                object boxedValue = number;

                int UnboxedValue = (int)boxedValue;

                lbl1.Text = "Boxed value:" + boxedValue + " Unboxed Value:" + UnboxedValue;
            }
            else
            {
                lbl1.Text = "please enter a valid number";
            }
        }
    }
}