namespace WindowsFormsApp1
{
    partial class AirTicketBooking
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
            this.lsbFlightList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConfim = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtRegistrationinfo = new System.Windows.Forms.RichTextBox();
            this.btnShowListFlight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbFlightList
            // 
            this.lsbFlightList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbFlightList.FormattingEnabled = true;
            this.lsbFlightList.ItemHeight = 24;
            this.lsbFlightList.Location = new System.Drawing.Point(28, 48);
            this.lsbFlightList.Name = "lsbFlightList";
            this.lsbFlightList.Size = new System.Drawing.Size(190, 316);
            this.lsbFlightList.TabIndex = 0;
            this.lsbFlightList.SelectedIndexChanged += new System.EventHandler(this.lsbFlightList_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(48, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Create";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConfim
            // 
            this.btnConfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfim.Location = new System.Drawing.Point(435, 394);
            this.btnConfim.Name = "btnConfim";
            this.btnConfim.Size = new System.Drawing.Size(127, 34);
            this.btnConfim.TabIndex = 3;
            this.btnConfim.Text = "Confirm";
            this.btnConfim.UseVisualStyleBackColor = true;
            this.btnConfim.Click += new System.EventHandler(this.btnConfim_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(672, 394);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 34);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Flight ID List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(442, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Registration List";
            // 
            // rtxtRegistrationinfo
            // 
            this.rtxtRegistrationinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtRegistrationinfo.Location = new System.Drawing.Point(268, 48);
            this.rtxtRegistrationinfo.Name = "rtxtRegistrationinfo";
            this.rtxtRegistrationinfo.Size = new System.Drawing.Size(508, 324);
            this.rtxtRegistrationinfo.TabIndex = 7;
            this.rtxtRegistrationinfo.Text = "";
            // 
            // btnShowListFlight
            // 
            this.btnShowListFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowListFlight.Location = new System.Drawing.Point(209, 394);
            this.btnShowListFlight.Name = "btnShowListFlight";
            this.btnShowListFlight.Size = new System.Drawing.Size(156, 31);
            this.btnShowListFlight.TabIndex = 8;
            this.btnShowListFlight.Text = "Show List Flight";
            this.btnShowListFlight.UseVisualStyleBackColor = true;
            this.btnShowListFlight.Click += new System.EventHandler(this.btnShowListFlight_Click);
            // 
            // AirTicketBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowListFlight);
            this.Controls.Add(this.rtxtRegistrationinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnConfim);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsbFlightList);
            this.Name = "AirTicketBooking";
            this.Text = "AirTicketBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbFlightList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConfim;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtRegistrationinfo;
        private System.Windows.Forms.Button btnShowListFlight;
    }
}