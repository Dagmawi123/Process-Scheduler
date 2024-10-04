namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_arrival = new System.Windows.Forms.TextBox();
            this.tb_burst = new System.Windows.Forms.TextBox();
            this.cb_algo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sch = new System.Windows.Forms.Button();
            this.dgv_pro = new System.Windows.Forms.DataGridView();
            this.nud_qua = new System.Windows.Forms.NumericUpDown();
            this.lbl_qua = new System.Windows.Forms.Label();
            this.lbl_pri = new System.Windows.Forms.Label();
            this.tb_pri = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qua)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_arrival
            // 
            this.tb_arrival.Location = new System.Drawing.Point(206, 88);
            this.tb_arrival.Name = "tb_arrival";
            this.tb_arrival.Size = new System.Drawing.Size(153, 20);
            this.tb_arrival.TabIndex = 1;
            // 
            // tb_burst
            // 
            this.tb_burst.Location = new System.Drawing.Point(206, 138);
            this.tb_burst.Name = "tb_burst";
            this.tb_burst.Size = new System.Drawing.Size(159, 20);
            this.tb_burst.TabIndex = 2;
            this.tb_burst.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cb_algo
            // 
            this.cb_algo.FormattingEnabled = true;
            this.cb_algo.Items.AddRange(new object[] {
            "First Come First Serve",
            "Shortest Job First(Preemptive)",
            "Shortest Job First(No-preemptive)",
            "Round Robin",
            "Priority(Preemptive)",
            "Priority(Nonpreemptive)"});
            this.cb_algo.Location = new System.Drawing.Point(77, 43);
            this.cb_algo.Name = "cb_algo";
            this.cb_algo.Size = new System.Drawing.Size(255, 21);
            this.cb_algo.TabIndex = 3;
            this.cb_algo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Processes Arrival Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Processes Burst Time";
            // 
            // btn_Sch
            // 
            this.btn_Sch.BackColor = System.Drawing.Color.Blue;
            this.btn_Sch.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Sch.Location = new System.Drawing.Point(406, 189);
            this.btn_Sch.Name = "btn_Sch";
            this.btn_Sch.Size = new System.Drawing.Size(75, 28);
            this.btn_Sch.TabIndex = 6;
            this.btn_Sch.Text = "Schedule";
            this.btn_Sch.UseVisualStyleBackColor = false;
            this.btn_Sch.Click += new System.EventHandler(this.btn_Sch_Click);
            // 
            // dgv_pro
            // 
            this.dgv_pro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pro.Location = new System.Drawing.Point(2, 223);
            this.dgv_pro.Name = "dgv_pro";
            this.dgv_pro.Size = new System.Drawing.Size(866, 150);
            this.dgv_pro.TabIndex = 7;
            // 
            // nud_qua
            // 
            this.nud_qua.Location = new System.Drawing.Point(168, 182);
            this.nud_qua.Name = "nud_qua";
            this.nud_qua.Size = new System.Drawing.Size(120, 20);
            this.nud_qua.TabIndex = 8;
            this.nud_qua.Visible = false;
            // 
            // lbl_qua
            // 
            this.lbl_qua.AutoSize = true;
            this.lbl_qua.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qua.Location = new System.Drawing.Point(33, 181);
            this.lbl_qua.Name = "lbl_qua";
            this.lbl_qua.Size = new System.Drawing.Size(101, 18);
            this.lbl_qua.TabIndex = 9;
            this.lbl_qua.Text = "Quantum Time";
            this.lbl_qua.Visible = false;
            // 
            // lbl_pri
            // 
            this.lbl_pri.AutoSize = true;
            this.lbl_pri.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pri.Location = new System.Drawing.Point(403, 86);
            this.lbl_pri.Name = "lbl_pri";
            this.lbl_pri.Size = new System.Drawing.Size(115, 18);
            this.lbl_pri.TabIndex = 10;
            this.lbl_pri.Text = "Processes Priority";
            this.lbl_pri.Visible = false;
            // 
            // tb_pri
            // 
            this.tb_pri.Location = new System.Drawing.Point(524, 86);
            this.tb_pri.Name = "tb_pri";
            this.tb_pri.Size = new System.Drawing.Size(100, 20);
            this.tb_pri.TabIndex = 11;
            this.tb_pri.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.tb_pri);
            this.Controls.Add(this.lbl_pri);
            this.Controls.Add(this.lbl_qua);
            this.Controls.Add(this.nud_qua);
            this.Controls.Add(this.dgv_pro);
            this.Controls.Add(this.btn_Sch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_algo);
            this.Controls.Add(this.tb_burst);
            this.Controls.Add(this.tb_arrival);
            this.Name = "Form1";
            this.Text = "Processes Scheduler";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_arrival;
        private System.Windows.Forms.TextBox tb_burst;
        private System.Windows.Forms.ComboBox cb_algo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Sch;
        private System.Windows.Forms.DataGridView dgv_pro;
        private System.Windows.Forms.NumericUpDown nud_qua;
        private System.Windows.Forms.Label lbl_qua;
        private System.Windows.Forms.Label lbl_pri;
        private System.Windows.Forms.TextBox tb_pri;
    }
}

