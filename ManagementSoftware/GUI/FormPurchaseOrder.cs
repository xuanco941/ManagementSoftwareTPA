using ManagementSoftware.GUI.PurchaseOrderManagement;
using ManagementSoftware.GUI.Section;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI
{
    public partial class FormPurchaseOrder : Form
    {
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;


        private void GenerateItem()
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = SystemColors.GradientActiveCaption;
            panel.Cursor = Cursors.Hand;
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(4, 3, 4, 3);
            panel.Size = new Size(1291, 110);
            panelMain.Controls.Add(panel);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Left;
            pictureBox.Image = Properties.Resources.ETEK_LOGO_01;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = new Size(217, 108);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabStop = false;


            Panel panelContent = new Panel();
            panelContent.Dock = DockStyle.Fill;
            
            GridLayout gridLayout = new GridLayout();
            gridLayout.Columns = 3;
            gridLayout.Rows = 2;
            gridLayout.ContainerControl = panelContent;

            for(int i = 1; i <= 6; i++)
            {
                Label label = new Label();
                label.Text = "ABC ABC" + i;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleCenter;

                gridLayout.AddLayoutComponent(label, null);
            }

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(panelContent);
        }



        public FormPurchaseOrder()
        {
            InitializeComponent();
            GenerateItem();
            
        }

        private void addPO_Click(object sender, EventArgs e)
        {
            new FormAddPurchaseOrder().ShowDialog();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            new FormViewDetailPurchaseOrder().Show();
        }
    }
}
