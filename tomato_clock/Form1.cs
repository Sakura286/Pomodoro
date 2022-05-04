using NAudio.Wave;

namespace tomato_clock
{
    public partial class Form1 : Form
    {
        private int workTime;
        private int restTime;

        private bool isWork = true;
        string m_start= @"audio\m_start.mp3";
        string m_stop = @"audio\m_stop.mp3";


        private WaveOutEvent outputDevice;
        private AudioFileReader au_start;
        private AudioFileReader au_stop;

        // second remained;
        private int cnt;

#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public Form1()
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        {
            InitializeComponent();
            workTime = 1;
            restTime = 2;
            InitVariables();
            outputDevice = new WaveOutEvent();
            au_start = new AudioFileReader(m_start);
            au_stop = new AudioFileReader(m_stop);
        }

        private void InitVariables()
        {
            // set init data
            
            workTime_TextBox.Text = workTime.ToString();
            restTime_TextBox.Text = restTime.ToString();
            lb_set.Text = "W: "+workTime.ToString()+", R: "+restTime.ToString();
            btn_set.Enabled = false;

            // set timer
            btn_stop.Enabled = false;

            cnt = workTime * 60;
            Set_lb_time(cnt);
            
        }

        private void Set_lb_time(int cnt)
        {
            int hour = cnt / 3600;
            int minute = cnt /60 %60;
            int second = cnt %60 ;
            string s_hour = (hour < 10 ? "0"  :"") + hour.ToString();
            string s_minute = (minute < 10 ? "0" : "") + minute.ToString();
            string s_second = (second < 10 ? "0" : "") + second.ToString();
            lb_time.Text = s_hour + " : " + s_minute + " : " + s_second;
        }

        private bool IsValid(string str)
        {
            return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (IsValid(workTime_TextBox.Text) && IsValid(restTime_TextBox.Text)){
                workTime = Convert.ToInt32(workTime_TextBox.Text);
                restTime = Convert.ToInt32(restTime_TextBox.Text);
                lb_set.Text = "W: " + workTime.ToString() + ", R: " + restTime.ToString();
                btn_set.Enabled = false;

                
                
            }
        }

        private void workTime_TextChanged(object sender, EventArgs e)
        {
            btn_set.Enabled = true;
        }

        private void restTime_TextBox_TextChanged(object sender, EventArgs e)
        {
            btn_set.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cnt > 0) {
                cnt--;
                Set_lb_time(cnt);
            }
            else
            {
                Set_lb_time(cnt);
                timer1.Stop();
                if (isWork)
                {
                    cnt = restTime * 60;
                    isWork = false;
                    outputDevice.Init(au_start);
                    outputDevice.Play();
                }
                else
                {
                    cnt = workTime * 60;
                    isWork = true;
                    outputDevice.Init(au_stop);
                    outputDevice.Play();
                }
                btn_start.Enabled = true;
                btn_stop.Enabled = false;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            outputDevice.Stop();
            Set_lb_time(cnt);
            btn_start.Text = "继续";
            timer1.Start();
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Set_lb_time(cnt);
            timer1.Stop();
            btn_start.Enabled = true;
            btn_stop.Enabled=false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            outputDevice.Stop();
            btn_start.Text = "开始";
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            cnt = workTime * 60;
            Set_lb_time(cnt);
            isWork = true;
        }
    }
}