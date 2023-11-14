namespace laber
{
    public partial class Form1 : Form
    {
        GroupBox gp;
        RadioButton r1;
        RadioButton r2;
        Label lbl;
        TextBox txt_box;
        Button btn1;
        Button btn2;
        public Form1()
        {
            this.Height = 250;
            this.Width = 300;

            

            r1 = new RadioButton();
            r1.Text = "Раздел 1";
            r1.Location = new Point(15, 35);
            r1.Size = new Size(100, 20);
            r2 = new RadioButton();
            r2.Text = "Раздел 2";
            r2.Location = new Point(15, 65);
            r2.Size = new Size(100, 20);
            r1.Visible = true;
            r2.Visible = true;
            r1.BackColor = Color.GreenYellow;
            r2.BackColor = Color.GreenYellow;
            this.Controls.Add(r1);
            this.Controls.Add(r2);

            gp = new GroupBox();
            gp.BackColor = Color.GreenYellow;
            gp.Text = "Добавить в";
            gp.Location = new Point(10, 10);
            gp.Size = new Size(260, 100);
            this.Controls.Add(gp);

            lbl = new Label();
            lbl.Text = "Введите текст:";
            lbl.ForeColor = Color.Black;
            lbl.Location = new Point(10, 120);
            lbl.Size = new Size(90, 20);
            lbl.Visible = true;
            lbl.BackColor = Color.LightBlue;
            this.Controls.Add(lbl);

            txt_box = new TextBox();
            txt_box.BorderStyle = BorderStyle.Fixed3D;
            txt_box.Height = 20;
            txt_box.Width = 260;
            txt_box.Text = "";
            txt_box.Location = new Point(10, 145);
            this.Controls.Add(txt_box);

            btn1 = new Button();
            btn1.Height = 30;
            btn1.Width = 120;
            btn1.Text = "Добавить";
            btn1.Location = new Point(10, 175);
            btn1.Visible = true;
            btn1.Click += new System.EventHandler(ButtonCreate);
            this.Controls.Add(btn1);
            void ButtonCreate(object sender, EventArgs e)
            {
                Forms Main = this.Owner as Forms;

                if (txt_box.Text != "")
                {
                    if (this.r1.Checked == true)
                        Main.lb.Items.Add(this.txt_box.Text);
                    if (this.r2.Checked == true)
                        Main.lb1.Items.Add(this.txt_box.Text);

                    this.Close();
                }
            }

            btn2 = new Button();
            btn2.Height = 30;
            btn2.Width = 120;
            btn2.Text = "Отмена";
            btn2.Location = new Point(150, 175);
            btn2.Click += new System.EventHandler(ButtonExit);
            btn2.Visible = true;
            this.Controls.Add(btn2);
            void ButtonExit(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
}