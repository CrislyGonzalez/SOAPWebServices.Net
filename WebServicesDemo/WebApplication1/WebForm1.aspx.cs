using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnAdd_Click(object sender, EventArgs e)
		{
			//public partial class WebService1SoapClient // revisar References.cs ahí es donde esta el servicio
			CalculatorService.WebService1SoapClient client = 
				new CalculatorService.WebService1SoapClient();
			int result = client.Add(Convert.ToInt32(txtFirstNumber.Text), 
				Convert.ToInt32(txtSecondNumber.Text));
			lblResult.Text = result.ToString();
		}
	}
}