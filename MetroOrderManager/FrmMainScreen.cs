using Common;
using MetroOrderManager.Forms;
using System;
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
            try
            {
                PnlLeft.Width = 60;
                LblMenu.Visible = false;
                OpenChildForm(new FrmDashboard());
                LblVersion.Text = Messages.SisMessages[0];
                LblScreenTitle.Text = Messages.ScreenMessages[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no carregamento da página", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        #region Clear screen title text
        private void ClearScreenTitleText()
        {
            LblScreenTitle.Text = String.Empty;
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
            ClearScreenTitleText();
            LblScreenTitle.Text = Messages.ScreenMessages[0];
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            ClearScreenTitleText();
            LblScreenTitle.Text = Messages.ScreenMessages[1];
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            ClearScreenTitleText();
            LblScreenTitle.Text = Messages.ScreenMessages[2];
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            ClearScreenTitleText();
            LblScreenTitle.Text = Messages.ScreenMessages[3];
        }
    }
}
