using COMP1004_W2017_Lesson11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson11
{
    public partial class DataForm : Form
    {

        NamesContext NamesDB = new NamesContext();
        SchoolContext SchoolDB = new SchoolContext();

        public DataForm()
        {
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_comp1004_w2017DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this._comp1004_w2017DataSet.Users);

            try
            {
                /// selects all the users from the Names DB
                var UsersList = (from user in NamesDB.Users
                                 select user).ToList();

                UsersDataGridView.DataSource = UsersList;

            }
            catch (Exception exception)
            {

                Debug.WriteLine(exception.Message);
            }



            var CourseList = (from course in SchoolDB.Courses
                              select course).ToList();

            foreach (var course in CourseList)
            {
                Debug.WriteLine(course.CourseShortDescription);
            }


        }

        private void UsersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = UsersDataGridView.CurrentRow.Index;
            int currentId = (int)UsersDataGridView.Rows[rowindex].Cells[0].Value;

            try
            {
                var SelectedName = (from name in NamesDB.Users
                                    where name.Id == currentId
                                    select name).FirstOrDefault();

                Debug.WriteLine(SelectedName.FirstName);
                Debug.WriteLine(SelectedName.LastName);

            }
            catch (Exception exception)
            {

                Debug.WriteLine(exception.Message);
            }
        }
    }
}
