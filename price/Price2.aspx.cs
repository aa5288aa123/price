using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace price
{
    public partial class Price2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Get("CheckBox1") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "雞排" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox2") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "雞尾椎" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox3") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "魚板" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox4") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "甜不辣" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox5") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "玉米筍" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox6") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "魷魚" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox7") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "雞心" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox8") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "百頁豆腐" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox9") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "薯條" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox10") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "四季豆" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox11") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "雞排" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox12") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "雞尾椎" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox13") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "魚板" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox14") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "甜不辣" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox15") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "玉米筍" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox16") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "魷魚" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox17") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "雞心" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox18") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "百頁豆腐" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox19") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "薯條" + "<br />";
                }
            }
            if (Request.Form.Get("CheckBox20") == "on")
            {
                {
                    lb_Res.Text = lb_Res.Text + "四季豆" + "<br />";
                }
            }
        }
    }
}