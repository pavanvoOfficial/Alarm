using CoreAudioApi;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace VolumeAndAlarm
{
    public partial class SoundForm : System.Windows.Forms.Form
    {
        private MMDevice device;

        static WMPLib.WindowsMediaPlayer WMP;

        static string LastSound = "06 - I Am Machine (online-audio-converter.com).wav";// здесь может быть любая музычка в формать *.wav или mp3 из коня программы

        //[System.Runtime.InteropServices.DllImport("wmp.dll")]// извлекае метод из библеотеки
        //private static extern
        //Boolean PlaySound(string lpszName, int hModule, int dwFlags);

        public SoundForm()// конструктор класса 
        {
            InitializeComponent();
            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();//инициализируем  перечесление девайсов
            device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);//выбираем девайс по умолчанию
            trackBarVolume.Value = (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);// мы приваеваем нашим контролам значения громкости
            labelVolume.Text = $"{trackBarVolume.Value}";
            device.AudioEndpointVolume.OnVolumeNotification += new AudioEndpointVolumeNotificationDelegate(
                AudioEndpointVolume_OnVolumeNotification);//присваиваем событие измения громкости
            WMP = new WMPLib.WindowsMediaPlayer();
        }

        void AudioEndpointVolume_OnVolumeNotification(AudioVolumeNotificationData data) 
        {
            if (this.InvokeRequired)//если изменения не из нашего приложения 
            {
                object[] Params = new object[1];
                Params[0] = data;// создаём массив параметров и передаём их с помощью Invoke()!!! в главный дескриптор окна формы
                this.Invoke(new AudioEndpointVolumeNotificationDelegate(AudioEndpointVolume_OnVolumeNotification), Params);
            }
            else
            {//иначе либо это из нашего прирожения либо через Invoke() переданые изменения 
                trackBarVolume.Value = (int)(data.MasterVolume * 100);// мы приваеваем нашим контролам любые изменения громкости
                labelVolume.Text = $"{trackBarVolume.Value}";
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            device.AudioEndpointVolume.MasterVolumeLevelScalar = trackBarVolume.Value / 100.0f;// присваеваем девайсу значение
            labelVolume.Text = $"{trackBarVolume.Value}";// отображаем
        }


        private void buttonMute_Click(object sender, EventArgs e)//Выключение-включение звука
        {
            if (!device.AudioEndpointVolume.Mute) { device.AudioEndpointVolume.Mute = true; buttonMute.Text = "UnMute"; }
            else { device.AudioEndpointVolume.Mute = false; buttonMute.Text = "Mute"; }//
        }

        private void MainForm_Shown(object sender, EventArgs e)//метод присвое на событие показа формы
        {
            if (device.AudioEndpointVolume.Mute) { buttonMute.Text = "UnMute"; }// сверяемся 
            else { buttonMute.Text = "Mute"; }
        }

        private void buttonTest_Click(object sender, EventArgs e)=>
            Test();

        public static void Test()
        {
            if (WMP.status.Contains("Остановлено") || WMP.status == string.Empty)
            {
                WMP.URL = LastSound;
                WMP.controls.play();
            }
            else { WMP.controls.stop();}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WMP.controls.stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы wav|*.wav|Файлы mp3|*.mp3";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                LastSound = OPF.FileName;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var hour = DateTime.Now.Hour.ToString();
            var minute = DateTime.Now.Minute.ToString();
            if (WMP.status.Contains("Остановлено") || WMP.status == string.Empty)
            {   
                if (hour == numericHour.Value.ToString() && minute == numericMinute.Value.ToString())
                {
                    Test();
                }
            }
        }
    }
}
