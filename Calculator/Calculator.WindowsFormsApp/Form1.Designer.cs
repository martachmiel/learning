namespace Calculator.WindowsFormsApp
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
            tbScreen=new TextBox();
            btn7=new Button();
            btn8=new Button();
            btn9=new Button();
            btn4=new Button();
            btn5=new Button();
            btn6=new Button();
            btn1=new Button();
            btn2=new Button();
            btn3=new Button();
            btn0=new Button();
            btnComma=new Button();
            btnDivision=new Button();
            btnSubtraction=new Button();
            btnMultiplication=new Button();
            btnAdd=new Button();
            btnResult=new Button();
            btnClear=new Button();
            SuspendLayout();
            // 
            // tbScreen
            // 
            tbScreen.Font=new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            tbScreen.Location=new Point(12, 12);
            tbScreen.Name="tbScreen";
            tbScreen.Size=new Size(674, 82);
            tbScreen.TabIndex=0;
            tbScreen.TextAlign=HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.BackColor=Color.MediumAquamarine;
            btn7.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.ForeColor=Color.White;
            btn7.Location=new Point(12, 100);
            btn7.Name="btn7";
            btn7.Size=new Size(130, 121);
            btn7.TabIndex=1;
            btn7.Text="7";
            btn7.UseVisualStyleBackColor=false;
            btn7.Click+=OnBtnNumberClick;
            // 
            // btn8
            // 
            btn8.BackColor=Color.MediumAquamarine;
            btn8.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.ForeColor=Color.White;
            btn8.Location=new Point(148, 100);
            btn8.Name="btn8";
            btn8.Size=new Size(130, 121);
            btn8.TabIndex=2;
            btn8.Text="8";
            btn8.UseVisualStyleBackColor=false;
            btn8.Click+=OnBtnNumberClick;
            // 
            // btn9
            // 
            btn9.BackColor=Color.MediumAquamarine;
            btn9.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.ForeColor=Color.White;
            btn9.Location=new Point(284, 100);
            btn9.Name="btn9";
            btn9.Size=new Size(130, 121);
            btn9.TabIndex=3;
            btn9.Text="9";
            btn9.UseVisualStyleBackColor=false;
            btn9.Click+=OnBtnNumberClick;
            // 
            // btn4
            // 
            btn4.BackColor=Color.MediumAquamarine;
            btn4.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.ForeColor=Color.White;
            btn4.Location=new Point(12, 227);
            btn4.Name="btn4";
            btn4.Size=new Size(130, 121);
            btn4.TabIndex=4;
            btn4.Text="4";
            btn4.UseVisualStyleBackColor=false;
            btn4.Click+=OnBtnNumberClick;
            // 
            // btn5
            // 
            btn5.BackColor=Color.MediumAquamarine;
            btn5.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.ForeColor=Color.White;
            btn5.Location=new Point(148, 227);
            btn5.Name="btn5";
            btn5.Size=new Size(130, 121);
            btn5.TabIndex=5;
            btn5.Text="5";
            btn5.UseVisualStyleBackColor=false;
            btn5.Click+=OnBtnNumberClick;
            // 
            // btn6
            // 
            btn6.BackColor=Color.MediumAquamarine;
            btn6.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.ForeColor=Color.White;
            btn6.Location=new Point(284, 227);
            btn6.Name="btn6";
            btn6.Size=new Size(130, 121);
            btn6.TabIndex=6;
            btn6.Text="6";
            btn6.UseVisualStyleBackColor=false;
            btn6.Click+=OnBtnNumberClick;
            // 
            // btn1
            // 
            btn1.BackColor=Color.MediumAquamarine;
            btn1.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor=Color.White;
            btn1.Location=new Point(12, 354);
            btn1.Name="btn1";
            btn1.Size=new Size(130, 121);
            btn1.TabIndex=7;
            btn1.Text="1";
            btn1.UseVisualStyleBackColor=false;
            btn1.Click+=OnBtnNumberClick;
            // 
            // btn2
            // 
            btn2.BackColor=Color.MediumAquamarine;
            btn2.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.ForeColor=Color.White;
            btn2.Location=new Point(148, 354);
            btn2.Name="btn2";
            btn2.Size=new Size(130, 121);
            btn2.TabIndex=8;
            btn2.Text="2";
            btn2.UseVisualStyleBackColor=false;
            btn2.Click+=OnBtnNumberClick;
            // 
            // btn3
            // 
            btn3.BackColor=Color.MediumAquamarine;
            btn3.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.ForeColor=Color.White;
            btn3.Location=new Point(284, 354);
            btn3.Name="btn3";
            btn3.Size=new Size(130, 121);
            btn3.TabIndex=9;
            btn3.Text="3";
            btn3.UseVisualStyleBackColor=false;
            btn3.Click+=OnBtnNumberClick;
            // 
            // btn0
            // 
            btn0.BackColor=Color.MediumAquamarine;
            btn0.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.ForeColor=Color.White;
            btn0.Location=new Point(12, 481);
            btn0.Name="btn0";
            btn0.Size=new Size(266, 121);
            btn0.TabIndex=10;
            btn0.Text="0";
            btn0.UseVisualStyleBackColor=false;
            btn0.Click+=OnBtnNumberClick;
            // 
            // btnComma
            // 
            btnComma.BackColor=Color.MediumAquamarine;
            btnComma.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnComma.ForeColor=Color.White;
            btnComma.Location=new Point(284, 481);
            btnComma.Name="btnComma";
            btnComma.Size=new Size(130, 121);
            btnComma.TabIndex=11;
            btnComma.Text=",";
            btnComma.UseVisualStyleBackColor=false;
            btnComma.Click+=OnBtnNumberClick;
            // 
            // btnDivision
            // 
            btnDivision.BackColor=Color.DarkGray;
            btnDivision.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivision.ForeColor=Color.White;
            btnDivision.Location=new Point(420, 100);
            btnDivision.Name="btnDivision";
            btnDivision.Size=new Size(130, 121);
            btnDivision.TabIndex=12;
            btnDivision.Text="/";
            btnDivision.UseVisualStyleBackColor=false;
            btnDivision.Click+=OnBtnOperationClick;
            // 
            // btnSubtraction
            // 
            btnSubtraction.BackColor=Color.DarkGray;
            btnSubtraction.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtraction.ForeColor=Color.White;
            btnSubtraction.Location=new Point(420, 227);
            btnSubtraction.Name="btnSubtraction";
            btnSubtraction.Size=new Size(130, 121);
            btnSubtraction.TabIndex=13;
            btnSubtraction.Text="-";
            btnSubtraction.UseVisualStyleBackColor=false;
            btnSubtraction.Click+=OnBtnOperationClick;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor=Color.DarkGray;
            btnMultiplication.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiplication.ForeColor=Color.White;
            btnMultiplication.Location=new Point(420, 354);
            btnMultiplication.Name="btnMultiplication";
            btnMultiplication.Size=new Size(130, 121);
            btnMultiplication.TabIndex=14;
            btnMultiplication.Text="*";
            btnMultiplication.UseVisualStyleBackColor=false;
            btnMultiplication.Click+=OnBtnOperationClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor=Color.DarkGray;
            btnAdd.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor=Color.White;
            btnAdd.Location=new Point(556, 100);
            btnAdd.Name="btnAdd";
            btnAdd.Size=new Size(130, 248);
            btnAdd.TabIndex=15;
            btnAdd.Text="+";
            btnAdd.UseVisualStyleBackColor=false;
            btnAdd.Click+=OnBtnOperationClick;
            // 
            // btnResult
            // 
            btnResult.BackColor=Color.CornflowerBlue;
            btnResult.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnResult.ForeColor=Color.White;
            btnResult.Location=new Point(556, 354);
            btnResult.Name="btnResult";
            btnResult.Size=new Size(130, 248);
            btnResult.TabIndex=16;
            btnResult.Text="=";
            btnResult.UseVisualStyleBackColor=false;
            btnResult.Click+=OnBtnResultClick;
            // 
            // btnClear
            // 
            btnClear.BackColor=Color.DarkSalmon;
            btnClear.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor=Color.White;
            btnClear.Location=new Point(420, 481);
            btnClear.Name="btnClear";
            btnClear.Size=new Size(130, 121);
            btnClear.TabIndex=17;
            btnClear.Text="C";
            btnClear.UseVisualStyleBackColor=false;
            btnClear.Click+=OnBtnClearClick;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.Gainsboro;
            ClientSize=new Size(704, 630);
            Controls.Add(btnClear);
            Controls.Add(btnResult);
            Controls.Add(btnAdd);
            Controls.Add(btnMultiplication);
            Controls.Add(btnSubtraction);
            Controls.Add(btnDivision);
            Controls.Add(btnComma);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(tbScreen);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbScreen;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnComma;
        private Button btnDivision;
        private Button btnSubtraction;
        private Button btnMultiplication;
        private Button btnAdd;
        private Button btnResult;
        private Button btnClear;
    }
}