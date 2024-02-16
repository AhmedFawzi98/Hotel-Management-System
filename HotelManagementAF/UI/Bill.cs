namespace HotelManagementAF.UI;

public partial class Bill : MetroSetForm
{
    private readonly ReservationContext _reservationContext;
    private readonly ILogger _logger;
    private BindingSource _reservationBindingSource;
    private int foodBill;
    private int _reservationNumberOfDays;
    private int reservationBill;
    private int taxes;
    private double totalBill;
    public Bill(ILogger logger, ReservationContext reservationContext, BindingSource reservationBindingSource, int reservedNumberOfDays)
    {
        InitializeComponent();
        _reservationContext = reservationContext;
        _logger = logger;
        _reservationBindingSource = reservationBindingSource;
        _reservationNumberOfDays = reservedNumberOfDays;
    }

    private void Bill_Load(object sender, EventArgs e)
    {
        try
        {
            AttachSimpleBindings();
            AttachComboBoxes();
            CalcTotalBill();
            ShowBillDetails();
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            DialogResult result = MetroSetMessageBox.Show(this, "sorry, an unexpected error occured, the app will close, please contact developer to check", "unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
                this.Close();
        }
    }
    private void AttachSimpleBindings()
    {
        this.txtboxCardNumber.DataBindings.Add("Text", _reservationBindingSource, "CardNumber", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxExpDate.DataBindings.Add("Text", _reservationBindingSource, "CardExp", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxCVC.DataBindings.Add("Text", _reservationBindingSource, "CardCvc", true, DataSourceUpdateMode.OnPropertyChanged);
    }
    private void AttachComboBoxes()
    {
        if (_reservationBindingSource.Current != null)
        {
            string paymentType = (_reservationBindingSource.Current as Reservation)?.PaymentType;
            comboboxPaymentType.SelectedItem = paymentType;

            string cardType = (_reservationBindingSource.Current as Reservation)?.CardType;
            comboboxcardType.SelectedItem = cardType;
        }
    }
    
    private void CalcTotalBill()
    {
        foodBill = (_reservationBindingSource.Current as Reservation).FoodBill;

        reservationBill = 100 * _reservationNumberOfDays;

        taxes = Convert.ToInt32(0.10 * reservationBill);

        totalBill = foodBill + reservationBill + taxes;
    }
    private void ShowBillDetails()
    {
        lblReservationBill.Text = $"{reservationBill} EGP";
        lblFoodBill.Text = $"{foodBill} EGP";
        lblTaxes.Text = $"{taxes} EGP";
        lblTotal.Text = $"{totalBill} EGP";
    }
    private void btnNextBill_Click(object sender, EventArgs e)
    {
        AssignNonDirectelyBindedControls();
        AssignComboBoxesToProperty();
        this.Close();
    }
    private void AssignNonDirectelyBindedControls()
    {
        (_reservationBindingSource.Current as Reservation).TotalBill = totalBill;
    }
    private void AssignComboBoxesToProperty()
    {
        (_reservationBindingSource.Current as Reservation).PaymentType = comboboxPaymentType.SelectedItem.ToString();
        (_reservationBindingSource.Current as Reservation).CardType = comboboxcardType.SelectedItem.ToString();
    }
}