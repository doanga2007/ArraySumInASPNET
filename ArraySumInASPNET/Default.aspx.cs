using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArraySumInASPNET
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] arr = new string[]
            {
            "200",
            "500",
            "900"
            };

            for (int k = 0; k < arr.Length; k++)
            {
                double num = Convert.ToDouble(arr[k]);
                long num2 = Convert.ToInt64(num);

                num2 += num2;

                string num3 = Convert.ToString(num2);

                sum1.Text = num3;
            }
        }
    }
}