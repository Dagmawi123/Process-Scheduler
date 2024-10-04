using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    { public int ST;
        public struct process
        {
            public String pid;
           public  int AT;
            public int BT;
            public int bt;
            public int WT ;
            public int TRT;
            public int CT;
            public int done;
            public int priority;
            public int LT;
            public int RT;
            public int REP;
        };
        public Form1()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Welcome To Ethiopia");
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_pri.Visible = false;
            tb_pri.Visible = false;
            lbl_qua.Visible = false;
            nud_qua.Visible = false;
            //if priority is selected number up down and label should be visible
            if (cb_algo.SelectedIndex == 4 || cb_algo.SelectedIndex == 5)
            {
                lbl_pri.Visible = true;
                tb_pri.Visible = true;
            }
            //for round robin
            else if (cb_algo.SelectedIndex == 3) {
                lbl_qua.Visible = true;
                nud_qua.Visible = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void BubbleSort(process[] list, int n)
        {
            process temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j].AT > list[j + 1].AT)
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        public void FCFS(process[] p, int n)
        {
            BubbleSort(p, n);
            //cout<<list[0].name;
            ST = p[0].AT;
            for (int i = 0; i < n; i++)
            {
                if (p[i].AT <= ST)
                {
                    p[i].WT = ST - p[i].AT;
                    p[i].TRT = p[i].BT + p[i].WT;
                    p[i].CT = ST + p[i].BT;
                    ST += p[i].BT;
                }
                else
                {
                    ST = p[i].AT;
                    p[i].WT = ST - p[i].AT;
                    p[i].TRT = p[i].BT + p[i].WT;
                    p[i].CT = ST + p[i].BT;
                    ST += p[i].BT;
                }
            }
        }
        public void SJF(process []p, int n)
        {
            // Sort processes by priority
            BubbleSort(p, n);
            //   checkArrival(pro,n);
            //cout<< "Order in which processes gets executed \n";
            //for (int i = 0 ; i < n; i++)
            //     cout << pro[i].pid <<" " ;

            ST= p[0].AT;
            int curr = 0, completedProcesses = 0;
            while (true)
            {
                int min = 9999;
                curr = -1;
                for (int i = 0; i < n; i++)
                {
                    if (p[i].AT <= ST && p[i].done == 0)
                    {
                        if (p[i].BT < min)
                        {
                            curr = i;
                            min = p[i].BT;
                        }
                    }
                }
                if (completedProcesses == n)
                    break;
                else if (curr != -1)
                {
                    p[curr].WT = ST - p[curr].AT;
                    p[curr].CT = ST + p[curr].BT;
                    p[curr].TRT = p[curr].WT + p[curr].BT;
                    ST += p[curr].BT;
                    p[curr].done = 1;
                    completedProcesses++;
                }
                else
                    ST++;
            }



        }

    
        void PApre(process[] p, int n)
        {
         // Sort processes by priority
            BubbleSort(p, n);
           ST = p[0].AT; int curr = 0, completedProcesses = 0;
            for (int i = 0; i < n; i++)
            {
                p[i].bt = p[i].BT;
            }
            while (completedProcesses != n)
            {
                int max = 9999;
                curr = -1;
                for (int i = 0; i < n; i++)
                {
                    if (p[i].AT <= ST && p[i].done == 0)
                    {
                        if (p[i].priority < max)
                        {
                            curr = i;
                            max = p[i].priority;
                        }
                    }
                }
                if (curr != -1)
                {
                    if (p[curr].REP == 0)
                    {
                        if (p[curr].BT - 1 == 0)
                        {
                            p[curr].WT = ST - p[curr].AT;
                            p[curr].RT = ST - p[curr].AT;
                            p[curr].CT = ST + 1;
                            p[curr].TRT = p[curr].WT + p[curr].bt;
                            ST += 1;
                            p[curr].BT--;
                            p[curr].done = 1;
                            p[curr].REP = 1;
                            completedProcesses++;
                        }
                        else if (p[curr].BT - 1 != 0)
                        {
                            p[curr].LT = ST + 1;
                            p[curr].WT = ST - p[curr].AT;
                            p[curr].RT = ST - p[curr].AT;
                            ST++;
                            p[curr].REP = 1;
                            p[curr].BT--;
                        }
                    }
                    else
                    {
                        if (p[curr].BT - 1 == 0)
                        {
                            //p[curr].Wt+=St-p[curr].At;
                            p[curr].CT = ST + 1;
                            p[curr].TRT = p[curr].WT + p[curr].bt;
                            p[curr].WT += ST - p[curr].LT;
                            ST += 1;
                            p[curr].BT--;
                            p[curr].done = 1;
                            completedProcesses++;
                        }
                        else
                        {
                            p[curr].BT--;
                            p[curr].WT += ST - p[curr].LT;
                            ST++;
                            p[curr].LT = ST;
                        }
                    }

                }
                else
                    ST++;
            }

        }
       public void PANpre(process []p, int n)
        {
            // Sort processes by priority
            BubbleSort(p, n);
            //   checkArrival(pro,n);
            //cout<< "Order in which processes gets executed \n";
            //for (int i = 0 ; i < n; i++)
            //     cout << pro[i].pid <<" " ;

            ST = p[0].AT; int curr = -1, completedProcesses = 0;
            while (true)
            {
                int max = 9999; curr=-1;
                for (int i = 0; i < n; i++)
                {
                    if (p[i].AT <= ST && p[i].done == 0)
                    {
                        if (p[i].priority < max)
                        {
                            curr = i;
                            max = p[i].priority;
                        }
                    }
                }
                if (completedProcesses == n)
                    break;
                else if (curr != -1)
                {
                    p[curr].WT = ST - p[curr].AT;
                    p[curr].CT = ST + p[curr].BT;
                    p[curr].TRT = p[curr].WT + p[curr].BT;
                    ST += p[curr].BT;
                    p[curr].done = 1;
                    completedProcesses++;
                    curr = -1;
                }
                else
                    ST++;
            }
           


        }
        public void SRTF(process []p, int n)
        {
           BubbleSort(p, n);
            for(int i=0;i<n;i++) {
                p[i].bt = p[i].BT;
            }
            ST = p[0].AT; int curr = 0, completedProcesses = 0;
            while (completedProcesses != n)
            {
                curr = -1;
                int max = 9999;
                for (int i = 0; i < n; i++)
                {
                    if (p[i].AT <= ST && p[i].done == 0)
                    {
                        if (p[i].BT < max)
                        {
                            curr = i;
                            max = p[i].BT;
                        }
                    }
                }

                if (curr != -1)
                {
                    if (p[curr].REP == 0)
                    {
                        if (p[curr].BT - 1 == 0)
                        {
                            p[curr].WT = ST - p[curr].AT;
                            p[curr].RT = ST - p[curr].AT;
                            p[curr].CT = ST + 1;
                            p[curr].TRT = p[curr].WT + p[curr].bt;
                            ST += 1;
                            p[curr].BT--;
                            p[curr].done = 1;
                            p[curr].REP = 1;
                            completedProcesses++;
                        }
                        else if (p[curr].BT - 1 != 0)
                        {
                            p[curr].LT = ST + 1;
                            p[curr].WT = ST - p[curr].AT;
                            p[curr].RT = ST - p[curr].AT;
                            ST++;
                            p[curr].REP = 1;
                            p[curr].BT--;
                        }
                    }
                    else
                    {
                        if (p[curr].BT - 1 == 0)
                        {
                            //p[curr].Wt+=St-p[curr].At;
                            p[curr].CT = ST + 1;
                            p[curr].TRT = p[curr].WT + p[curr].bt;
                            p[curr].WT += ST - p[curr].LT;
                            ST += 1;
                            p[curr].BT--;
                            p[curr].done = 1;
                            completedProcesses++;
                        }
                        else
                        {
                            p[curr].BT--;
                            p[curr].WT += ST - p[curr].LT;
                            ST++;
                            p[curr].LT = ST;
                        }
                    }

                }
                else ST++;

            }


        }





        private void btn_Sch_Click(object sender, EventArgs e)
        {
            int s = cb_algo.SelectedIndex;
            if (s == 0)
            {
                //accept user entry and convert to process instances
                char[] separator = { ' ' };
                String[] arr = tb_arrival.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String[] bur = tb_burst.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int length = arr.Length;
                process[] pro = new process[length];
                for (int i = 0; i < length; i++)
                {
                    pro[i].AT = int.Parse(arr[i]);
                    pro[i].BT = int.Parse(bur[i]);
                }
                //schedule
                FCFS(pro, length);

                //fill the data grid biew with the result
                DataTable table = new DataTable();
                table.Columns.Add("Processes Name", typeof(String));
                table.Columns.Add("Arrival Time", typeof(int));
                table.Columns.Add("Burst Time", typeof(int));
                table.Columns.Add("Waiting Time", typeof(int));
                table.Columns.Add("Completion Time", typeof(int));
                table.Columns.Add("Turn Around Time", typeof(int));
                for (int p = 0; p < length; p++)
                {
                    table.Rows.Add("p" + p, pro[p].AT, pro[p].BT, pro[p].WT, pro[p].CT, pro[p].TRT);

                }

                dgv_pro.DataSource = table;
            }
            //Sjf pre
            else if (s == 1)
            {
                char[] separator = { ' ' };
                String[] arr = tb_arrival.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String[] bur = tb_burst.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int length = arr.Length;
                process[] pro = new process[length];
                for (int i = 0; i < length; i++)
                {
                    pro[i].AT = int.Parse(arr[i]);
                    pro[i].BT = int.Parse(bur[i]);
                }

                SRTF(pro, length);


                DataTable table = new DataTable();
                table.Columns.Add("Processes Name", typeof(String));
                table.Columns.Add("Arrival Time", typeof(int));
                table.Columns.Add("Burst Time", typeof(int));
                table.Columns.Add("Waiting Time", typeof(int));
                table.Columns.Add("Completion Time", typeof(int));
                table.Columns.Add("Turn Around Time", typeof(int));
                for (int p = 0; p < length; p++)
                {
                    table.Rows.Add("p" + p, pro[p].AT, pro[p].bt, pro[p].WT, pro[p].CT, pro[p].TRT);

                }

                dgv_pro.DataSource = table;



            }
            //Sjf NonPre
            else if (s == 2) {
                char[] separator = { ' ' };
                String[] arr = tb_arrival.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String[] bur = tb_burst.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int length = arr.Length;
                process[] pro = new process[length];
                for (int i = 0; i < length; i++)
                {
                    pro[i].AT = int.Parse(arr[i]);
                    pro[i].BT = int.Parse(bur[i]);
                }

                SJF(pro, length);


                DataTable table = new DataTable();
                table.Columns.Add("Processes Name", typeof(String));
                table.Columns.Add("Arrival Time", typeof(int));
                table.Columns.Add("Burst Time", typeof(int));
                table.Columns.Add("Waiting Time", typeof(int));
                table.Columns.Add("Completion Time", typeof(int));
                table.Columns.Add("Turn Around Time", typeof(int));
                for (int p = 0; p < length; p++)
                {
                    table.Rows.Add("p" + p, pro[p].AT, pro[p].BT, pro[p].WT, pro[p].CT, pro[p].TRT);

                }

                dgv_pro.DataSource = table;



            }
            //Round Robin
            else if (s == 3)
            {
                lbl_qua.Visible = true;
                nud_qua.Visible = true;
            }
            //Priority Pre
            else if (s == 4) {
                char[] separator = { ' ' };
                String[] arr = tb_arrival.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String[] bur = tb_burst.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String[] priorities = tb_pri.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int length = arr.Length;
                process[] pro = new process[length];
                for (int i = 0; i < length; i++)
                {
                    pro[i].AT = int.Parse(arr[i]);
                    pro[i].BT = int.Parse(bur[i]);
                    pro[i].priority = int.Parse(priorities[i]);
                }

                PApre(pro, length);


                DataTable table = new DataTable();
                table.Columns.Add("Processes Name", typeof(String));
                table.Columns.Add("Arrival Time", typeof(int));
                table.Columns.Add("Burst Time", typeof(int));
                table.Columns.Add("Waiting Time", typeof(int));
                table.Columns.Add("Completion Time", typeof(int));
                table.Columns.Add("Turn Around Time", typeof(int));
                table.Columns.Add("Priorities", typeof(int));
                for (int p = 0; p < length; p++)
                {
                    table.Rows.Add("p" + p, pro[p].AT, pro[p].bt, pro[p].WT, pro[p].CT, pro[p].TRT, pro[p].priority);

                }
                dgv_pro.DataSource = table;

            }

            //Priority Non pre
            else if (s == 5)
            {
                char[] separator = { ' ' };
                String[] arr = tb_arrival.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String[] bur = tb_burst.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String[] priorities = tb_pri.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int length = arr.Length;
                process[] pro = new process[length];
                for (int i = 0; i < length; i++)
                {
                    pro[i].AT = int.Parse(arr[i]);
                    pro[i].BT = int.Parse(bur[i]);
                    pro[i].priority = int.Parse(priorities[i]);
                }

                PANpre(pro, length);


                DataTable table = new DataTable();
                table.Columns.Add("Processes Name", typeof(String));
                table.Columns.Add("Arrival Time", typeof(int));
                table.Columns.Add("Burst Time", typeof(int));
                table.Columns.Add("Waiting Time", typeof(int));
                table.Columns.Add("Completion Time", typeof(int));
                table.Columns.Add("Turn Around Time", typeof(int));
                table.Columns.Add("Priorities", typeof(int));
                for (int p = 0; p < length; p++)
                {
                    table.Rows.Add("p" + p, pro[p].AT, pro[p].BT, pro[p].WT, pro[p].CT, pro[p].TRT,pro[p].priority);

                }

                dgv_pro.DataSource = table;

            }

        }
    }
}
