using Common;
using MetroOrderManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroOrderManager
{
    public partial class FrmMainScreen : Form
    {
        public FrmMainScreen()
        {
            InitializeComponent();
        }
        private void FrmMainScreen_Load(object sender, EventArgs e)
        {
            PnlLeft.Width = 60;
            LblMenu.Visible = false;
            OpenChildForm(new FrmDashboard());
        }
        #region Open Children Forms
        private void OpenChildForm(object FormChild)
        {
            if (this.PnlContent.Controls.Count > 0)
                this.PnlContent.Controls.RemoveAt(0);

            Form fc = FormChild as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.PnlContent.Controls.Add(fc);
            this.PnlContent.Tag = fc;
            fc.Show();
        }
        #endregion

        #region MoveIndicator
        private void MoveIndicator(Control control)
        {
            PbIndicator.Top = control.Top;
            PbIndicator.Height = control.Height;
        }
        #endregion

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (PnlLeft.Width == 60)
            {
                PnlLeft.Width = 200;
                LblMenu.Visible = true;
            }
            else
            {
                PnlLeft.Width = 60;
                LblMenu.Visible = false;
            }
        }

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            Utils.ReleaseCapture();
            Utils.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            OpenChildForm(new FrmDashboard());
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
        }
    }
}
