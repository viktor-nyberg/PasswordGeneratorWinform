namespace PasswordGeneratorWinform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chkPWOptionUpperCase = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPasswordOptionLength = new System.Windows.Forms.NumericUpDown();
            this.chkPWOptionLowerCase = new System.Windows.Forms.CheckBox();
            this.chkPWOptionDigits = new System.Windows.Forms.CheckBox();
            this.chkPWOptiosMinus = new System.Windows.Forms.CheckBox();
            this.chkPWOptionUnderline = new System.Windows.Forms.CheckBox();
            this.chkPWOptionSpace = new System.Windows.Forms.CheckBox();
            this.chkPWOptionSpecial = new System.Windows.Forms.CheckBox();
            this.chkPWOptionBrackets = new System.Windows.Forms.CheckBox();
            this.chkPWOptionNoRepeat = new System.Windows.Forms.CheckBox();
            this.lblPasswordOptionCustomChar = new System.Windows.Forms.Label();
            this.txtPasswordOptionCustomChar = new System.Windows.Forms.TextBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtPasswordResult = new System.Windows.Forms.TextBox();
            this.lblPasswordCopied = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordOptionLength)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPWOptionUpperCase
            // 
            this.chkPWOptionUpperCase.AutoSize = true;
            this.chkPWOptionUpperCase.Checked = true;
            this.chkPWOptionUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPWOptionUpperCase.Location = new System.Drawing.Point(14, 45);
            this.chkPWOptionUpperCase.Name = "chkPWOptionUpperCase";
            this.chkPWOptionUpperCase.Size = new System.Drawing.Size(149, 19);
            this.chkPWOptionUpperCase.TabIndex = 0;
            this.chkPWOptionUpperCase.Text = "Upper-Case (A, B, D, ...)";
            this.chkPWOptionUpperCase.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose length of password";
            // 
            // nudPasswordOptionLength
            // 
            this.nudPasswordOptionLength.Location = new System.Drawing.Point(219, 12);
            this.nudPasswordOptionLength.Name = "nudPasswordOptionLength";
            this.nudPasswordOptionLength.Size = new System.Drawing.Size(120, 23);
            this.nudPasswordOptionLength.TabIndex = 2;
            this.nudPasswordOptionLength.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // chkPWOptionLowerCase
            // 
            this.chkPWOptionLowerCase.AutoSize = true;
            this.chkPWOptionLowerCase.Checked = true;
            this.chkPWOptionLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPWOptionLowerCase.Location = new System.Drawing.Point(14, 70);
            this.chkPWOptionLowerCase.Name = "chkPWOptionLowerCase";
            this.chkPWOptionLowerCase.Size = new System.Drawing.Size(144, 19);
            this.chkPWOptionLowerCase.TabIndex = 3;
            this.chkPWOptionLowerCase.Text = "Lower-case (a, b, d, ...)";
            this.chkPWOptionLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkPWOptionDigits
            // 
            this.chkPWOptionDigits.AutoSize = true;
            this.chkPWOptionDigits.Checked = true;
            this.chkPWOptionDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPWOptionDigits.Location = new System.Drawing.Point(14, 95);
            this.chkPWOptionDigits.Name = "chkPWOptionDigits";
            this.chkPWOptionDigits.Size = new System.Drawing.Size(112, 19);
            this.chkPWOptionDigits.TabIndex = 4;
            this.chkPWOptionDigits.Text = "Digits (0, 1, 2, ...)";
            this.chkPWOptionDigits.UseVisualStyleBackColor = true;
            // 
            // chkPWOptiosMinus
            // 
            this.chkPWOptiosMinus.AutoSize = true;
            this.chkPWOptiosMinus.Location = new System.Drawing.Point(14, 120);
            this.chkPWOptiosMinus.Name = "chkPWOptiosMinus";
            this.chkPWOptiosMinus.Size = new System.Drawing.Size(75, 19);
            this.chkPWOptiosMinus.TabIndex = 5;
            this.chkPWOptiosMinus.Text = "Minus (-)";
            this.chkPWOptiosMinus.UseVisualStyleBackColor = true;
            // 
            // chkPWOptionUnderline
            // 
            this.chkPWOptionUnderline.AutoSize = true;
            this.chkPWOptionUnderline.Location = new System.Drawing.Point(219, 45);
            this.chkPWOptionUnderline.Name = "chkPWOptionUnderline";
            this.chkPWOptionUnderline.Size = new System.Drawing.Size(93, 19);
            this.chkPWOptionUnderline.TabIndex = 6;
            this.chkPWOptionUnderline.Text = "Underline (_)";
            this.chkPWOptionUnderline.UseVisualStyleBackColor = true;
            // 
            // chkPWOptionSpace
            // 
            this.chkPWOptionSpace.AutoSize = true;
            this.chkPWOptionSpace.Location = new System.Drawing.Point(219, 70);
            this.chkPWOptionSpace.Name = "chkPWOptionSpace";
            this.chkPWOptionSpace.Size = new System.Drawing.Size(71, 19);
            this.chkPWOptionSpace.TabIndex = 7;
            this.chkPWOptionSpace.Text = "Space ( )";
            this.chkPWOptionSpace.UseVisualStyleBackColor = true;
            // 
            // chkPWOptionSpecial
            // 
            this.chkPWOptionSpecial.AutoSize = true;
            this.chkPWOptionSpecial.Checked = true;
            this.chkPWOptionSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPWOptionSpecial.Location = new System.Drawing.Point(219, 95);
            this.chkPWOptionSpecial.Name = "chkPWOptionSpecial";
            this.chkPWOptionSpecial.Size = new System.Drawing.Size(129, 19);
            this.chkPWOptionSpecial.TabIndex = 8;
            this.chkPWOptionSpecial.Text = "Special (!, $, %, &, ... )";
            this.chkPWOptionSpecial.UseVisualStyleBackColor = true;
            // 
            // chkPWOptionBrackets
            // 
            this.chkPWOptionBrackets.AutoSize = true;
            this.chkPWOptionBrackets.Location = new System.Drawing.Point(219, 120);
            this.chkPWOptionBrackets.Name = "chkPWOptionBrackets";
            this.chkPWOptionBrackets.Size = new System.Drawing.Size(163, 19);
            this.chkPWOptionBrackets.TabIndex = 10;
            this.chkPWOptionBrackets.Text = "Brackets ([, ], {, }, (, ), <, >)";
            this.chkPWOptionBrackets.UseVisualStyleBackColor = true;
            // 
            // chkPWOptionNoRepeat
            // 
            this.chkPWOptionNoRepeat.AutoSize = true;
            this.chkPWOptionNoRepeat.Location = new System.Drawing.Point(219, 145);
            this.chkPWOptionNoRepeat.Name = "chkPWOptionNoRepeat";
            this.chkPWOptionNoRepeat.Size = new System.Drawing.Size(152, 19);
            this.chkPWOptionNoRepeat.TabIndex = 11;
            this.chkPWOptionNoRepeat.Text = "No repeating characters";
            this.chkPWOptionNoRepeat.UseVisualStyleBackColor = true;
            // 
            // lblPasswordOptionCustomChar
            // 
            this.lblPasswordOptionCustomChar.AutoSize = true;
            this.lblPasswordOptionCustomChar.Location = new System.Drawing.Point(14, 180);
            this.lblPasswordOptionCustomChar.Name = "lblPasswordOptionCustomChar";
            this.lblPasswordOptionCustomChar.Size = new System.Drawing.Size(202, 15);
            this.lblPasswordOptionCustomChar.TabIndex = 12;
            this.lblPasswordOptionCustomChar.Text = "Also include the following characters";
            // 
            // txtPasswordOptionCustomChar
            // 
            this.txtPasswordOptionCustomChar.Location = new System.Drawing.Point(14, 204);
            this.txtPasswordOptionCustomChar.Name = "txtPasswordOptionCustomChar";
            this.txtPasswordOptionCustomChar.Size = new System.Drawing.Size(415, 23);
            this.txtPasswordOptionCustomChar.TabIndex = 13;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(14, 242);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(75, 33);
            this.btnGeneratePassword.TabIndex = 14;
            this.btnGeneratePassword.Text = "Generate!";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtPasswordResult
            // 
            this.txtPasswordResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordResult.Location = new System.Drawing.Point(95, 242);
            this.txtPasswordResult.Name = "txtPasswordResult";
            this.txtPasswordResult.ReadOnly = true;
            this.txtPasswordResult.Size = new System.Drawing.Size(334, 33);
            this.txtPasswordResult.TabIndex = 15;
            // 
            // lblPasswordCopied
            // 
            this.lblPasswordCopied.AutoSize = true;
            this.lblPasswordCopied.Location = new System.Drawing.Point(176, 278);
            this.lblPasswordCopied.Name = "lblPasswordCopied";
            this.lblPasswordCopied.Size = new System.Drawing.Size(166, 15);
            this.lblPasswordCopied.TabIndex = 16;
            this.lblPasswordCopied.Text = "Password copied to clipboard!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 308);
            this.Controls.Add(this.lblPasswordCopied);
            this.Controls.Add(this.txtPasswordResult);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.txtPasswordOptionCustomChar);
            this.Controls.Add(this.lblPasswordOptionCustomChar);
            this.Controls.Add(this.chkPWOptionNoRepeat);
            this.Controls.Add(this.chkPWOptionBrackets);
            this.Controls.Add(this.chkPWOptionSpecial);
            this.Controls.Add(this.chkPWOptionSpace);
            this.Controls.Add(this.chkPWOptionUnderline);
            this.Controls.Add(this.chkPWOptiosMinus);
            this.Controls.Add(this.chkPWOptionDigits);
            this.Controls.Add(this.chkPWOptionLowerCase);
            this.Controls.Add(this.nudPasswordOptionLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkPWOptionUpperCase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Password generator";
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordOptionLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkPWOptionUpperCase;
        private Label label1;
        private NumericUpDown nudPasswordOptionLength;
        private CheckBox chkPWOptionLowerCase;
        private CheckBox chkPWOptionDigits;
        private CheckBox chkPWOptiosMinus;
        private CheckBox chkPWOptionUnderline;
        private CheckBox chkPWOptionSpace;
        private CheckBox chkPWOptionSpecial;
        private CheckBox chkPWOptionBrackets;
        private CheckBox chkPWOptionNoRepeat;
        private Label lblPasswordOptionCustomChar;
        private TextBox txtPasswordOptionCustomChar;
        private Button btnGeneratePassword;
        private TextBox txtPasswordResult;
        private Label lblPasswordCopied;
    }
}