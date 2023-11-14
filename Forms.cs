using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laber
{
    internal class Forms : Form
    {
        MenuStrip mm;
        ToolStripMenuItem fm;
        ToolStripMenuItem fm1;
        ToolStripMenuItem fm2;
        ToolStripMenuItem fm3;
        ToolStripMenuItem fm4;
        Label lbl;
        Label lbl1;
        Label lbl2;
        Panel pnl;
        ComboBox cb;
        ComboBox cb1;
        public ListBox lb;
        public ListBox lb1;
        ListBox lb2;
        RichTextBox rtb;
        Button btn1;
        Button btn2;
        Button btn3;
        Button btn4;
        Button btn5;
        Button btn6;
        Button btn7;
        Button btn8;
        Button btn9;
        Button btn10;
        Button btn11;
        Button btn12;
        Button btn13;
        Button btn14;
        GroupBox gp;
        GroupBox gp1;
        TextBox txt_box;
        CheckBox c1;
        CheckBox c2;
        RadioButton r1;
        RadioButton r2;
        RadioButton r3;

        public Forms() 
        {
            this.Height = 700;
            this.Width =900;

            mm = new MenuStrip();
            mm.BackColor = Color.White;
            mm.ForeColor = Color.Black;
            mm.Font = new Font("Arial", 10);
            this.MainMenuStrip = mm;
            Controls.Add(mm);
            
            fm = new ToolStripMenuItem("File");
            fm.BackColor = Color.LightCoral;
            fm.ForeColor = Color.Black;
            fm.Text = "Файл";
            fm.Font = new Font("Arial", 8);
            mm.Items.Add(fm);

            fm1 = new ToolStripMenuItem("File");
            fm1.BackColor = Color.LightCoral;
            fm1.ForeColor = Color.Black;
            fm1.Text = "?";
            fm1.Font = new Font("Arial", 8);
            mm.Items.Add(fm1);
            fm1.Click += new System.EventHandler(FileMenuItemClick3);
            void FileMenuItemClick3(object sender, EventArgs e)
            {
                MessageBox.Show("Информация о приложении и разработчике");
            }

            fm2 = new ToolStripMenuItem("File");
            fm2.BackColor = Color.LightCoral;
            fm2.ForeColor = Color.Black;
            fm2.Text = "Открыть";
            fm2.Font = new Font("Arial", 8);
            fm2.Click += new System.EventHandler(FileMenuItemClick);
            void FileMenuItemClick(object sender, EventArgs e)
            {
                OpenFileDialog OpenDlg = new OpenFileDialog();
                if (OpenDlg.ShowDialog() == DialogResult.OK)
                {
                    StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                    rtb.Text = Reader.ReadToEnd();
                    Reader.Close();
                }
            }


            fm3 = new ToolStripMenuItem("File");
            fm3.BackColor = Color.LightCoral;
            fm3.ForeColor = Color.Black;
            fm3.Text = "Сохранить";
            fm3.Font = new Font("Arial", 8);
            fm3.Click += new System.EventHandler(FileMenuItemClick1);
            void FileMenuItemClick1(object sender, EventArgs e)
            {
                SaveFileDialog SaveDlg = new SaveFileDialog();
                if (SaveDlg.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                    for (int i = 0; i < lb.Items.Count; i++)
                    {
                        Writer.WriteLine((string)lb.Items[i]);
                    }
                }
            }

            fm4 = new ToolStripMenuItem("File");
            fm4.BackColor = Color.LightCoral;
            fm4.ForeColor = Color.Black;
            fm4.Text = "Выход";
            fm4.Font = new Font("Arial", 8);
            fm4.Click += new System.EventHandler(FileMenuItemClick2);
            void FileMenuItemClick2(object sender, EventArgs e)
            {
                Application.Exit();
            }

            fm.DropDownItems.Add(fm2);
            fm.DropDownItems.Add(fm3);
            fm.DropDownItems.Add(fm4);

            rtb = new RichTextBox();
            rtb.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            rtb.SelectionColor = Color.Black;
            rtb.Location = new Point(520, 30);
            rtb.Size = new Size(350, 470);
            this.Controls.Add(rtb);

            lbl = new Label();
            lbl.Text = "Раздел 1";
            lbl.ForeColor = Color.Black;
            lbl.Location = new Point(12, 35);
            lbl.Size = new Size(55, 20);
            lbl.Visible = true;
            lbl.BackColor = Color.LightBlue;
            this.Controls.Add(lbl);

            lbl1 = new Label();
            lbl1.Text = "Раздел 2";
            lbl1.ForeColor = Color.Black;
            lbl1.Location = new Point(310, 35);
            lbl1.Size = new Size(55, 20);
            lbl1.Visible = true;
            lbl1.BackColor = Color.LightBlue;
            this.Controls.Add(lbl1);

            cb = new ComboBox();
            cb.Location = new System.Drawing.Point(20, 60);
            cb.Name = "comboBox1";
            cb.Size = new System.Drawing.Size(170, 25);
            cb.BackColor = System.Drawing.Color.White;
            cb.Text = "Сортировка по...";
            cb.Items.Add("Алфавит (по возрастанию)");
            cb.Items.Add("Алфавит (по убыванию)");
            cb.Items.Add("Длине слова (по возрастанию)");
            cb.Items.Add("Длине слова (по убыванию)");
            Controls.Add(cb);

            cb1 = new ComboBox();
            cb1.Location = new System.Drawing.Point(310, 60);
            cb1.Name = "comboBox1";
            cb1.Size = new System.Drawing.Size(170, 25);
            cb1.BackColor = System.Drawing.Color.White;
            cb1.Text = "Сортировка по...";
            cb1.Items.Add("Алфавит (по возрастанию)");
            cb1.Items.Add("Алфавит (по убыванию)");
            cb1.Items.Add("Длине слова (по возрастанию)");
            cb1.Items.Add("Длине слова (по убыванию)");
            Controls.Add(cb1);

            lb = new ListBox();
            lb.SelectionMode = SelectionMode.MultiExtended;
            lb.Location = new Point(20, 90);
            lb.Size = new Size(170, 220);
            lb.Visible = true;
            this.Controls.Add(lb);

            lb1 = new ListBox();
            lb1.SelectionMode = SelectionMode.MultiExtended;
            lb1.Location = new Point(310, 90);
            lb1.Size = new Size(170, 220);
            lb1.Visible = true;
            this.Controls.Add(lb1);

            

            btn1 = new Button();
            btn1.Height = 30;
            btn1.Width = 100;
            btn1.Text = ">";
            btn1.Location = new Point(200, 100);
            btn1.Visible = true;
            btn1.Click += new System.EventHandler(ButtonToRigth);
            this.Controls.Add(btn1);
            void ButtonToRigth(object sender, EventArgs e)
            {
                lb1.BeginUpdate();
                foreach (object Item in lb.SelectedItems)
                {
                    lb1.Items.Add(Item);
                }
                lb.Items.RemoveAt(lb.SelectedIndex);
                lb1.EndUpdate();
            }

            btn2 = new Button();
            btn2.Height = 30;
            btn2.Width = 100;
            btn2.Text = "<";
            btn2.Location = new Point(200, 140);
            btn2.Visible = true;
            btn2.Click += new System.EventHandler(ButtonToLeft);
            this.Controls.Add(btn2);
            void ButtonToLeft(object sender, EventArgs e)
            {
                lb.BeginUpdate();
                foreach (object Item in lb1.SelectedItems)
                {
                    lb.Items.Add(Item);
                }
                lb1.Items.RemoveAt(lb1.SelectedIndex);
                lb.EndUpdate();
            }

            btn3 = new Button();
            btn3.Height = 30;
            btn3.Width = 100;
            btn3.Text = ">>";
            btn3.Location = new Point(200, 180);
            btn3.Click += new System.EventHandler(ButtonToAllRigth);
            btn3.Visible = true;
            this.Controls.Add(btn3);
            void ButtonToAllRigth(object sender, EventArgs e)
            {
                lb1.Items.AddRange(lb.Items);
                lb.Items.Clear();
            }

            btn4 = new Button();
            btn4.Height = 30;
            btn4.Width = 100;
            btn4.Text = "<<";
            btn4.Location = new Point(200, 220);
            btn4.Visible = true;
            btn4.Click += new System.EventHandler(ButtonToAllLeft);
            this.Controls.Add(btn4);
            void ButtonToAllLeft(object sender, EventArgs e)
            {
                lb.Items.AddRange(lb1.Items);
                lb1.Items.Clear();
            }

            btn5 = new Button();
            btn5.Height = 30;
            btn5.Width = 100;
            btn5.Text = "Сортировать";
            btn5.Location = new Point(50, 310);
            btn5.Visible = true;
            btn5.Click += new System.EventHandler(ButtonSortlb1);
            this.Controls.Add(btn5);
            void ButtonSortlb1(object sender, EventArgs e)
            {
                if (cb.Text == "Алфавит (по возрастанию)")
                    lb.Sorted = true;
                else if (cb.Text == "Алфавит (по убыванию)")
                {
                    lb.Sorted = false;
                    ArrayList list = new ArrayList();
                    foreach (var item in lb.Items)
                    {
                        list.Add(item);
                    }
                    list.Sort();
                    list.Reverse();
                    lb.Items.Clear();
                    foreach (var item in list)
                    {
                        lb.Items.Add(item);
                    }
                }
                else if (cb.Text == "Длине слова (по возрастанию)")
                {
                    lb.Sorted = false;
                    for (int i = 0; i < lb.Items.Count; i++)
                    {
                        for (int j = i; j < lb.Items.Count; j++)
                        {
                            if (lb.Items[i].ToString().Length > lb.Items[j].ToString().Length)
                            {
                                string temp;
                                temp = lb.Items[i].ToString();
                                lb.Items[i] = lb.Items[j];
                                lb.Items[j] = temp;
                            }
                        }
                    }
                }
                else if (cb.Text == "Длине слова (по убыванию)")
                {
                    lb.Sorted = false;
                    for (int i = 0; i < lb.Items.Count; i++)
                    {
                        for (int j = i; j < lb.Items.Count; j++)
                        {
                            if (lb.Items[j].ToString().Length > lb.Items[i].ToString().Length)
                            {
                                string temp;
                                temp = lb.Items[j].ToString();
                                lb.Items[j] = lb.Items[i];
                                lb.Items[i] = temp;
                            }
                        }
                    }
                }
            }

            btn6 = new Button();
            btn6.Height = 30;
            btn6.Width = 100;
            btn6.Text = "Очистить";
            btn6.Location = new Point(50, 350);
            btn6.Visible = true;
            btn6.Click += new System.EventHandler(ButtonClear);
            this.Controls.Add(btn6);
            void ButtonClear(object sender, EventArgs e)
            {
                lb.Items.Clear();
            }

            btn7 = new Button();
            btn7.Height = 30;
            btn7.Width = 100;
            btn7.Text = "Добавить";
            btn7.Location = new Point(200, 310);
            btn7.Visible = true;
            btn7.Click += new System.EventHandler(ButtonCreate);
            this.Controls.Add(btn7);
            void ButtonCreate(object sender, EventArgs e)
            {
                Form1 AddRec = new Form1();

                AddRec.Owner = this;
                AddRec.ShowDialog();
            }

            btn8 = new Button();
            btn8.Height = 30;
            btn8.Width = 100;
            btn8.Text = "Удалить";
            btn8.Location = new Point(200, 350);
            btn8.Visible = true;
            btn8.Click += new System.EventHandler(ButtonDeleteSelected);
            this.Controls.Add(btn8);
            void ButtonDeleteSelected(object sender, EventArgs e)
            {
                if (lb1.Text == "")
                    lb.Items.RemoveAt(lb.SelectedIndex);
                if (lb.Text == "")
                    lb1.Items.RemoveAt(lb1.SelectedIndex);
            }

            btn9 = new Button();
            btn9.Height = 30;
            btn9.Width = 100;
            btn9.Text = "Сортировать";
            btn9.Location = new Point(350, 310);
            btn9.Visible = true;
            btn9.Click += new System.EventHandler(ButtonSortlb2);
            this.Controls.Add(btn9);
            void ButtonSortlb2(object sender, EventArgs e)
            {
                if (cb1.Text == "Алфавит (по возрастанию)")
                    lb1.Sorted = true;
                else if (cb1.Text == "Алфавит (по убыванию)")
                {
                    lb1.Sorted = false;
                    ArrayList list = new ArrayList();
                    foreach (var item in lb1.Items)
                    {
                        list.Add(item);
                    }
                    list.Sort();
                    list.Reverse();
                    lb1.Items.Clear();
                    foreach (var item in list)
                    {
                        lb1.Items.Add(item);
                    }
                }
                else if (cb1.Text == "Длине слова (по возрастанию)")
                {
                    lb1.Sorted = false;
                    for (int i = 0; i < lb1.Items.Count; i++)
                    {
                        for (int j = i; j < lb1.Items.Count; j++)
                        {
                            if (lb1.Items[i].ToString().Length > lb1.Items[j].ToString().Length)
                            {
                                string temp;
                                temp = lb1.Items[i].ToString();
                                lb1.Items[i] = lb1.Items[j];
                                lb1.Items[j] = temp;
                            }
                        }
                    }
                }
                else if (cb1.Text == "Длине слова (по убыванию)")
                {
                    lb1.Sorted = false;
                    for (int i = 0; i < lb1.Items.Count; i++)
                    {
                        for (int j = i; j < lb1.Items.Count; j++)
                        {
                            if (lb1.Items[j].ToString().Length > lb1.Items[i].ToString().Length)
                            {
                                string temp;
                                temp = lb1.Items[j].ToString();
                                lb1.Items[j] = lb1.Items[i];
                                lb1.Items[i] = temp;
                            }
                        }
                    }
                }
            }

            btn10 = new Button();
            btn10.Height = 30;
            btn10.Width = 100;
            btn10.Text = "Очистить";
            btn10.Location = new Point(350, 350);
            btn10.Visible = true;
            btn10.Click += new System.EventHandler(ButtonClear1);
            this.Controls.Add(btn10);
            void ButtonClear1(object sender, EventArgs e)
            {
                lb1.Items.Clear();
            }

            lbl2 = new Label();
            lbl2.Text = "Введи искомое слово";
            lbl2.ForeColor = Color.Black;
            lbl2.Location = new Point(30, 420);
            lbl2.Size = new Size(150, 20);
            lbl2.Visible = true;
            lbl2.BackColor = Color.Orange;
            this.Controls.Add(lbl2);

            txt_box = new TextBox();
            txt_box.BorderStyle = BorderStyle.Fixed3D;
            txt_box.Height = 50;
            txt_box.Width = 170;
            txt_box.Text = "";
            txt_box.Location = new Point(30, 440);
            this.Controls.Add(txt_box);

            lb2 = new ListBox();
            lb2.SelectionMode = SelectionMode.MultiExtended;
            lb2.Location = new Point(30, 470);
            lb2.Size = new Size(170, 160);
            lb2.Visible = true;
            this.Controls.Add(lb2);

            c1 = new CheckBox();
            c1.Text = "Раздел 1";
            c1.Location = new Point(210,470);
            c1.BackColor = Color.Orange;
            c2 = new CheckBox();
            c2.Location = new Point(210, 490);
            c2.Text = "Раздел 2";
            c2.BackColor = Color.Orange;
            c1.Visible = true;
            c2.Visible = true;
            this.Controls.Add(c1);
            this.Controls.Add(c2);

            btn11 = new Button();
            btn11.Height = 70;
            btn11.Width = 100;
            btn11.Text = "Поиск";
            btn11.Location = new Point(210, 550);
            btn11.Visible = true;
            btn11.Click += new System.EventHandler(ButtonSearch);
            this.Controls.Add(btn11);
            void ButtonSearch(object sender, EventArgs e)
            {
                lb2.Items.Clear();

                string Find = txt_box.Text;

                if (c1.Checked)
                {
                    foreach (string String in lb.Items)
                    {
                        if (String.Contains(Find)) lb2.Items.Add(String);
                    }
                }
                if (c2.Checked)
                {
                    foreach (string String in lb1.Items)
                    {
                        if (String.Contains(Find)) lb2.Items.Add(String);
                    }
                }
                if (c1.Checked && c2.Checked)
                {
                    foreach (string String in lb1.Items)
                    {
                        if (String.Contains(Find)) lb2.Items.Add(String);
                    }
                    foreach (string String in lb.Items)
                    {
                        if (String.Contains(Find)) lb2.Items.Add(String);
                    }
                }
            }

            gp = new GroupBox();
            gp.BackColor = Color.Orange;
            gp.Text = "Поиск";
            gp.Location = new Point(20, 400);
            gp.Size = new Size(300, 230);
            this.Controls.Add(gp);  

            btn12 = new Button();
            btn12.Height = 70;
            btn12.Width = 170;
            btn12.Text = "Сброс";
            btn12.Location = new Point(330, 480);
            btn12.Visible = true;
            btn12.Click += new System.EventHandler(ButtonRe);
            this.Controls.Add(btn12);
            void ButtonRe(object sender, EventArgs e)
            {
                lb.Items.Clear();
                lb1.Items.Clear();
                lb2.Items.Clear();
                rtb.Text = string.Empty;
                txt_box.Text = string.Empty;
                r1.Checked = false;
                r2.Checked = false;
                r3.Checked = false;
                c1.Checked = false;
                c2.Checked = false;
            }

            btn13 = new Button();
            btn13.Height = 70;
            btn13.Width = 170;
            btn13.Text = "Выход";
            btn13.Location = new Point(330, 560);
            btn13.Visible = true;
            btn13.Click += new System.EventHandler(ButtonExit);
            this.Controls.Add(btn13);
            void ButtonExit(object sender, EventArgs e)
            {
                Application.Exit();
            }

            pnl = new Panel();
            pnl.Location = new System.Drawing.Point(10,30);
            pnl.Name = "Panel1";
            pnl.Size = new System.Drawing.Size(500, 620);
            pnl.BackColor = Color.LightBlue;
            pnl.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(pnl);

            r1 = new RadioButton();
            r1.Text = "Все";
            r1.Location = new Point(540,540);
            r1.Size = new Size(50,20);
            r2 = new RadioButton();
            r2.Text = "Содержащие цифры";
            r2.Location = new Point(540, 570);
            r2.Size = new Size(150, 20);
            r3 = new RadioButton();
            r3.Text = "Содержащие 'e-mail'";
            r3.Location = new Point(540, 600);
            r3.Size = new Size(150, 20);
            r1.Visible = true;
            r2.Visible = true;
            r3.Visible = true;
            r1.BackColor = Color.GreenYellow;
            r2.BackColor = Color.GreenYellow;
            r3.BackColor = Color.GreenYellow;
            this.Controls.Add(r1);
            this.Controls.Add(r2);
            this.Controls.Add(r3);

            btn14 = new Button();
            btn14.Height = 70;
            btn14.Width = 100;
            btn14.Text = "Начать";
            btn14.Location = new Point(760, 550);
            btn14.Visible = true;
            btn14.Click += new System.EventHandler(ButtonItemsWrite);
            this.Controls.Add(btn14);
            void ButtonItemsWrite(object sender, EventArgs e)
            {
                lb.Items.Clear();
                lb2.Items.Clear();

                lb.BeginUpdate();

                string[] Strings = rtb.Text.Split(new char[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in Strings) 
                {
                    string Str = s.Trim();

                    if (Str == String.Empty) continue;
                    if (r1.Checked) lb.Items.Add(Str);
                    if (r2.Checked)
                    {
                        if (Regex.IsMatch(Str, @"\d")) lb.Items.Add(Str);
                    }
                    if (r3.Checked)
                    {
                        if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) lb.Items.Add(Str);
                    }
                }
                lb.EndUpdate();
            }

            gp1 = new GroupBox();
            gp1.BackColor = Color.GreenYellow;
            gp1.Text = "Выбор слов";
            gp1.Location = new Point(520, 510);
            gp1.Size = new Size(350, 140);
            this.Controls.Add(gp1);

        }



    }
}
