using System.Diagnostics;

namespace HotelManagementAF.UI;

public partial class RoomService : MetroSetForm
{
    private readonly ReservationContext _reservationContext;
    private readonly ILogger _logger;
    private BindingSource _reservationBindingSource;
    public RoomService(ILogger logger, ReservationContext reservationContext, BindingSource reservationBindingSource)
    {
        InitializeComponent();
        _reservationContext = reservationContext;
        _logger = logger;
        _reservationBindingSource = reservationBindingSource;
    }


    private void RoomService_Load(object sender, EventArgs e)
    {
        try
        {
            AttachSimpleBindings();
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
        }
    }
    private void AttachSimpleBindings()
    {
        this.numericBreakFast.DataBindings.Add("Value", _reservationBindingSource, "BreakFast", true, DataSourceUpdateMode.OnPropertyChanged);
        this.numericLaunch.DataBindings.Add("Value", _reservationBindingSource, "Launch", true, DataSourceUpdateMode.OnPropertyChanged);
        this.numericDinner.DataBindings.Add("Value", _reservationBindingSource, "Dinner", true, DataSourceUpdateMode.OnPropertyChanged);

        this.checkboxCleaning.DataBindings.Add("Checked", _reservationBindingSource, "Cleaning", true, DataSourceUpdateMode.OnPropertyChanged);
        this.checkboxTowel.DataBindings.Add("Checked", _reservationBindingSource, "Towel", true, DataSourceUpdateMode.OnPropertyChanged);
        this.checkboxSurprise.DataBindings.Add("Checked", _reservationBindingSource, "Surprise", true, DataSourceUpdateMode.OnPropertyChanged);

    }
    private void btnNext_Click(object sender, EventArgs e)
    {
        UpdateBools();
        CalcFoodBill();
        this.Close();
    }
    private void UpdateBools()
    {
        (_reservationBindingSource.Current as Reservation).Cleaning = checkboxCleaning.Checked;
        (_reservationBindingSource.Current as Reservation).Towel = checkboxTowel.Checked;
        (_reservationBindingSource.Current as Reservation).Surprise = checkboxSurprise.Checked;
    }
    private void CalcFoodBill()
    {
        int foodBill = Convert.ToInt32(numericBreakFast.Value) * 5 +
                       Convert.ToInt32(numericLaunch.Value) * 20 +
                       Convert.ToInt32(numericDinner.Value) * 20;
        (_reservationBindingSource.Current as Reservation).FoodBill = foodBill;
    }
}

