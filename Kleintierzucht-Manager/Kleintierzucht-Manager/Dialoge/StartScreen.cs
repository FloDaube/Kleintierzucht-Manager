using Kleintierzucht_Manager.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kleintierzucht_Manager.Dialoge
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            label_StatusText.Text = "Initialisiere start von Kleintierzucht-Manager";
            timer_StartLoading.Enabled = true;
        }

        private void timer_StartLoading_Tick(object sender, EventArgs e)
        {
            timer_StartLoading.Enabled = false;
            Thread.Sleep(1000);
            //1. Checking Update
            label_StatusText.Text = "Lade Settings";
            Settings settings = new Settings();
            settings.LoadSettings();
            Thread.Sleep(1000);
            //
            //2. Lese Einstellungen
            label_StatusText.Text = "Lese Einstellungen";
            Thread.Sleep(1000);
            //
            //3. Lade Daten
            label_StatusText.Text = "Lade Daten";
            //



        }
    }
}
