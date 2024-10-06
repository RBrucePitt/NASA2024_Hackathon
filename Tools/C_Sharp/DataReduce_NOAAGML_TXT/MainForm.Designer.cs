namespace DataReduce_NOAAGML_TXT
{
    partial class MainForm
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
            Label_MF_InputFile = new Label();
            TextBox_MF_InputFile = new TextBox();
            Button_MF_InputTxt_Browse = new Button();
            Button_MF_Exit = new Button();
            Label_MF_OutputFIle = new Label();
            TextBox_MF_OutputFIle = new TextBox();
            Button_MF_OutputFIle_Browse = new Button();
            Button_MF_Convert = new Button();
            Label_MF_LinesRead = new Label();
            TextBox_MF_LinesRead = new TextBox();
            TextBox_Comment_Lines = new TextBox();
            Label_Comment_Lines = new Label();
            TextBox_Data_Lines = new TextBox();
            Label_Data_Lines = new Label();
            ListBox_MF_Status = new ListBox();
            CheckBox_MF_AddHeader = new CheckBox();
            SuspendLayout();
            // 
            // Label_MF_InputFile
            // 
            Label_MF_InputFile.AutoSize = true;
            Label_MF_InputFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_MF_InputFile.Location = new Point(12, 24);
            Label_MF_InputFile.Name = "Label_MF_InputFile";
            Label_MF_InputFile.Size = new Size(95, 15);
            Label_MF_InputFile.TabIndex = 0;
            Label_MF_InputFile.Text = "Input File (TXT):";
            // 
            // TextBox_MF_InputFile
            // 
            TextBox_MF_InputFile.Location = new Point(133, 20);
            TextBox_MF_InputFile.Name = "TextBox_MF_InputFile";
            TextBox_MF_InputFile.Size = new Size(354, 23);
            TextBox_MF_InputFile.TabIndex = 1;
            // 
            // Button_MF_InputTxt_Browse
            // 
            Button_MF_InputTxt_Browse.Location = new Point(506, 20);
            Button_MF_InputTxt_Browse.Name = "Button_MF_InputTxt_Browse";
            Button_MF_InputTxt_Browse.Size = new Size(83, 23);
            Button_MF_InputTxt_Browse.TabIndex = 2;
            Button_MF_InputTxt_Browse.Text = "Browse";
            Button_MF_InputTxt_Browse.UseVisualStyleBackColor = true;
            Button_MF_InputTxt_Browse.Click += Button_MF_InputTxt_Browse_Click;
            // 
            // Button_MF_Exit
            // 
            Button_MF_Exit.Location = new Point(506, 278);
            Button_MF_Exit.Name = "Button_MF_Exit";
            Button_MF_Exit.Size = new Size(83, 23);
            Button_MF_Exit.TabIndex = 3;
            Button_MF_Exit.Text = "Exit";
            Button_MF_Exit.UseVisualStyleBackColor = true;
            Button_MF_Exit.Click += Button_MF_Exit_Click;
            // 
            // Label_MF_OutputFIle
            // 
            Label_MF_OutputFIle.AutoSize = true;
            Label_MF_OutputFIle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_MF_OutputFIle.Location = new Point(12, 58);
            Label_MF_OutputFIle.Name = "Label_MF_OutputFIle";
            Label_MF_OutputFIle.Size = new Size(105, 15);
            Label_MF_OutputFIle.TabIndex = 4;
            Label_MF_OutputFIle.Text = "Output File (TXT):";
            // 
            // TextBox_MF_OutputFIle
            // 
            TextBox_MF_OutputFIle.Location = new Point(133, 55);
            TextBox_MF_OutputFIle.Name = "TextBox_MF_OutputFIle";
            TextBox_MF_OutputFIle.Size = new Size(354, 23);
            TextBox_MF_OutputFIle.TabIndex = 5;
            TextBox_MF_OutputFIle.Text = "output.txt";
            // 
            // Button_MF_OutputFIle_Browse
            // 
            Button_MF_OutputFIle_Browse.Location = new Point(506, 55);
            Button_MF_OutputFIle_Browse.Name = "Button_MF_OutputFIle_Browse";
            Button_MF_OutputFIle_Browse.Size = new Size(83, 23);
            Button_MF_OutputFIle_Browse.TabIndex = 6;
            Button_MF_OutputFIle_Browse.Text = "Browse";
            Button_MF_OutputFIle_Browse.UseVisualStyleBackColor = true;
            Button_MF_OutputFIle_Browse.Click += Button_MF_OutputFIle_Browse_Click;
            // 
            // Button_MF_Convert
            // 
            Button_MF_Convert.Location = new Point(341, 278);
            Button_MF_Convert.Name = "Button_MF_Convert";
            Button_MF_Convert.Size = new Size(146, 23);
            Button_MF_Convert.TabIndex = 7;
            Button_MF_Convert.Text = "Run Converter";
            Button_MF_Convert.UseVisualStyleBackColor = true;
            Button_MF_Convert.Click += Button_MF_Convert_Click;
            // 
            // Label_MF_LinesRead
            // 
            Label_MF_LinesRead.AutoSize = true;
            Label_MF_LinesRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_MF_LinesRead.Location = new Point(42, 125);
            Label_MF_LinesRead.Name = "Label_MF_LinesRead";
            Label_MF_LinesRead.Size = new Size(69, 15);
            Label_MF_LinesRead.TabIndex = 8;
            Label_MF_LinesRead.Text = "Lines Read:";
            // 
            // TextBox_MF_LinesRead
            // 
            TextBox_MF_LinesRead.Location = new Point(117, 122);
            TextBox_MF_LinesRead.Name = "TextBox_MF_LinesRead";
            TextBox_MF_LinesRead.Size = new Size(75, 23);
            TextBox_MF_LinesRead.TabIndex = 9;
            // 
            // TextBox_Comment_Lines
            // 
            TextBox_Comment_Lines.Location = new Point(313, 122);
            TextBox_Comment_Lines.Name = "TextBox_Comment_Lines";
            TextBox_Comment_Lines.Size = new Size(75, 23);
            TextBox_Comment_Lines.TabIndex = 11;
            // 
            // Label_Comment_Lines
            // 
            Label_Comment_Lines.AutoSize = true;
            Label_Comment_Lines.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Comment_Lines.Location = new Point(211, 125);
            Label_Comment_Lines.Name = "Label_Comment_Lines";
            Label_Comment_Lines.Size = new Size(96, 15);
            Label_Comment_Lines.TabIndex = 10;
            Label_Comment_Lines.Text = "Comment Lines:";
            // 
            // TextBox_Data_Lines
            // 
            TextBox_Data_Lines.Location = new Point(509, 122);
            TextBox_Data_Lines.Name = "TextBox_Data_Lines";
            TextBox_Data_Lines.Size = new Size(75, 23);
            TextBox_Data_Lines.TabIndex = 13;
            // 
            // Label_Data_Lines
            // 
            Label_Data_Lines.AutoSize = true;
            Label_Data_Lines.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Data_Lines.Location = new Point(425, 125);
            Label_Data_Lines.Name = "Label_Data_Lines";
            Label_Data_Lines.Size = new Size(67, 15);
            Label_Data_Lines.TabIndex = 12;
            Label_Data_Lines.Text = "Data Lines:";
            // 
            // ListBox_MF_Status
            // 
            ListBox_MF_Status.FormattingEnabled = true;
            ListBox_MF_Status.ItemHeight = 15;
            ListBox_MF_Status.Location = new Point(36, 166);
            ListBox_MF_Status.Name = "ListBox_MF_Status";
            ListBox_MF_Status.Size = new Size(553, 94);
            ListBox_MF_Status.TabIndex = 14;
            // 
            // CheckBox_MF_AddHeader
            // 
            CheckBox_MF_AddHeader.AutoSize = true;
            CheckBox_MF_AddHeader.Location = new Point(133, 84);
            CheckBox_MF_AddHeader.Name = "CheckBox_MF_AddHeader";
            CheckBox_MF_AddHeader.Size = new Size(89, 19);
            CheckBox_MF_AddHeader.TabIndex = 15;
            CheckBox_MF_AddHeader.Text = "Add Header";
            CheckBox_MF_AddHeader.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(607, 325);
            Controls.Add(CheckBox_MF_AddHeader);
            Controls.Add(ListBox_MF_Status);
            Controls.Add(TextBox_Data_Lines);
            Controls.Add(Label_Data_Lines);
            Controls.Add(TextBox_Comment_Lines);
            Controls.Add(Label_Comment_Lines);
            Controls.Add(TextBox_MF_LinesRead);
            Controls.Add(Label_MF_LinesRead);
            Controls.Add(Button_MF_Convert);
            Controls.Add(Button_MF_OutputFIle_Browse);
            Controls.Add(TextBox_MF_OutputFIle);
            Controls.Add(Label_MF_OutputFIle);
            Controls.Add(Button_MF_Exit);
            Controls.Add(Button_MF_InputTxt_Browse);
            Controls.Add(TextBox_MF_InputFile);
            Controls.Add(Label_MF_InputFile);
            Name = "MainForm";
            Text = "DataReduce_NOAAGML_TXT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_MF_InputFile;
        private TextBox TextBox_MF_InputFile;
        private Button Button_MF_InputTxt_Browse;
        private Button Button_MF_Exit;
        private Label Label_MF_OutputFIle;
        private TextBox TextBox_MF_OutputFIle;
        private Button Button_MF_OutputFIle_Browse;
        private Button Button_MF_Convert;
        private Label Label_MF_LinesRead;
        private TextBox TextBox_MF_LinesRead;
        private TextBox TextBox_Comment_Lines;
        private Label Label_Comment_Lines;
        private TextBox TextBox_Data_Lines;
        private Label Label_Data_Lines;
        private ListBox ListBox_MF_Status;
        private CheckBox CheckBox_MF_AddHeader;
    }
}