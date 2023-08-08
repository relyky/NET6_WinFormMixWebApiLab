namespace WinFormLab
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    void OpenForm(Type formType)
    {
      Form? child = this.MdiChildren.FirstOrDefault(c => c.GetType() == formType);
      if (child == null)
      {
        var ctr = formType.GetConstructor(Type.EmptyTypes);
        child = (Form)ctr!.Invoke(null);
        child.MdiParent = this;
      }

      child.Show();
      child.Focus();
    }

    private void menuFormA01_Click(object sender, EventArgs e)
    {
      OpenForm(typeof(FormA01));
    }

    private void menuFormA02_Click(object sender, EventArgs e)
    {
      OpenForm(typeof(FormA02));
    }
  }
}