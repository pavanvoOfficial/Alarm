using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VolumeAndAlarm
{
    class Program
    {// Главная точка входа для приложения.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new SoundForm();// инициализируем форму

            using (NotifyIcon icon = new NotifyIcon())// програмируем значок в трее
            {
                icon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                icon.Click += (s, e) => { form.Show(); form.Activate(); }; // на клик по иконке показыем форму в и фокусимся на ней

                Rectangle workingArea = Screen.GetWorkingArea(form);// находим прямоугольник размером с экран
                form.Location = new Point(workingArea.Right - form.Size.Width,
                                          workingArea.Bottom - form.Size.Height);// програмирум положение формы в нужнем правом углу

                form.Deactivate += (s, e) => form.Hide();// прячем форму если она не в фокусе

                icon.ContextMenu = new ContextMenu(
                    new[]
                    {
                new MenuItem("Тест", (s, e) => SoundForm.Test()),
                new MenuItem("Показать", (s, e) =>{ form.Show(); form.Activate(); }),
                new MenuItem("Закрыть", (s, e) => Application.Exit()),
                    });// програмируем контекстное меню
                icon.Visible = true;

                Application.Run();
                icon.Visible = true;
            }
        }
    }
}
