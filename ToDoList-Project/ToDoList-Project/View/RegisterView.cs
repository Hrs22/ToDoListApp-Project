using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList_Project.Controller;
using ToDoList_Project.Model;

namespace ToDoList_Project.View
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void RegisterView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registerDBDataSet.RegisterTable' table. You can move, or remove it, as needed.
            this.registerTableTableAdapter.Fill(this.registerDBDataSet.RegisterTable);

        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtbox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn1_Click(object sender, EventArgs e)
        {
            RegisterTable register = new RegisterTable();
            register.username = txtbox1.Text;
            register.password = txtbox2.Text;
            register.email = txtbox3.Text;
            
        }
    }
}
