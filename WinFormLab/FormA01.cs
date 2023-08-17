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
  public partial class FormA01 : Form
  {
    public FormA01()
    {
      InitializeComponent();
    }

    private void FormA01_Load(object sender, EventArgs e)
    {
      txtAppPath.Text = Application.StartupPath;
    }
  }
}
