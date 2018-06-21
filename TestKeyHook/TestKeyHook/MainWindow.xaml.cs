using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SnagFree.TrayApp.Core;
using TestKeyHook.Helper;
using TestKeyHook.View;

namespace TestKeyHook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Hide();

            SetupKeyboardHooks();

        }


        private GlobalKeyboardHook _globalKeyboardHook;

        public void SetupKeyboardHooks()
        {
            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;
        }

        private DateTime timerStart = new DateTime();
        private DateTime instantKeyPressTime = new DateTime();


        public static int i = 0;

        public static Process topProcess = null;

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            //Debug.WriteLine(e.KeyboardData.VirtualCode);


            if (
                //e.KeyboardData.VirtualCode != GlobalKeyboardHook.VkSnapshot
                //&& e.KeyboardData.VirtualCode != GlobalKeyboardHook.RightAlt
                e.KeyboardData.VirtualCode != GlobalKeyboardHook.F11)
            //if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.SysKeyDown &&
            //    e.KeyboardData.Flags == GlobalKeyboardHook.LlkhfAltdown)
            {
                return;
            }
                
            
            // seems, not needed in the life.
            //if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.SysKeyDown &&
            //    e.KeyboardData.Flags == GlobalKeyboardHook.LlkhfAltdown)
            //{
            //    MessageBox.Show("Alt + Print Screen");
            //    e.Handled = true;
            //}
            //else

            var now = DateTime.Now;

            //因為按鍵持續按下時會極快的持續重複引發這個事件  大約 150ms引發一次
            //所以 如果距離上一次引發大於500ms 就判定是新的一次按下  就重新開始計時
            if (now.Subtract(instantKeyPressTime).TotalMilliseconds > 500)
                timerStart = now;

            instantKeyPressTime = now;

            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {

                Tbx.Text += DateTime.Now.ToString("T") + "KeyDown\n   " + ++i;
                //持續按下的時間長度大於一定秒數
                if (now.Subtract(timerStart).TotalMilliseconds > 1000)
                {
                    timerStart = now;
                    topProcess = ProcessFocus.FindTopProcess();
                    
                    RecordWindow recordWindow = new RecordWindow();
                    recordWindow.Show();
                    recordWindow.Activate();
                    recordWindow.Closing += (o, args) =>
                    {
                        try
                        {
                            ProcessFocus.SendPasteToSpecifcProcessAndSetForeground(topProcess.Id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        
                    };


                    //MessageBox.Show("Key Down last for 1 seconds,\ntopProcess: "+ProcessFocus.FindTopProcess().ProcessName);

                }
                e.Handled = true;
            }
        }

        public void Dispose()
        {
            _globalKeyboardHook?.Dispose();
        }


        private void Exit_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
