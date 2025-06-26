namespace GUI_client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Survey = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            send = new Button();
            Station = new Button();
            RailDirection = new Button();
            Railway = new Button();
            RailwayFare = new Button();
            StationTimetable = new Button();
            TrainInformation = new Button();
            TrainTimetable = new Button();
            StationAndRailwayFare = new Button();
            StationAndSurvey = new Button();
            StationAndTimetable = new Button();
            TrainType = new Button();
            SuspendLayout();
            // 
            // Survey
            // 
            Survey.Location = new Point(12, 392);
            Survey.Name = "Survey";
            Survey.Size = new Size(97, 50);
            Survey.TabIndex = 0;
            Survey.Text = "Survey";
            Survey.UseVisualStyleBackColor = true;
            Survey.Click += Survey_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(436, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(573, 594);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 35);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 287);
            textBox2.TabIndex = 2;
            textBox2.MouseDown += textBox2_MouseDown;
            // 
            // send
            // 
            send.Location = new Point(12, 328);
            send.Name = "send";
            send.Size = new Size(406, 38);
            send.TabIndex = 3;
            send.Text = "Send";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // Station
            // 
            Station.Location = new Point(12, 448);
            Station.Name = "Station";
            Station.Size = new Size(97, 50);
            Station.TabIndex = 4;
            Station.Text = "Station";
            Station.UseVisualStyleBackColor = true;
            Station.Click += Station_Click;
            // 
            // RailDirection
            // 
            RailDirection.Location = new Point(115, 392);
            RailDirection.Name = "RailDirection";
            RailDirection.Size = new Size(97, 50);
            RailDirection.TabIndex = 5;
            RailDirection.Text = "Rail Direction";
            RailDirection.UseVisualStyleBackColor = true;
            RailDirection.Click += RailDirection_Click;
            // 
            // Railway
            // 
            Railway.Location = new Point(218, 392);
            Railway.Name = "Railway";
            Railway.Size = new Size(97, 50);
            Railway.TabIndex = 6;
            Railway.Text = "Railway";
            Railway.UseVisualStyleBackColor = true;
            Railway.Click += Railway_Click;
            // 
            // RailwayFare
            // 
            RailwayFare.Location = new Point(321, 392);
            RailwayFare.Name = "RailwayFare";
            RailwayFare.Size = new Size(97, 50);
            RailwayFare.TabIndex = 7;
            RailwayFare.Text = "Railway Fare";
            RailwayFare.UseVisualStyleBackColor = true;
            RailwayFare.Click += RailwayFare_Click;
            // 
            // StationTimetable
            // 
            StationTimetable.Location = new Point(115, 448);
            StationTimetable.Name = "StationTimetable";
            StationTimetable.Size = new Size(97, 50);
            StationTimetable.TabIndex = 8;
            StationTimetable.Text = "Station Timetable";
            StationTimetable.UseVisualStyleBackColor = true;
            StationTimetable.Click += StationTimetable_Click;
            // 
            // TrainInformation
            // 
            TrainInformation.Location = new Point(218, 448);
            TrainInformation.Name = "TrainInformation";
            TrainInformation.Size = new Size(97, 50);
            TrainInformation.TabIndex = 9;
            TrainInformation.Text = "Train Information";
            TrainInformation.UseVisualStyleBackColor = true;
            TrainInformation.Click += TrainInformation_Click;
            // 
            // TrainTimetable
            // 
            TrainTimetable.Location = new Point(321, 448);
            TrainTimetable.Name = "TrainTimetable";
            TrainTimetable.Size = new Size(97, 50);
            TrainTimetable.TabIndex = 10;
            TrainTimetable.Text = "Train Timetable";
            TrainTimetable.UseVisualStyleBackColor = true;
            TrainTimetable.Click += TrainTimetable_Click;
            // 
            // StationAndRailwayFare
            // 
            StationAndRailwayFare.Location = new Point(321, 504);
            StationAndRailwayFare.Name = "StationAndRailwayFare";
            StationAndRailwayFare.Size = new Size(97, 50);
            StationAndRailwayFare.TabIndex = 11;
            StationAndRailwayFare.Text = "Station + Railway Fare";
            StationAndRailwayFare.UseVisualStyleBackColor = true;
            StationAndRailwayFare.Click += StationAndRailwayFare_Click;
            // 
            // StationAndSurvey
            // 
            StationAndSurvey.Location = new Point(218, 504);
            StationAndSurvey.Name = "StationAndSurvey";
            StationAndSurvey.Size = new Size(97, 50);
            StationAndSurvey.TabIndex = 12;
            StationAndSurvey.Text = "Station + Survey";
            StationAndSurvey.UseVisualStyleBackColor = true;
            StationAndSurvey.Click += StationAndSurvey_Click;
            // 
            // StationAndTimetable
            // 
            StationAndTimetable.Location = new Point(115, 504);
            StationAndTimetable.Name = "StationAndTimetable";
            StationAndTimetable.Size = new Size(97, 50);
            StationAndTimetable.TabIndex = 13;
            StationAndTimetable.Text = "Station + Timetable";
            StationAndTimetable.UseVisualStyleBackColor = true;
            StationAndTimetable.Click += StationAndTimetable_Click;
            // 
            // TrainType
            // 
            TrainType.Location = new Point(12, 504);
            TrainType.Name = "TrainType";
            TrainType.Size = new Size(97, 50);
            TrainType.TabIndex = 14;
            TrainType.Text = "Train Type";
            TrainType.UseVisualStyleBackColor = true;
            TrainType.Click += TrainType_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 618);
            Controls.Add(TrainType);
            Controls.Add(StationAndTimetable);
            Controls.Add(StationAndSurvey);
            Controls.Add(StationAndRailwayFare);
            Controls.Add(TrainTimetable);
            Controls.Add(TrainInformation);
            Controls.Add(StationTimetable);
            Controls.Add(RailwayFare);
            Controls.Add(Railway);
            Controls.Add(RailDirection);
            Controls.Add(Station);
            Controls.Add(send);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Survey);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Survey;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button send;
        private Button Station;
        private Button RailDirection;
        private Button Railway;
        private Button RailwayFare;
        private Button StationTimetable;
        private Button TrainInformation;
        private Button TrainTimetable;
        private Button StationAndRailwayFare;
        private Button StationAndSurvey;
        private Button StationAndTimetable;
        private Button TrainType;
    }
}
