
using System;
using Wisej.Web;

namespace Wisej.AppWithSessionlessHandler
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LoadClients();
		}

		private void LoadClients()
		{
			this.listBox1.Items.Clear();
			this.listBox1.Items.AddRange(Program.GetList());
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			LoadClients();
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			Program.ClientListChanged += Program_ClientListChanged;
		}

		private void Page1_Disposed(object sender, EventArgs e)
		{
			Program.ClientListChanged -= Program_ClientListChanged;
		}

		private void Program_ClientListChanged(object sender, EventArgs e)
		{
			Application.Update(this, () => {
				LoadClients();
			});
		}
	}
}
