using MetroSet_UI.Actions;

namespace HotelManagementAF.UI;

public partial class Login : MetroSetForm
{
    private readonly ILogger _logger;
    private readonly LoginContext _loginContext;
    private List<FrontEndLogin> _frontendLogins;
    private List<KitchenLogin> _kitchenLogins;
    private int buttonSpacing = 20;
    public Frontend frontendForm;
    public Kitchen kitchenForm;

    public Login(ILogger logger, LoginContext loginContext)
    {
        InitializeComponent();
        _logger = logger;
        _loginContext = loginContext;
    }

    private void Login_Load(object sender, EventArgs e)
    {
        _loginContext.FrontEndLogins.Load();
        _loginContext.KitchenLogins.Load();
        _frontendLogins = _loginContext.FrontEndLogins.Local.ToList();
        _kitchenLogins = _loginContext.KitchenLogins.Local.ToList();
        Resize += SetButtonsLocations;
    }
    private void SetButtonsLocations(object sender, EventArgs e)
    {
        btnLogin.Location = new Point(this.Width/2 - txtboxPassword.Width/4, txtboxPassword.Bottom + buttonSpacing);
        btnLogin.Width= txtboxPassword.Width/2;
        btnLogin.Height = txtboxPassword.Height;
    }

    private int Validate(string username, string password)
    {
        foreach (var login in _frontendLogins)
        {
            if (login.UserName == username && login.Password == password)
                return 1;
        }
        foreach (var login in _kitchenLogins)
        {
            if (login.UserName == username && login.Password == password)
                return 2;
        }
        return 0;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtboxUserName.Text.Trim();
        string password = txtboxPassword.Text.Trim();
        int loginResult = Validate(username, password);
        if (loginResult == 0)
            MetroSetMessageBox.Show(this, "wrong username or password, try again", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else if (loginResult == 1)
        {
            this.Hide();
            frontendForm = new Frontend(_logger, new ReservationContext());
            frontendForm.FormClosed += (sender, e) => this.Close(); 
            frontendForm.Show();
        }
        else
        {
            this.Hide();
            kitchenForm = new Kitchen(_logger, new ReservationContext());
            kitchenForm.FormClosed += (sender, e) => this.Close();
            kitchenForm.Show();
        }
    }

 
}
