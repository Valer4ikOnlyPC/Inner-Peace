using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using System.Media;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace game
{
    public partial class Form1 : Form
    {
        public Bitmap[] pers = { Resource2.spr1, Resource2.spr2, Resource2.spr3, Resource2.spr4, Resource2.spr5 };
        public Bitmap[] pers_l = { Resource3.spr_1, Resource3.spr_2, Resource3.spr_3, Resource3.spr_4, Resource3.spr_5 };
        public Bitmap[] pers_f = { Resource4.файт1, Resource4.файт2, Resource4.файт3, Resource4.файт2 };
        public Bitmap[] pers_u = { Resource7.дамаг1, Resource7.дамаг2, Resource7.дамаг3, Resource7.дамаг2 };
        public Bitmap[] pers_sid = { Resource8.сид1, Resource8.сид2, Resource8.сид1 };
        public Bitmap[] pers_h = { Resource11.Sprite_stand1, Resource11.Sprite_stand2, Resource11.Sprite_stand3,
            Resource11.Sprite_stand4, Resource11.Sprite_stand5, Resource11.Sprite_stand6,Resource11.Sprite_stand7,
            Resource11.Sprite_stand8,Resource11.Sprite_stand9, Resource11.Sprite_stand10,Resource11.Sprite_stand11,
            Resource11.Sprite_stand12,Resource11.Sprite_stand13, Resource11.Sprite_stand14,Resource11.Sprite_stand15,
            Resource11.Sprite_stand16,Resource11.Sprite_stand17 };
        public Bitmap[] pers_h_ = { Resource11.Sprite_stand1, Resource11.Sprite_stand15,
            Resource11.Sprite_stand16, Resource11.Sprite_stand17, Resource11.Sprite_stand18 };
        public Bitmap[] stoit = { Resource6.Sprite1, Resource6.Sprite2 , Resource6.Sprite3 , Resource6.Sprite4 , Resource6.Sprite5 ,
            Resource6.Sprite6 , Resource6.Sprite7 };
        public Bitmap pole_ = Resource1.pole;

        public Bitmap[] poz_s = { Resource5.поц1, Resource5.поц2 , Resource5.поц1 , Resource5.поц2 };
        public Bitmap[] poz_a = { Resource5.поц1, Resource5.поц2 , Resource5.поц1, Resource5.поц2, Resource5.поц3 , Resource5.поц4 };
        public Bitmap[] poz_a2 = { Resource5.поц1, Resource5.поц2 , Resource5.поц3 , Resource5.поц4 , Resource5.поц5 ,
            Resource5.поц6 , Resource5.поц7 , Resource5.поц8 , Resource5.поц9 , Resource5.поц10 };

        public Bitmap[] poz2_s = { Resource10.стоит_1, Resource10.стоит_2, Resource10.стоит_3, Resource10.стоит_4 };
        public Bitmap[] poz2_a = { Resource10.стоит_1, Resource10.стоит_2, Resource10.удар1, Resource10.удар2, Resource10.удар3, Resource10.удар4, Resource10.удар5, Resource10.удар6 };
        public Bitmap[] poz2_a2 = { Resource10.удар_1, Resource10.удар_2 , Resource10.удар_3 , Resource10.удар_4 , Resource10.удар_5 ,
            Resource10.удар_6 , Resource10.удар_7 , Resource10.удар_8 , Resource10.удар_9 };

        public Bitmap[] fon = { Resource1.фон_1, Resource1.фон_2, Resource1.фон_3, Resource1.фон_4 };
        public Bitmap[] fon_ = { Resource1.фон__1, Resource1.фон__2, Resource1.фон__3, Resource1.фон__4 };
        public Bitmap[] fon__ = { Resource1.фон___1, Resource1.фон___2, Resource1.фон___3, Resource1.фон___4, Resource1.фон___5 };

        public Bitmap[] vin__ = { Resource1._1вин, Resource1._1вин, Resource1._3вин, Resource1._4вин, Resource1._5вин,
                        Resource1._6вин, Resource1._7вин, Resource1._8вин, Resource1._9вин, Resource1._10вин, Resource1._11вин,
                        Resource1._12вин, Resource1._13вин };
        public Bitmap[] vin_put = { Resource1.пут1, Resource1.пут2, Resource1.пут3, Resource1.пут4, Resource1.пут5,
                        Resource1.пут6, Resource1.пут7, Resource1.пут8, Resource1.пут9, Resource1.пут10, Resource1.пут11,
                        Resource1.пут12, Resource1.пут13, Resource1.пут14, Resource1.пут15, Resource1.пут16, Resource1.пут17,
                        Resource1.пут18, Resource1.пут19, Resource1.пут20, Resource1.пут21, Resource1.пут22, Resource1.пут23, Resource1.пут24 };
        public Bitmap[] vin_put_ = { Resource1._пут1, Resource1._пут2, Resource1._пут3, Resource1._пут4, Resource1._пут5,
                        Resource1._пут6, Resource1._пут7, Resource1._пут8, Resource1._пут9, Resource1._пут10, Resource1._пут11,
                        Resource1._пут12, Resource1._пут13, Resource1._пут14, Resource1._пут15, Resource1._пут16, Resource1._пут17 };
        public Bitmap[] dead = { Resource12.дым_1, Resource12.дым_2, Resource12.дым_3, Resource12.дым_4, Resource12.дым_5, Resource12.дым_6, Resource12.дым_7, Resource12.дым_8, Resource12.дым_9 };

        public SoundPlayer m1 = new SoundPlayer(Resource9.level1_m);
        public SoundPlayer m2 = new SoundPlayer(Resource9.level2_m);
        public SoundPlayer m3 = new SoundPlayer(Resource9.level3_m);
        public SoundPlayer m4 = new SoundPlayer(Resource9.level4_m);
        public SoundPlayer ending = new SoundPlayer(Resource9.ending);
        public int time__ = 0;
        public int fon_s = 0;
        public int end_ = 0;
        public int vin_n = 0;
        public int vin_p__ = 0;
        public int vin_p_p = 0;
        public int fon_n = 0;
        public int i = 0;
        public int level = 1;
        public int jj = 0;
        public int jp = 0;
        public int move = 5;
        public int start = 0;
        public int startY = 300;
        public int j_raz = 20;
        public int end = 1600;
        public int start0 = 0;
        public int end0 = 1600;
        public int gg_x = 150;
        public int dead_k = 0;
        public int gg_x_start = -60;//novoe
        public int intro = 0;//novoe

        public bool right = true;//false;
        public bool left = false;
        public bool fait = false;

        public int b_x = 650;

        public int konez_polia = 800;

        public bool pol_ur = false;
        public bool ukl = false;
        public bool ukl_v = false;
        public bool heal = false;

        public int ur_gg = 2;
        public int ur_b_sl = 1;
        public int ur_b_si = 5;
        public int heal_n = 4;
        public int heal_spr = 0;
        public int heal_spr_ = 0;

        public int st = 0;

        public bool vin = false;
        public bool GO = false;

        public int hp_gg = 10;
        public int hp_bot = 6;
        public bool b_st = true;

        public bool kkk = true;

        public int p_d = 0; //дамаг счётчик
        public int p_k = 0;
        public int p_p_k = 0;
        public int p_sid = 0;
        public int p_u = 1;

        public bool obn = false;
        public bool stop = true;
        public bool menu = true;
        public bool musik = true;

        public Form1()
        {
            InitializeComponent();
            UpdateStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (checkBox1.Checked == false) musik = false;
            checkBox1.Visible = false;
            this.Controls.Remove(button1);
            BackgroundImage = Resource1.фон_;
            progressBar1.Visible = true;
            progressBar2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            this.timer1.Enabled = true;
            menu = false;
            if(musik==true) m1.PlayLooping();
            this.timer2.Enabled = true;
        }
        void pol_damag(int i)
        {
            hp_gg -= i;
        }
        void bot_hil(int i)
        {
            hp_bot += i;
        }
        void nanes_damaga(int i)
        {
            hp_bot -= i;
            
        }
        private void bot(Graphics b, Bitmap[] poz, Bitmap[] poz1, Bitmap[] poz2,
            int start, int s, int a, int a2, int ur, int x, int y, int bot_pl)
        {
            Rectangle poz_r = new Rectangle(start + b_x + bot_pl - 50, x, 150, y);
            if (start + b_x < 210 && 210 < start + b_x + 50 && b_st == true)
            {
                if (p_k < a && kkk == true)
                {

                    b.DrawImage(poz1[p_k], poz_r);
                    if (p_k == 5 && ukl == false)
                    { pol_ur = true; pol_damag(ur_b_sl); }
                    p_k++;
                    if (p_k == a)
                    { p_k = 0; kkk = false; p_u++; }
                }
                else if (p_u == 5)
                {
                    kkk = false;
                    b.DrawImage(poz2[p_k], poz_r);
                    if (p_k == ur)
                    { pol_ur = true; pol_damag(ur_b_si); }
                    p_k++;
                    if (p_k == a2)
                    { p_k = 0; kkk = true; p_u = 1; }
                }
                else
                {
                    if (p_k >= s)
                    { p_k = 0; }
                    b.DrawImage(poz[p_k], poz_r);
                    p_k++;
                    if(p_k==4) p_p_k++;
                    if (p_p_k == 1)
                    {
                        p_p_k = 0;
                        p_k = 0;
                        kkk = true;
                    }
                }
                if (hp_bot < 1)
                {
                    b_st = false;
                    //level++;
                }
            }
            else if (b_st == true)
            {
                if (p_k >= s)
                { p_k = 0; }
                b.DrawImage(poz[p_k], poz_r);
                p_k++;
                if (p_k >= s)
                { p_k = 0; }
            }
            else
            {
                if (dead_k < 5)
                {
                    b.DrawImage(poz[0], poz_r);
                    b.DrawImage(dead[dead_k], new Rectangle(start + b_x + bot_pl - 50, 250, 150, 150));
                }
                else if (dead_k < 8)
                {
                    b.DrawImage(dead[dead_k], new Rectangle(start + b_x + bot_pl - 50, 250, 150, 150));
                }
                else b.DrawImage(dead[8], new Rectangle(start + b_x + bot_pl - 50, 250, 150, 150));
                dead_k++;
            }
        }
        void gg (PaintEventArgs e)
        {
            Graphics f = e.Graphics;
            if (fon_n == 1)
            {
                f.DrawImage(fon__[fon_s], new Rectangle(0, 0, 800, 500));
                fon_s++;
                if (fon_s == 5)
                { fon_s = 0; }
            }
            else if(fon_n == 2)
            {
                f.DrawImage(fon_[fon_s], new Rectangle(0, 0, 800, 500));
                fon_s++;
                if (fon_s == 4)
                { fon_s = 0; }
            }
            else if (fon_n == 3)
            {
                f.DrawImage(fon[fon_s], new Rectangle(0, 0, 800, 500));
                fon_s++;
                if (fon_s == 4)
                { fon_s = 0; }
            }
            Graphics b = e.Graphics;
            Graphics g = e.Graphics;
            Graphics pole = e.Graphics;
            if(hp_gg<=0) progressBar1.Value = 0;
            else progressBar1.Value = hp_gg;
            if(heal_n>4) progressBar2.Value = 4;
            else progressBar2.Value = heal_n;

            progressBar1.SetState(ColorBar.Color.Red, progressBar1.Value);
            progressBar2.SetState(ColorBar.Color.Yellow, progressBar2.Value);

            if (start == -600 || (start==0 && intro==0))
            {
                right = true;
                move = 10;
            }
            if (right == true)
            {
                if (start + b_x +10 < 210 && b_st == true)
                {
                    right = false;
                    pole.DrawImage(pole_, new Rectangle(start0, 350, end0, 150));
                    start0 = start0 + move;
                    g.DrawImage(pers_u[p_d], new Rectangle(150, 300, 80, 100));
                    p_d++;
                    if (p_d == 4)
                    { p_d = 0; pol_ur = false; }
                    start = start0;
                }
                else
                {
                    left = false;
                    fait = false;
                    if (gg_x_start < 150)
                    {
                        pole.DrawImage(pole_, new Rectangle(start, 350, end, 150));
                        g.DrawImage(pers[i], new Rectangle(gg_x_start, 300, 60, 100));
                        gg_x_start += move;
                        if (gg_x_start == 150)
                        { 
                            right = false;
                            intro += 1;
                            move = 5;
                        }
                        i++;
                        if (i == 5)
                        { i = 0; }
                    }
                    else if(start == -600)
                    {
                        pole.DrawImage(pole_, new Rectangle(start, 350, end, 150));
                        g.DrawImage(pers[i], new Rectangle(gg_x, 300, 60, 100));
                        gg_x += move;
                        if (gg_x == 800)
                        {
                            menu = true;
                            vin = true;
                            right = false;
                            level++;
                        }
                        i++;
                        if (i == 5)
                        { i = 0; }
                    }
                    else
                    {
                        pole.DrawImage(pole_, new Rectangle(start, 350, end, 150));
                        start = start - move;
                        g.DrawImage(pers[i], new Rectangle(150, 300, 60, 100));
                        i++;
                        if (i == 5)
                        { i = 0; }
                        start0 = start;
                    }
                }
            }
            else if (pol_ur == true)
            {
                //анимация получения урона
                pole.DrawImage(pole_, new Rectangle(start0, 350, end0, 150));
                start0 = start0 + move;
                g.DrawImage(pers_u[p_d], new Rectangle(150, 300, 80, 100));
                p_d++;
                if (p_d == 4)
                { p_d = 0; pol_ur = false; }
                start = start0;
                if (hp_gg < 1)
                {
                    menu = true;
                    GO = true;
                    level = 1;
                }
            }
            else if (ukl == true)
            {
                //анимация уклонения
                pole.DrawImage(pole_, new Rectangle(start0, 350, end0, 150));
                g.DrawImage(pers_sid[p_sid], new Rectangle(150, 300, 60, 100));
                p_sid++;
                if (p_sid == 2)
                { p_sid = 1; }
            }
            else if (ukl_v == true)
            {
                //анимация уклонения
                pole.DrawImage(pole_, new Rectangle(start0, 350, end0, 150));
                g.DrawImage(pers_sid[2], new Rectangle(150, 300, 60, 100));
                if (1>0)
                { p_sid = 0; ukl_v = false; }
            }
            else if (left == true)
            {
                right = false;
                fait = false;
                if (start0 == 0)
                {
                    left = false;
                    pole.DrawImage(pole_, new Rectangle(start0, 350, end0, 150));
                    g.DrawImage(pers_l[0], new Rectangle(150, 300, 60, 100));
                }
                else 
                {
                    pole.DrawImage(pole_, new Rectangle(start0, 350, end0, 150));
                    start0 = start0 + move;
                    g.DrawImage(pers_l[i], new Rectangle(150, 300, 60, 100));
                    i++;
                    if (i == 5)
                    { i = 0; }
                    start = start0;
                }
            }
            else if (fait == true)
            {
                left = false;
                right = false;
                pole.DrawImage(pole_, new Rectangle(start0, 350, end0, 150));
                g.DrawImage(pers_f[jj], new Rectangle(150, 300, 80, 100));
                if (jj == 2 && start + b_x < 210)
                { nanes_damaga(ur_gg); }
                jj++;
                if (jj == 4)
                { jj = 0; fait = false; }
            }
            else if(heal == true)
            {
                left = false;
                right = false;
                pole.DrawImage(pole_, new Rectangle(start, 350, end, 150));
                if (heal_n != 0 && start + b_x <= 670 && start + b_x > 210 && hp_gg < 10)
                {
                    g.DrawImage(pers_h[heal_spr], new Rectangle(150, 300, 60, 100));
                    heal_spr++;
                    if (heal_spr == 17)
                    { heal_spr = 0; heal_n--; hp_gg = 10; heal = false; }
                }
                else
                {
                    g.DrawImage(pers_h_[heal_spr_], new Rectangle(150, 300, 60, 100));
                    heal_spr_++;
                    if (heal_spr_ == 5)
                    { heal_spr_ = 0; heal = false; }
                }
            }
            else
            {
                pole.DrawImage(pole_, new Rectangle(start, 350, end, 150));
                g.DrawImage(stoit[st], new Rectangle(150, 300, 60, 100));
                st++;
                if (st == 7)
                { st = 0; }
            }
            if (level < 3) bot(b, poz_s, poz_a, poz_a2, start, 4, 6, 10, 8, 250, 150, 0);
            else bot(b, poz2_s, poz2_a, poz2_a2, start, 4, 8, 9, 7, 280, 120, 5);
        }
        void obnul(int kavo,int hp_)
        {
            if (kavo == 1)
            {
                BackgroundImage = Resource1.фон_;
                pole_ = Resource1.pole;
                this.timer1.Interval = 70;                
                hp_gg = 10;
                heal_n = 4;
                ur_gg = 3;
                ur_b_sl = 1;
                ur_b_si = 3;
                fon_n = 0;
                if (musik == true) m1.PlayLooping();
            }
            else if (kavo == 2)
            {
                pole_ = Resource1.pole___;
                this.timer1.Interval = 65;
                hp_gg = hp_;
                ur_gg = 3;
                ur_b_sl = 2;
                ur_b_si = 4;
                fon_n = 1;
                if (musik == true) m2.PlayLooping();
            }
            else if (kavo == 3)
            {
                pole_ = Resource1.pole1;
                this.timer1.Interval = 65;
                hp_gg = hp_;
                ur_gg = 2;
                ur_b_sl = 2;
                ur_b_si = 4;
                fon_n = 2;
                if (musik == true) m3.PlayLooping();
            }
            else if (kavo == 4)
            {
                pole_ = Resource1.pole2;
                this.timer1.Interval = 60;
                hp_gg = hp_;
                ur_gg = 1;
                ur_b_sl = 2;
                ur_b_si = 4;
                fon_n = 3;
                if (musik == true) m4.PlayLooping();
            }
            i = 0;
            jj = 0;
            jp = 0;
            move = 5;
            start = 0;
            startY = 300;
            j_raz = 20;
            end = 1600;
            start0 = 0;
            end0 = 1600;
            gg_x = 150;
            gg_x_start = -60;
            intro = 0;
            fon_s = 0;
            dead_k = 0;

            right = false;
            left = false;
            fait = false;
                         
            b_x = 700;
                         
            konez_polia = 800;
                         
            pol_ur = false;
            ukl = false;
                         
            st = 0;
                         
            vin = false;
            GO = false;

            //hp_;
            hp_bot = 6;
            b_st = true;
                         
            kkk = true;
                         
            p_d = 0; //дамаг счётчик
            p_k = 0;
            p_u = 1;
            obn = false;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (hp_gg > 10)
            { hp_gg = 1; }
            if (hp_gg == hp_gg - 1)
            { this.Close(); }
            if (menu == false)
            {
                gg(e);
            }
            else if (vin == true)
            {
                //m1.Stop();
                //m2.Stop();
                button2.Visible = true;
                if (level == 5)
                {
                    //button2.Visible = false;
                    this.timer1.Interval = 100;
                    
                    label2.Location = new Point(339, 410);
                    button2.Location = new Point(325, 435);
                    label2.Text = "Ты победил!";
                    button2.Text = "close";
                    button2.Click += button2_click3;
                    Graphics v = e.Graphics;
                    v.DrawImage(vin__[vin_n], new Rectangle(50, 0, 800, 600));
                    v.DrawImage(vin_put[vin_p__], new Rectangle(10, 75, 150, 300));
                    v.DrawImage(vin_put_[vin_p_p], new Rectangle(600, 75, 200, 300));
                    vin_n++;
                    vin_p__++;
                    vin_p_p++;
                    if (vin_n == 13) vin_n = 0;
                    if (vin_p__ == 24) vin_p__ = 0;
                    if (vin_p_p == 17) vin_p_p = 0;
                    
                    if (end_ == 0)
                    {
                        this.timer2.Enabled = false;
                        if (musik == true) ending.Play();
                        end_++;
                        this.label12.Text = Convert.ToString(time__);
                        this.label11.Visible = true;
                        this.label12.Visible = true;
                        this.label13.Visible = true;
                        int ww = label12.Size.Width;
                        label13.Location = new Point(190+ww,437);
                    }
                }
                else 
                {
                    label2.Text = "Так держать";
                    button2.Text = "next";
                    button2.Click += button2_click1;
                }
                progressBar1.Visible = false;
                progressBar2.Visible = false;
                label2.Visible = true;
                BackgroundImage = null;
                BackColor = Color.Black;
                obn = true;
            }
            else if (GO == true)
            {
                //m1.Stop();
                //m2.Stop();
                progressBar1.Visible = false;
                progressBar2.Visible = false;
                label2.Visible = true;
                label2.Text = "Ты проиграл!";
                button2.Visible = true;
                button2.Text = "restart";
                button2.Click += button2_click1;
                BackgroundImage = null;
                BackColor = Color.Black;
                obn = true;
            }
        }
        private void button2_click1(object sender, EventArgs e)
        {
            label2.Visible = false;
            button2.Visible = false;
            progressBar1.Visible = true;
            progressBar2.Visible = true;
            if (obn == true)
            {
                obnul(level,hp_gg);
                this.Enabled = false;
            }
            menu = false;
            this.Enabled = true;
        }
        private void button2_click3(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                ukl = true;
            }
            if(e.KeyCode == Keys.D)
            {
                right = true;
            }
            if (e.KeyCode == Keys.E)
            {
                fait = true;
            }
            if (e.KeyCode == Keys.O)
            {
                heal_n=90;
            }
            if (e.KeyCode == Keys.H)
            {
                heal = true;
            }
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.S)
            {
                ukl = false;
                ukl_v = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time__++;
        }
    }
    public static class ColorBar
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public enum Color { None, Green, Red, Yellow }

        public static void SetState(this ProgressBar pBar, Color newColor, int newValue)
        {
            if (pBar.Value == pBar.Minimum)
            { 
                pBar.Value = pBar.Maximum;
                SendMessage(pBar.Handle, 1040, (IntPtr)(int)Color.Green, IntPtr.Zero);
            }
            pBar.Value = newValue;
            SendMessage(pBar.Handle, 1040, (IntPtr)(int)Color.Green, IntPtr.Zero);
            SendMessage(pBar.Handle, 1040, (IntPtr)(int)newColor, IntPtr.Zero);
        }

    }
}
