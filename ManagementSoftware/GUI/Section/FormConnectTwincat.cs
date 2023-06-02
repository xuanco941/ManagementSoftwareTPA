using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI
{
    public partial class FormConnectTwincat : Form
    {
        public FormConnectTwincat()
        {
            InitializeComponent();
            textBox1.Text = Common.AMSID;
            textBox2.Text = Common.PORT.ToString();
            textBox3.Text = Common.TenHeNap;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                int number = int.Parse(textBox2.Text);

                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Không để trống các ô trên.", "Lỗi Cú Pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var path1 = Path.Combine(Directory.GetCurrentDirectory(), "amsid.txt");
                    File.WriteAllText(path1, String.Empty);
                    File.WriteAllText(path1, textBox1.Text);

                    var path2 = Path.Combine(Directory.GetCurrentDirectory(), "port.txt");
                    File.WriteAllText(path2, String.Empty);
                    File.WriteAllText(path2, number.ToString());

                    var path3 = Path.Combine(Directory.GetCurrentDirectory(), "LoaiKhi.txt");
                    File.WriteAllText(path3, String.Empty);
                    File.WriteAllText(path3, textBox3.Text);

                    Application.Restart();
                }

            }
            catch
            {
                MessageBox.Show("Sai cú pháp, Port phải là số.", "Lỗi Cú Pháp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
