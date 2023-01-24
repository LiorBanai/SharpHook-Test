using CoreAudio;
using SharpHook;
using SharpHook.Native;
using System.Diagnostics;

namespace Test
{
    public partial class Form1 : Form
    {
        private MMDevice defaultDevice;
        private TaskPoolGlobalHook hook;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            MMDeviceEnumerator devEnum = new MMDeviceEnumerator(Guid.Empty); //enumerating multimedia device resources.
            defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia); //initial MMDevice
            defaultDevice.AudioEndpointVolume.OnVolumeNotification += (AudioVolumeNotificationData data) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    TrackBarMaster.Value = (int)(data.MasterVolume * 100);
                }));
            };
            TrackBarMaster.Value = (int)(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);

            TrackBarMaster.Scroll += (object ss, EventArgs e) =>
                defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = (TrackBarMaster.Value / 100.0f);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hook = new TaskPoolGlobalHook();
            hook.KeyTyped += OnKeyTyped;
            hook.KeyPressed += OnKeyPressed;
            hook.RunAsync();

            void OnKeyTyped(object sender, KeyboardHookEventArgs e)
            {
                Invoke(new MethodInvoker(() =>
                {
                    richTextBox1.Text += Environment.NewLine +
                                         $@"Key typed: {e.RawEvent.Keyboard.KeyCode}. Key Char: {e.RawEvent.Keyboard.KeyChar}";
                }));

            }


            void OnKeyPressed(object sender, KeyboardHookEventArgs e)
            {
                if (e.RawEvent.Keyboard.KeyCode is KeyCode.VcVolumeUp or KeyCode.VcVolumeDown)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        switch (e.RawEvent.Keyboard.KeyCode)
                        {
                            case KeyCode.VcVolumeDown:
                                defaultDevice.AudioEndpointVolume.VolumeStepDown();
                                break;
                            case KeyCode.VcVolumeUp:
                                defaultDevice.AudioEndpointVolume.VolumeStepUp();
                                break;
                        }

                        var val = defaultDevice.AudioEndpointVolume.MasterVolumeLevel;
                        richTextBox1.Text += Environment.NewLine +
                                             $@"Key pressed: {e.RawEvent.Keyboard.KeyCode}. Volume: {val}";
                    }));
                }
            }

            void OnHookDisabled(object sender, HookEventArgs e)
            {
                Invoke(new MethodInvoker(() => { richTextBox1.Text += Environment.NewLine + $@"OnHookDisabled"; }));
            }

            void OnHookEnabled(object sender, HookEventArgs e)
            {
                Invoke(new MethodInvoker(() => { richTextBox1.Text += Environment.NewLine + $@"OnHookEnabled"; }));

            }
        }

        private void btnStopHook_Click(object sender, EventArgs e)
        {
            hook?.Dispose();
        }

        private void btnStartExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }
    }
}