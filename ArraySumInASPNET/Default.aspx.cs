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

            long num = 0;
            long num2 = 0;
            for (int k = 0; k < arr.Length; k++)
            {
                num = Convert.ToInt64(arr[k]);
                num2 += num;
            }
            sum1.Text = Convert.ToString(num2);
        }
    }
}