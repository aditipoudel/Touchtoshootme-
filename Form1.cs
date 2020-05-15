using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace catchmeifyoucan
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        int score = 0;
        Random r = new Random();
        int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = r.Next(95, 1100);
            y = r.Next(150, 600);
            pbanimal.Location = new Point(x, y);
           
        }
        int speed = 800;
        bool play = true;

        private void form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
  

        private void pbanimal_Click(object sender, EventArgs e)
        {
            if (play==true){
            score++;
            lblScore.Text = score.ToString();
            timer1.Interval = speed + 1;
            SoundPlayer sp = new SoundPlayer(@"C:\Users\aditi\Desktop\Project\catchmeifyoucan\shotgun-spas_12-RA_The_Sun_God-503834910.wav");
            sp.Play();
          
            }
            if (score == 5)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer(@"C:\Users\aditi\Desktop\Project\catchmeifyoucan\shotgun-spas_12-RA_The_Sun_God-503834910.wav");
                sp.Stop();
                play = false;
                MessageBox.Show("Oh  no you killed me! YOU WON");
               

               
            
            }      
        }

       private void lblScore_Click(object sender, EventArgs e)
        {

       }
    private void pbanimal_MouseClick(object sender, MouseEventArgs e)
      {
    
        }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

        
     
       
    }
}
