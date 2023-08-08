using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLab
{
  public partial class FormA02 : Form
  {
    public FormA02()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      textBox1.AppendText($"今天天氣真好@{DateTime.Now:HH:mm:ss}{Environment.NewLine}");
    }
  }
}
