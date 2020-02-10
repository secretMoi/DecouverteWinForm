using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Timers;
using System.Windows.Forms;
using DecouverteWinForm.Core.Figures;
using Timer = System.Timers.Timer;

namespace DecouverteWinForm
{
    public partial class FicHorloge : Form
    {
        private Horloge horloge;
        private static bool timerFini = true;
        private const int INTERVAL_TIMER = 990;
        private static Timer loopTimer; // timer qui gère la scène courante
        public FicHorloge()
        {
            InitializeComponent();
            
            Figure.InitialiseConteneur(pictureBox);
            
            horloge = new Horloge(new Point(ClientSize.Width / 2, ClientSize.Height / 2));
            
            loopTimer = new Timer();
        }
        
        private void SetTimer(bool etat, int intervalle = INTERVAL_TIMER, bool autoReset = true)
        {
            loopTimer.Interval = intervalle; //interval in milliseconds
            loopTimer.Enabled = etat;
            loopTimer.Elapsed += LoopTimerEvent; // à effectuer à toutes les intervalles
            loopTimer.AutoReset = autoReset; // le ré enclenche à la fin
        }
        
        private void LoopTimerEvent(Object source, ElapsedEventArgs e)
        {
            // si le timer précédent n'a pas fini ses actions
            if(timerFini == false)
                return;
            
            timerFini = false;
            
            DateTime temps = DateTime.Now;

            horloge.Anime(temps.Hour, temps.Minute, temps.Second);

            pictureBox.Invalidate();

            timerFini = true;
        }
        
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            // redessine toutes les parties des éléments
            horloge.Affiche(e.Graphics);
        }

        private void FicHorloge_Load(object sender, EventArgs e)
        {
            SetTimer(true);
        }
    }
}