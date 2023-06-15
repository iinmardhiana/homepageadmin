using Guna.UI2.WinForms.Enums;

namespace homepage_admin
{
    public partial class Form1 : Form
    {
        private Size formOriginalSize;
        private Rectangle recpnl1;
        private Rectangle recpnl2;
        private Rectangle recpnlnt;
        private Rectangle reclbl1;
        private Rectangle reclbl2;
        private Rectangle reclbl3;
        private Rectangle reclbl4;
        private Rectangle reclbl5;
        private Rectangle recpnlout;
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recpnl1 = new Rectangle(panel1.Location, panel1.Size);
            recpnlnt = new Rectangle(PanelNotif.Location, PanelNotif.Size);
            recpnl2 = new Rectangle(panel2.Location, panel2.Size);
            reclbl1 = new Rectangle(home.Location, home.Size);
            reclbl2 = new Rectangle(staff.Location, staff.Size);
            reclbl3 = new Rectangle(database_user.Location, database_user.Size);
            reclbl4 = new Rectangle(stts_kmr.Location, stts_kmr.Size);
            reclbl5 = new Rectangle(kritik.Location, kritik.Size);
            recpnlout = new Rectangle(panelout.Location, panelout.Size);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpnl1);
            resize_Control(PanelNotif, recpnlnt);
            resize_Control(panel2, recpnl2);
            resize_Control(home, reclbl1);
            resize_Control(staff, reclbl2);
            resize_Control(database_user, reclbl3);
            resize_Control(stts_kmr, reclbl4);
            resize_Control(kritik, reclbl5);
            resize_Control(panelout, recpnlout);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        private bool notifikasi = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (notifikasi)
            {
                PanelNotif.Hide();
                notifikasi = false;
            }
            else
            {
                PanelNotif.Show();
                notifikasi = true;
            }


        }
        private void hidenotif()
        {

        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
        }
        private void Form1_TextChanged(object sender, EventArgs e)
        {
            float fontSize = (float)(Width + Height) / 100; // Sesuaikan rumus ini sesuai kebutuhan Anda

            // Atur ukuran font pada kontrol yang diinginkan
            home.Font = new Font(home.Font.FontFamily, fontSize, home.Font.Style);
            //button1.Font = new Font(button1.Font.FontFamily, fontSize, button1.Font.Style);
        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            //Form2 fm2 = new Form2();
            //fm2.TopLevel = false;
            //fm2.FormBorderStyle = FormBorderStyle.None;
            //this.panel3.Controls.Add(fm2);
            //fm2.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelNotif_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool pictureprofil = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureprofil)
            {
                panelout.Hide();
                pictureprofil = false;
            }
            else
            {

                panelout.Show();
                Form2 fm2 = new Form2();
                fm2.TopLevel = false;
                fm2.FormBorderStyle = FormBorderStyle.None;
                this.panelout.Controls.Add(fm2);
                fm2.Show();
                pictureprofil = true;
            }
            //panelout.Show();
            //Form2 fm2 = new Form2();
            //fm2.TopLevel = false;
            //fm2.FormBorderStyle = FormBorderStyle.None;
            //this.panelout.Controls.Add(fm2);
            //fm2.Show();
            //hidenotif();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_MouseHover(object sender, EventArgs e)
        {
            home.ForeColor = Color.Blue;
        }

        private void home_MouseLeave(object sender, EventArgs e)
        {
            home.ForeColor = Color.Black;
        }

        private void staff_Click(object sender, EventArgs e)
        {
            // staff st = new staff();
            // st.Show();
            // this.Hide();
        }

        private void staff_MouseHover(object sender, EventArgs e)
        {
            staff.ForeColor = Color.Blue;
        }

        private void staff_MouseLeave(object sender, EventArgs e)
        {
            staff.ForeColor = Color.Black;
        }

        private void database_user_Click(object sender, EventArgs e)
        {
            // database_user du = new du();
            // du.Show();
            // this.Hide();
        }

        private void database_user_MouseHover(object sender, EventArgs e)
        {
            database_user.ForeColor = Color.Blue;
        }

        private void database_user_MouseLeave(object sender, EventArgs e)
        {
            database_user.ForeColor = Color.Black;
        }

        private void stts_kmr_Click(object sender, EventArgs e)
        {
            //stts_kmr sk = new stts_kmr();
            //sk.Show();
            // this.Hide();
        }

        private void stts_kmr_MouseHover(object sender, EventArgs e)
        {
            stts_kmr.ForeColor = Color.Blue;
        }

        private void stts_kmr_MouseLeave(object sender, EventArgs e)
        {
            stts_kmr.ForeColor = Color.Black;
        }

        private void kritik_Click(object sender, EventArgs e)
        {
            // kritik kr = new kritik();
            // kr.Show();
            // this.Hide();
        }

        private void kritik_MouseHover(object sender, EventArgs e)
        {
            kritik.ForeColor = Color.Blue;
        }

        private void kritik_MouseLeave(object sender, EventArgs e)
        {
            kritik.ForeColor = Color.Black;
        }
    }
}