using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text;

namespace HotelManagementAF;

public partial class Frontend : MetroSetForm
{
    private readonly ReservationContext _reservationContext;
    private readonly ILogger _logger;
    private BindingSource _reservationBindingSource;
    private List<Reservation> _reservationsFound;
    private string mySeperator = "                             ";
    public int reservationNumberOfdays { get; set; }

    public Frontend(ILogger logger, ReservationContext reservationContext)
    {
        InitializeComponent();
        _reservationContext = reservationContext;
        _logger = logger;
    }

    private void FrontEnd_FormClosing(object sender, FormClosingEventArgs e)
    {
        _reservationContext.Dispose();
    }

    private void FrontEnd_Load(object sender, EventArgs e)
    {
        try
        {
            _reservationContext.Reservations.Load();
            _reservationBindingSource = new BindingSource(_reservationContext?.Reservations.Local.ToBindingList(), "");
            _reservationBindingSource.CurrentChanged += UpdateComboBoxesWithIndexChanged;

            allClientsGridView.DataSource = _reservationBindingSource;
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
        }

    }
    private void AttachSimpleBindings()
    {
        this.txtboxFname.DataBindings.Add("Text", _reservationBindingSource, "Fname", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxLname.DataBindings.Add("Text", _reservationBindingSource, "Lname", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxEmailAddress.DataBindings.Add("Text", _reservationBindingSource, "EmailAddress", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxPhone.DataBindings.Add("Text", _reservationBindingSource, "PhoneNumber", true, DataSourceUpdateMode.OnPropertyChanged);
        this.pickerBirthday.DataBindings.Add("Value", _reservationBindingSource, "BirthDay", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxStreet.DataBindings.Add("Text", _reservationBindingSource, "StreetAddress", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxCity.DataBindings.Add("Text", _reservationBindingSource, "City", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxApt.DataBindings.Add("Text", _reservationBindingSource, "AptSuite", true, DataSourceUpdateMode.OnPropertyChanged);
        this.txtboxZipCode.DataBindings.Add("Text", _reservationBindingSource, "ZipCode", true, DataSourceUpdateMode.OnPropertyChanged);
        this.pickerFromDate.DataBindings.Add("Value", _reservationBindingSource, "ArrivalTime", true, DataSourceUpdateMode.OnPropertyChanged);
        this.pickerToDate.DataBindings.Add("Value", _reservationBindingSource, "LeavingTime", true, DataSourceUpdateMode.OnPropertyChanged);
        this.checkboxCheckedIn.DataBindings.Add("Checked", _reservationBindingSource, "CheckIn", true, DataSourceUpdateMode.OnPropertyChanged);
        this.checkboxRoomServiceStatus.DataBindings.Add("Checked", _reservationBindingSource, "SupplyStatus", true, DataSourceUpdateMode.OnPropertyChanged);
        this.checkboxRoomServiceStatus.Enabled = false;
    }

    private void UpdateComboBoxesWithIndexChanged(object sender, EventArgs e)
    {
        if (_reservationBindingSource.Current != null)
        {
            string gender = (_reservationBindingSource.Current as Reservation)?.Gender;
            comboboxGender.SelectedItem = gender;

            string numberOfGuest = (_reservationBindingSource.Current as Reservation)?.NumberGuest.ToString();
            comboboxNumGuests.SelectedItem = numberOfGuest;

            string roomType = (_reservationBindingSource.Current as Reservation)?.RoomType.ToString().Trim();
            comboboxRoomType.SelectedItem = roomType;

            string floor = (_reservationBindingSource.Current as Reservation)?.RoomFloor.Trim();
            comboboxFloor.SelectedItem = floor;

            string roomNum = (_reservationBindingSource.Current as Reservation)?.RoomNumber.Trim();
            comboboxRoomNum.SelectedItem = roomNum;

            string government = (_reservationBindingSource.Current as Reservation)?.State;
            comboboxGovernment.SelectedItem = government;
        }
    }
    private void btnSearch_Click(object sender, EventArgs e)
    {
        Search();
        if (_reservationsFound.Count == 0)
            MetroSetMessageBox.Show(this, "sorry,cant find what you are searching for, try something different", "not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
        else
        {
            searchGridView.DataSource = _reservationsFound;
            searchGridView.Visible = true;
            searchGridView.ReadOnly = true;
        }
    }
    private void Search()
    {
        _reservationsFound = new List<Reservation>();
        foreach (Reservation reservation in _reservationContext.Reservations)
        {
            var properties = typeof(Reservation).GetProperties();
            foreach (var property in properties)
                if (property.GetValue(reservation).ToString().Equals(txtboxSearch.Text, StringComparison.OrdinalIgnoreCase))
                    _reservationsFound.Add(reservation);
        }
    }
    private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(tabControl.SelectedIndex == 3)
            LoadListBoxes();
    }
    private void LoadListBoxes()
    {
        listboxOccupied.Items.Clear();
        listboxReserved.Items.Clear();
        var occupiedLst = _reservationContext.Reservations.Local.Where(r => r.CheckIn == true).ToList();
        var reservedLst = _reservationContext.Reservations.Local.Where(r => r.CheckIn == false).ToList();
        foreach (var occupied in occupiedLst)
        {
            string formattedArrivalDate = $"{occupied.ArrivalTime:d}";
            string formattedLeavingDate = $"{occupied.ArrivalTime:d}";

            string eachOccupuedDetails = string.Join(mySeperator, occupied.Id, string.Join(" ", occupied.Fname, occupied.Lname), occupied.RoomNumber.Trim(), formattedArrivalDate, formattedLeavingDate);
            listboxOccupied.Items.Add(eachOccupuedDetails);
        }
        foreach (var reserved in reservedLst)
        {
            string formattedArrivalDate = $"{reserved.ArrivalTime:d}";
            string formattedLeavingDate = $"{reserved.ArrivalTime:d}";

            string eachReservedDetails = string.Join(mySeperator, reserved.Id, string.Join(" ", reserved.Fname, reserved.Lname), reserved.RoomNumber.Trim(), formattedArrivalDate, formattedLeavingDate);
            listboxReserved.Items.Add(eachReservedDetails);
        }
    }

    private void btnRoomService_Click(object sender, EventArgs e)
    {
        RoomService roomService = new RoomService(_logger, _reservationContext, _reservationBindingSource);
        roomService.Show();
    }

    private void btnBill_Click(object sender, EventArgs e)
    {
        reservationNumberOfdays = pickerToDate.Value.Day - pickerFromDate.Value.Day;
        Bill bill = new Bill(_logger, _reservationContext, _reservationBindingSource, reservationNumberOfdays);
        bill.Show();
    }
    private void btnDelete_Click(object sender, EventArgs e)
    {
        Reservation current = (Reservation)_reservationBindingSource.Current;
        _reservationContext.Reservations.Remove(current);
        _reservationContext.SaveChanges();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        _reservationBindingSource.CurrentChanged -= UpdateComboBoxesWithIndexChanged;
        _reservationBindingSource.AddNew();
        _reservationBindingSource.MoveLast();
        _reservationBindingSource.CurrentChanged += UpdateComboBoxesWithIndexChanged;
        ClearControlsField();
        AttachSimpleBindings();
        lblNewAdd.Visible = true;
        btnSave.Visible = true;
    }
    private void ClearControlsField()
    {
        foreach (Control control in this.Controls)
        {
            if (control is MetroSetTextBox textBox)
                textBox.Text = string.Empty;
            else if (control is MetroSetComboBox comboBox)
                comboBox.SelectedIndex = 0;
            else if (control is DateTimePicker dateTimePicker)
                dateTimePicker.Value = DateTime.Now;
            else if (control is MetroSetCheckBox checkBox)
                checkBox.Checked = false;
            else if (control is NumericUpDown numericUpDown)
                numericUpDown.Value = numericUpDown.Minimum;
        }
    }
    private void btnEdit_Click(object sender, EventArgs e)
    {
        comboboxExistingReservations.Visible = true;
        btnDelete.Visible = true;
        lblExistingReservation.Visible = true;
        btnSave.Visible = true;
        loadExistingReservationsComboBox();
        AttachSimpleBindings();
    }
    private void loadExistingReservationsComboBox()
    {
        this.comboboxExistingReservations.DataSource = _reservationBindingSource;
        this.comboboxExistingReservations.DisplayMember = "RoomNumber";
        this.comboboxExistingReservations.ValueMember = "Id";
    }


    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            UpdatePropertiesWithComboBoxes();
            UpdateBools();
            if (ValidateData())
            {
                _reservationBindingSource.EndEdit();
                if (lblNewAdd.Visible == true)
                    lblNewAdd.Visible = false;
                _reservationContext.SaveChanges();
                btnSave.Visible = false;
                MetroSetMessageBox.Show(this, "Reservations data is updated successfully", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (DbUpdateException ex)
        {
            _logger.Log(ex);
            DialogResult result = MetroSetMessageBox.Show(this, "error occured while submitting data to database, the app will close, please contact developer to check", "unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
                this.Close();
        }
    }
    private bool ValidateData()
    {
        var entitiesToValidate = _reservationContext.ChangeTracker.Entries()
            .Where(entry => entry.State == EntityState.Added || entry.State == EntityState.Modified)
            .Select(entry => entry.Entity)
            .OfType<IValidatableObject>().ToList();
        entitiesToValidate.Add((_reservationBindingSource.Current as Reservation));

        Debug.WriteLine(entitiesToValidate.Count());
        foreach (var entity in entitiesToValidate)
        {
            var validationContext = new ValidationContext(entity);
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(entity, validationContext, validationResults, true);
            if (!isValid)
            {
                string allValidationErrors = composeAllValidationErrorsMessage(validationResults);
                MetroSetMessageBox.Show(this, allValidationErrors, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        return true;
    }
    private string composeAllValidationErrorsMessage(List<ValidationResult> validationResults)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var validationResult in validationResults)
        {
            sb.AppendLine(validationResult.ErrorMessage);
        }
        return sb.ToString();
    }
    private void UpdatePropertiesWithComboBoxes()
    {
        (_reservationBindingSource.Current as Reservation).Gender = comboboxGender.SelectedItem.ToString();

        if (int.TryParse(comboboxNumGuests.SelectedItem.ToString(), out int numGuest))
            (_reservationBindingSource.Current as Reservation).NumberGuest = numGuest;

        (_reservationBindingSource.Current as Reservation).RoomType = comboboxRoomType.SelectedItem.ToString();

        (_reservationBindingSource.Current as Reservation).RoomFloor = comboboxFloor.SelectedItem.ToString();

        (_reservationBindingSource.Current as Reservation).RoomNumber = comboboxRoomNum.SelectedItem.ToString();

        (_reservationBindingSource.Current as Reservation).State = comboboxGovernment.SelectedItem.ToString();
    }
    private void UpdateBools()
    {
        (_reservationBindingSource.Current as Reservation).CheckIn = checkboxCheckedIn.Checked;
    }

}
