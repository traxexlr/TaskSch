using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskScheduler;
using static System.DateTime;

namespace 计划任务
{
    public partial class Form1 : Form
    {
        //SchTaskExt schTaskExt;
        public Form1()
        {
            InitializeComponent();
            //schTaskExt = new SchTaskExt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            using (SetDate f = new SetDate())
            {
                f.ShowDialog();
                value = f.value;
            }
            //创建者
            var creator = "Tonge";
            //计划任务名称
            var taskName = "温度";
            //执行的程序路径
            var path = System.Environment.CurrentDirectory + "\\wendu.exe";
            //计划任务执行的频率 PT1M一分钟  PT1H30M 90分钟
            var interval = "PT10080M";
            //开始时间 请遵循 yyyy-MM-ddTHH:mm:ss 格式
            var startBoundary = string.Format("2022-02-0{0}T08:00:01", (value+7).ToString());
            //var description = "this is description";
            _TASK_STATE state = SchTaskExt.CreateTaskScheduler(creator, taskName, path, interval, startBoundary/*, description*/);
            if (state == _TASK_STATE.TASK_STATE_RUNNING)
            {
                MessageBox.Show(string.Format("计划任务部署成功!将于每周{0}运行。", value + 1));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SchTaskExt.DeleteTask("温度");
                MessageBox.Show("计划任务删除成功!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    }

