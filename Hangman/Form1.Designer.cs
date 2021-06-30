
namespace Hangman
{
    partial class frmHangman
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdA = new System.Windows.Forms.Button();
            this.cmdB = new System.Windows.Forms.Button();
            this.hangmanImage = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblShowWord = new System.Windows.Forms.Label();
            this.cmdD = new System.Windows.Forms.Button();
            this.cmdC = new System.Windows.Forms.Button();
            this.cmdH = new System.Windows.Forms.Button();
            this.cmdG = new System.Windows.Forms.Button();
            this.cmdF = new System.Windows.Forms.Button();
            this.cmdE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.cmdY = new System.Windows.Forms.Button();
            this.cmdZ = new System.Windows.Forms.Button();
            this.cmdQ = new System.Windows.Forms.Button();
            this.cmdR = new System.Windows.Forms.Button();
            this.cmdS = new System.Windows.Forms.Button();
            this.cmdT = new System.Windows.Forms.Button();
            this.cmdU = new System.Windows.Forms.Button();
            this.cmdV = new System.Windows.Forms.Button();
            this.cmdW = new System.Windows.Forms.Button();
            this.cmdX = new System.Windows.Forms.Button();
            this.cmdM = new System.Windows.Forms.Button();
            this.cmdN = new System.Windows.Forms.Button();
            this.cmdO = new System.Windows.Forms.Button();
            this.cmdP = new System.Windows.Forms.Button();
            this.cmdI = new System.Windows.Forms.Button();
            this.cmdJ = new System.Windows.Forms.Button();
            this.cmdK = new System.Windows.Forms.Button();
            this.cmdL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdA
            // 
            this.cmdA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdA.Location = new System.Drawing.Point(55, 354);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(49, 47);
            this.cmdA.TabIndex = 1;
            this.cmdA.Text = "a";
            this.cmdA.UseVisualStyleBackColor = true;
            this.cmdA.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdB
            // 
            this.cmdB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdB.Location = new System.Drawing.Point(110, 354);
            this.cmdB.Name = "cmdB";
            this.cmdB.Size = new System.Drawing.Size(49, 47);
            this.cmdB.TabIndex = 2;
            this.cmdB.Text = "b";
            this.cmdB.UseVisualStyleBackColor = true;
            this.cmdB.Click += new System.EventHandler(this.guessClick);
            // 
            // hangmanImage
            // 
            this.hangmanImage.Image = global::Hangman.Properties.Resources.Hangman1;
            this.hangmanImage.Location = new System.Drawing.Point(92, 12);
            this.hangmanImage.Name = "hangmanImage";
            this.hangmanImage.Size = new System.Drawing.Size(367, 244);
            this.hangmanImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangmanImage.TabIndex = 0;
            this.hangmanImage.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(569, 47);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 3;
            // 
            // lblShowWord
            // 
            this.lblShowWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblShowWord.Location = new System.Drawing.Point(37, 270);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.Size = new System.Drawing.Size(475, 71);
            this.lblShowWord.TabIndex = 4;
            this.lblShowWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdD
            // 
            this.cmdD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdD.Location = new System.Drawing.Point(220, 354);
            this.cmdD.Name = "cmdD";
            this.cmdD.Size = new System.Drawing.Size(49, 47);
            this.cmdD.TabIndex = 6;
            this.cmdD.Text = "d";
            this.cmdD.UseVisualStyleBackColor = true;
            this.cmdD.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdC
            // 
            this.cmdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdC.Location = new System.Drawing.Point(165, 354);
            this.cmdC.Name = "cmdC";
            this.cmdC.Size = new System.Drawing.Size(49, 47);
            this.cmdC.TabIndex = 5;
            this.cmdC.Text = "c";
            this.cmdC.UseVisualStyleBackColor = true;
            this.cmdC.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdH
            // 
            this.cmdH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdH.Location = new System.Drawing.Point(440, 354);
            this.cmdH.Name = "cmdH";
            this.cmdH.Size = new System.Drawing.Size(49, 47);
            this.cmdH.TabIndex = 10;
            this.cmdH.Text = "h";
            this.cmdH.UseVisualStyleBackColor = true;
            this.cmdH.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdG
            // 
            this.cmdG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdG.Location = new System.Drawing.Point(385, 354);
            this.cmdG.Name = "cmdG";
            this.cmdG.Size = new System.Drawing.Size(49, 47);
            this.cmdG.TabIndex = 9;
            this.cmdG.Text = "g";
            this.cmdG.UseVisualStyleBackColor = true;
            this.cmdG.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdF
            // 
            this.cmdF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdF.Location = new System.Drawing.Point(330, 354);
            this.cmdF.Name = "cmdF";
            this.cmdF.Size = new System.Drawing.Size(49, 47);
            this.cmdF.TabIndex = 8;
            this.cmdF.Text = "f";
            this.cmdF.UseVisualStyleBackColor = true;
            this.cmdF.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdE
            // 
            this.cmdE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdE.Location = new System.Drawing.Point(275, 354);
            this.cmdE.Name = "cmdE";
            this.cmdE.Size = new System.Drawing.Size(49, 47);
            this.cmdE.TabIndex = 7;
            this.cmdE.Text = "e";
            this.cmdE.UseVisualStyleBackColor = true;
            this.cmdE.Click += new System.EventHandler(this.guessClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(557, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 79);
            this.button1.TabIndex = 29;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(567, 415);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(0, 17);
            this.lblHint.TabIndex = 30;
            // 
            // labelHint
            // 
            this.labelHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHint.Location = new System.Drawing.Point(560, 387);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(152, 67);
            this.labelHint.TabIndex = 31;
            // 
            // cmdY
            // 
            this.cmdY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdY.Location = new System.Drawing.Point(55, 513);
            this.cmdY.Name = "cmdY";
            this.cmdY.Size = new System.Drawing.Size(49, 47);
            this.cmdY.TabIndex = 27;
            this.cmdY.Text = "y";
            this.cmdY.UseVisualStyleBackColor = true;
            this.cmdY.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdZ
            // 
            this.cmdZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdZ.Location = new System.Drawing.Point(110, 513);
            this.cmdZ.Name = "cmdZ";
            this.cmdZ.Size = new System.Drawing.Size(49, 47);
            this.cmdZ.TabIndex = 28;
            this.cmdZ.Text = "z";
            this.cmdZ.UseVisualStyleBackColor = true;
            this.cmdZ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdQ
            // 
            this.cmdQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdQ.Location = new System.Drawing.Point(55, 460);
            this.cmdQ.Name = "cmdQ";
            this.cmdQ.Size = new System.Drawing.Size(49, 47);
            this.cmdQ.TabIndex = 19;
            this.cmdQ.Text = "q";
            this.cmdQ.UseVisualStyleBackColor = true;
            this.cmdQ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdR
            // 
            this.cmdR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdR.Location = new System.Drawing.Point(110, 460);
            this.cmdR.Name = "cmdR";
            this.cmdR.Size = new System.Drawing.Size(49, 47);
            this.cmdR.TabIndex = 20;
            this.cmdR.Text = "r";
            this.cmdR.UseVisualStyleBackColor = true;
            this.cmdR.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdS
            // 
            this.cmdS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdS.Location = new System.Drawing.Point(165, 460);
            this.cmdS.Name = "cmdS";
            this.cmdS.Size = new System.Drawing.Size(49, 47);
            this.cmdS.TabIndex = 21;
            this.cmdS.Text = "s";
            this.cmdS.UseVisualStyleBackColor = true;
            this.cmdS.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdT
            // 
            this.cmdT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdT.Location = new System.Drawing.Point(220, 460);
            this.cmdT.Name = "cmdT";
            this.cmdT.Size = new System.Drawing.Size(49, 47);
            this.cmdT.TabIndex = 22;
            this.cmdT.Text = "t";
            this.cmdT.UseVisualStyleBackColor = true;
            this.cmdT.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdU
            // 
            this.cmdU.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdU.Location = new System.Drawing.Point(275, 460);
            this.cmdU.Name = "cmdU";
            this.cmdU.Size = new System.Drawing.Size(49, 47);
            this.cmdU.TabIndex = 23;
            this.cmdU.Text = "u";
            this.cmdU.UseVisualStyleBackColor = true;
            this.cmdU.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdV
            // 
            this.cmdV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdV.Location = new System.Drawing.Point(330, 460);
            this.cmdV.Name = "cmdV";
            this.cmdV.Size = new System.Drawing.Size(49, 47);
            this.cmdV.TabIndex = 24;
            this.cmdV.Text = "v";
            this.cmdV.UseVisualStyleBackColor = true;
            this.cmdV.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdW
            // 
            this.cmdW.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdW.Location = new System.Drawing.Point(385, 460);
            this.cmdW.Name = "cmdW";
            this.cmdW.Size = new System.Drawing.Size(49, 47);
            this.cmdW.TabIndex = 25;
            this.cmdW.Text = "w";
            this.cmdW.UseVisualStyleBackColor = true;
            this.cmdW.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdX
            // 
            this.cmdX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdX.Location = new System.Drawing.Point(440, 460);
            this.cmdX.Name = "cmdX";
            this.cmdX.Size = new System.Drawing.Size(49, 47);
            this.cmdX.TabIndex = 26;
            this.cmdX.Text = "x";
            this.cmdX.UseVisualStyleBackColor = true;
            this.cmdX.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdM
            // 
            this.cmdM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdM.Location = new System.Drawing.Point(275, 407);
            this.cmdM.Name = "cmdM";
            this.cmdM.Size = new System.Drawing.Size(49, 47);
            this.cmdM.TabIndex = 15;
            this.cmdM.Text = "m";
            this.cmdM.UseVisualStyleBackColor = true;
            this.cmdM.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdN
            // 
            this.cmdN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdN.Location = new System.Drawing.Point(330, 407);
            this.cmdN.Name = "cmdN";
            this.cmdN.Size = new System.Drawing.Size(49, 47);
            this.cmdN.TabIndex = 16;
            this.cmdN.Text = "n";
            this.cmdN.UseVisualStyleBackColor = true;
            this.cmdN.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdO
            // 
            this.cmdO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdO.Location = new System.Drawing.Point(385, 407);
            this.cmdO.Name = "cmdO";
            this.cmdO.Size = new System.Drawing.Size(49, 47);
            this.cmdO.TabIndex = 17;
            this.cmdO.Text = "o";
            this.cmdO.UseVisualStyleBackColor = true;
            this.cmdO.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdP
            // 
            this.cmdP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdP.Location = new System.Drawing.Point(440, 407);
            this.cmdP.Name = "cmdP";
            this.cmdP.Size = new System.Drawing.Size(49, 47);
            this.cmdP.TabIndex = 18;
            this.cmdP.Text = "p";
            this.cmdP.UseVisualStyleBackColor = true;
            this.cmdP.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdI
            // 
            this.cmdI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdI.Location = new System.Drawing.Point(55, 407);
            this.cmdI.Name = "cmdI";
            this.cmdI.Size = new System.Drawing.Size(49, 47);
            this.cmdI.TabIndex = 11;
            this.cmdI.Text = "i";
            this.cmdI.UseVisualStyleBackColor = true;
            this.cmdI.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdJ
            // 
            this.cmdJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdJ.Location = new System.Drawing.Point(110, 407);
            this.cmdJ.Name = "cmdJ";
            this.cmdJ.Size = new System.Drawing.Size(49, 47);
            this.cmdJ.TabIndex = 12;
            this.cmdJ.Text = "j";
            this.cmdJ.UseVisualStyleBackColor = true;
            this.cmdJ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdK
            // 
            this.cmdK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdK.Location = new System.Drawing.Point(165, 407);
            this.cmdK.Name = "cmdK";
            this.cmdK.Size = new System.Drawing.Size(49, 47);
            this.cmdK.TabIndex = 13;
            this.cmdK.Text = "k";
            this.cmdK.UseVisualStyleBackColor = true;
            this.cmdK.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdL
            // 
            this.cmdL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdL.Location = new System.Drawing.Point(220, 407);
            this.cmdL.Name = "cmdL";
            this.cmdL.Size = new System.Drawing.Size(49, 47);
            this.cmdL.TabIndex = 14;
            this.cmdL.Text = "l";
            this.cmdL.UseVisualStyleBackColor = true;
            this.cmdL.Click += new System.EventHandler(this.guessClick);
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(882, 601);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdZ);
            this.Controls.Add(this.cmdY);
            this.Controls.Add(this.cmdX);
            this.Controls.Add(this.cmdW);
            this.Controls.Add(this.cmdV);
            this.Controls.Add(this.cmdU);
            this.Controls.Add(this.cmdT);
            this.Controls.Add(this.cmdS);
            this.Controls.Add(this.cmdR);
            this.Controls.Add(this.cmdQ);
            this.Controls.Add(this.cmdP);
            this.Controls.Add(this.cmdO);
            this.Controls.Add(this.cmdN);
            this.Controls.Add(this.cmdM);
            this.Controls.Add(this.cmdL);
            this.Controls.Add(this.cmdK);
            this.Controls.Add(this.cmdJ);
            this.Controls.Add(this.cmdI);
            this.Controls.Add(this.cmdH);
            this.Controls.Add(this.cmdG);
            this.Controls.Add(this.cmdF);
            this.Controls.Add(this.cmdE);
            this.Controls.Add(this.cmdD);
            this.Controls.Add(this.cmdC);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmdB);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.hangmanImage);
            this.Name = "frmHangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.frmHangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangmanImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hangmanImage;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button cmdB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblShowWord;
        private System.Windows.Forms.Button cmdD;
        private System.Windows.Forms.Button cmdC;
        private System.Windows.Forms.Button cmdH;
        private System.Windows.Forms.Button cmdG;
        private System.Windows.Forms.Button cmdF;
        private System.Windows.Forms.Button cmdE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Button cmdY;
        private System.Windows.Forms.Button cmdZ;
        private System.Windows.Forms.Button cmdQ;
        private System.Windows.Forms.Button cmdR;
        private System.Windows.Forms.Button cmdS;
        private System.Windows.Forms.Button cmdT;
        private System.Windows.Forms.Button cmdU;
        private System.Windows.Forms.Button cmdV;
        private System.Windows.Forms.Button cmdW;
        private System.Windows.Forms.Button cmdX;
        private System.Windows.Forms.Button cmdM;
        private System.Windows.Forms.Button cmdN;
        private System.Windows.Forms.Button cmdO;
        private System.Windows.Forms.Button cmdP;
        private System.Windows.Forms.Button cmdI;
        private System.Windows.Forms.Button cmdJ;
        private System.Windows.Forms.Button cmdK;
        private System.Windows.Forms.Button cmdL;
    }
}

