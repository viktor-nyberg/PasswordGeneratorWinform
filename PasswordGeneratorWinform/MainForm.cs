using static System.Windows.Forms.Design.AxImporter;

namespace PasswordGeneratorWinform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            lblPasswordCopied.Visible = false;
        }

        private PasswordOptions ReadSettings()
        {
            PasswordOptions options = new()
            {
                Length = 24,
                UseLowercase = true,
                UseNumbers = true,
                UseSpecial = true,
                UseUppercase = true,
                UseBrackets= true,
                CustomChars = "",
                NoRepeat = true,

            };

            options.Length = (int)nudPasswordOptionLength.Value;
            options.UseLowercase = chkPWOptionLowerCase.Checked;
            options.UseUppercase= chkPWOptionUpperCase.Checked;
            options.UseNumbers = chkPWOptionDigits.Checked;
            options.UseSpecial = chkPWOptionSpecial.Checked;
            options.NoRepeat= chkPWOptionNoRepeat.Checked;
            options.UseBrackets = chkPWOptionBrackets.Checked;
            options.UseSpace = chkPWOptionSpace.Checked;
            options.UseUnderline = chkPWOptionUnderline.Checked;
            options.UseMinus = chkPWOptiosMinus.Checked;

            foreach (char c in txtPasswordOptionCustomChar.Text.Distinct())
            {
                options.CustomChars += c;
            }

            return options;
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            PasswordOptions options = ReadSettings();

            if (options.Length > 0 && (options.UseBrackets || options.UseLowercase || options.UseUppercase || 
                options.UseUnderline || options.UseBrackets || options.UseMinus || options.UseNumbers || 
                options.UseSpace || options.UseSpecial || options.CustomChars.Length > 0))
            {
                txtPasswordResult.Text = RandomPasswordGenerator.Generate(options);
                Clipboard.SetText(txtPasswordResult.Text);
                lblPasswordCopied.Visible = true;
            }

            
        }
    }
}