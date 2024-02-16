using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Diagnostics;
using System.Linq.Expressions;

namespace HotelManagementAF.UI;

public partial class Kitchen : MetroSetForm
{
    private readonly ReservationContext _reservationContext;
    private readonly ILogger _logger;
    private BindingSource _servedGuestsBindingSource;

    public Kitchen(ILogger logger, ReservationContext reservationContext)
    {
        InitializeComponent();
        _reservationContext = reservationContext;
        _logger = logger;
    }

    private void Kitchen_Load(object sender, EventArgs e)
    {
        try
        {
            LoadData();
            AttachSimpleBindings();
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
        }
    }
    private void LoadData()
    {
        _reservationContext.ChangeTracker.Clear();
        _reservationContext.Reservations.Where(r =>
              ((r.Launch == 1 || r.BreakFast == 1 || r.Dinner == 1 || r.Cleaning || r.Towel || r.Surprise) && !r.SupplyStatus && r.CheckIn)).Load();

        if (_servedGuestsBindingSource is null)
            _servedGuestsBindingSource = new BindingSource();

        _servedGuestsBindingSource.DataSource = _reservationContext.Reservations.Local.ToBindingList();
        _servedGuestsBindingSource.DataMember = "";

        listboxWaitingList.DataSource = _servedGuestsBindingSource;
        listboxWaitingList.DisplayMember = "RoomNumber";
        listboxWaitingList.ValueMember = "Id";

        gridviewKitchen.DataSource = _servedGuestsBindingSource;
    }

    private void Kitchen_FormClosing(object sender, FormClosingEventArgs e)
    {
        _reservationContext.Dispose();
    }

    private void AttachSimpleBindings()
    {
        this.txtboxBreakfastk.DataBindings.Add("Text", _servedGuestsBindingSource, "BreakFast", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxLaunchk.DataBindings.Add("Text", _servedGuestsBindingSource, "Launch", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxBDinnerk.DataBindings.Add("Text", _servedGuestsBindingSource, "Dinner", true, DataSourceUpdateMode.OnPropertyChanged);

        this.txtboxFnamek.DataBindings.Add("Text", _servedGuestsBindingSource, "Fname", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxLnamek.DataBindings.Add("Text", _servedGuestsBindingSource, "Lname", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxRoomNumk.DataBindings.Add("Text", _servedGuestsBindingSource, "RoomNumber", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxFloork.DataBindings.Add("Text", _servedGuestsBindingSource, "RoomFloor", true, DataSourceUpdateMode.OnPropertyChanged);
        this.textboxRoomTypek.DataBindings.Add("Text", _servedGuestsBindingSource, "RoomType", true, DataSourceUpdateMode.OnPropertyChanged);

        this.checkboxCleaningk.DataBindings.Add("Checked", _servedGuestsBindingSource, "Cleaning", true, DataSourceUpdateMode.OnPropertyChanged);
        this.checkboxTowelk.DataBindings.Add("Checked", _servedGuestsBindingSource, "Towel", true, DataSourceUpdateMode.OnPropertyChanged);
        this.checkboxSurprisek.DataBindings.Add("Checked", _servedGuestsBindingSource, "Surprise", true, DataSourceUpdateMode.OnPropertyChanged);

        this.checkboxRoomServiceStatusk.DataBindings.Add("Checked", _servedGuestsBindingSource, "SupplyStatus", true, DataSourceUpdateMode.OnPropertyChanged);

    }


    private void btnRoomServicek_Click(object sender, EventArgs e)
    {
        RoomService roomService = new RoomService(_logger, _reservationContext, _servedGuestsBindingSource);
        roomService.Show();
    }

    private void btnSavek_Click(object sender, EventArgs e)
    {
        try
        {
            UpdateBools();
            _servedGuestsBindingSource.EndEdit();
            _reservationContext.SaveChanges();
            MetroSetMessageBox.Show(this, "Room Serivce Data is updated successfully", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            DialogResult result = MetroSetMessageBox.Show(this, "sorry, an unexpected error occured, the app will close, please contact developer to check", "unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
                this.Close();
        }
    }
    private void UpdateBools()
    {
        (_servedGuestsBindingSource.Current as Reservation).SupplyStatus = checkboxRoomServiceStatusk.Checked;
    }

}
