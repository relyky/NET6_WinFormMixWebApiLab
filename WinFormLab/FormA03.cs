using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLab;

public partial class FormA03 : Form
{
  //##State
  List<Person> People { get; set; } = new();

  public FormA03()
  {
    InitializeComponent();
  }

  void FormA03_Load(object sender, EventArgs e)
  {
    People = GetPeople();
    dataGridView1.DataSource = People;
  }

  List<Person> GetPeople()
  {
    var list = new List<Person>();
    list.Add(new Person
    {
      PersonId = 1,
      Name = "Person 1",
      Surname = "Surname 1",
      Profession = "Profession 1"
    });

    list.Add(new Person
    {
      PersonId = 2,
      Name = "Person 2",
      Surname = "Surname 2",
      Profession = "Profession 2"
    });

    list.Add(new Person
    {
      PersonId = 3,
      Name = "Person 3",
      Surname = "Surname 3",
      Profession = "Profession 3"
    });

    return list;
  }

  private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
  {
    try
    {
      var pickItem = dataGridView1.SelectedRows[0].DataBoundItem as Person;
      txtPersonId.Text = pickItem.PersonId.ToString();
      txtName.Text = pickItem.Name;
      txtSurname.Text = pickItem.Surname;
      txtProfession.Text = pickItem.Profession;
    }
    catch (Exception ex)
    {
      MessageBox.Show("出現例外！" + ex.Message + Environment.NewLine + ex.StackTrace);
    }
  }
}
