using MetroSet_UI.Controls;

namespace HotelManagementAF
{
    partial class Frontend
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
            tabControl = new MetroSetTabControl();
            tabPage1 = new TabPage();
            metroSetPanel1 = new MetroSetPanel();
            btnDelete = new MetroSetButton();
            btnEdit = new MetroSetButton();
            btnAdd = new MetroSetButton();
            lblExistingReservation = new MetroSetLabel();
            comboboxExistingReservations = new MetroSetComboBox();
            styleManager1 = new MetroSet_UI.Components.StyleManager();
            panelClientInfo = new MetroSetPanel();
            lblNewAdd = new MetroSetLabel();
            btnSave = new MetroSetButton();
            checkboxRoomServiceStatus = new MetroSetCheckBox();
            metroSetLabel17 = new MetroSetLabel();
            metroSetLabel16 = new MetroSetLabel();
            metroSetLabel15 = new MetroSetLabel();
            metroSetLabel14 = new MetroSetLabel();
            metroSetLabel13 = new MetroSetLabel();
            metroSetLabel9 = new MetroSetLabel();
            checkboxCheckedIn = new MetroSetCheckBox();
            btnBill = new MetroSetButton();
            btnRoomService = new MetroSetButton();
            comboboxRoomNum = new MetroSetComboBox();
            comboboxFloor = new MetroSetComboBox();
            comboboxRoomType = new MetroSetComboBox();
            comboboxNumGuests = new MetroSetComboBox();
            pickerToDate = new DateTimePicker();
            pickerFromDate = new DateTimePicker();
            txtboxZipCode = new MetroSetTextBox();
            txtboxApt = new MetroSetTextBox();
            txtboxCity = new MetroSetTextBox();
            txtboxStreet = new MetroSetTextBox();
            comboboxGovernment = new MetroSetComboBox();
            txtboxPhone = new MetroSetTextBox();
            txtboxEmailAddress = new MetroSetTextBox();
            comboboxGender = new MetroSetComboBox();
            pickerBirthday = new DateTimePicker();
            txtboxLname = new MetroSetTextBox();
            txtboxFname = new MetroSetTextBox();
            metroSetLabel10 = new MetroSetLabel();
            metroSetLabel8 = new MetroSetLabel();
            metroSetLabel6 = new MetroSetLabel();
            metroSetLabel5 = new MetroSetLabel();
            metroSetLabel4 = new MetroSetLabel();
            metroSetLabel3 = new MetroSetLabel();
            metroSetLabel2 = new MetroSetLabel();
            metroSetLabel1 = new MetroSetLabel();
            tabPage2 = new TabPage();
            btnSearch = new MetroSetButton();
            txtboxSearch = new MetroSetTextBox();
            searchGridView = new DataGridView();
            tabPage3 = new TabPage();
            allClientsGridView = new DataGridView();
            tabPage4 = new TabPage();
            metroSetPanel5 = new MetroSetPanel();
            metroSetLabel19 = new MetroSetLabel();
            metroSetPanel4 = new MetroSetPanel();
            metroSetLabel18 = new MetroSetLabel();
            metroSetPanel2 = new MetroSetPanel();
            metroSetLabel11 = new MetroSetLabel();
            listboxOccupied = new MetroSetListBox();
            listboxReserved = new MetroSetListBox();
            metroSetControlBox1 = new MetroSetControlBox();
            lblFrontEnd = new MetroSetLabel();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            metroSetPanel1.SuspendLayout();
            panelClientInfo.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchGridView).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allClientsGridView).BeginInit();
            tabPage4.SuspendLayout();
            metroSetPanel5.SuspendLayout();
            metroSetPanel4.SuspendLayout();
            metroSetPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            tabControl.AnimateTime = 200;
            tabControl.BackgroundColor = Color.Silver;
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.IsDerivedStyle = true;
            tabControl.ItemSize = new Size(100, 38);
            tabControl.Location = new Point(15, 73);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.SelectedTextColor = Color.WhiteSmoke;
            tabControl.Size = new Size(1042, 618);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.Speed = 100;
            tabControl.Style = MetroSet_UI.Enums.Style.Custom;
            tabControl.StyleManager = styleManager1;
            tabControl.TabIndex = 1;
            tabControl.ThemeAuthor = null;
            tabControl.ThemeName = null;
            tabControl.UnselectedTextColor = Color.White;
            tabControl.UseAnimation = false;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(metroSetPanel1);
            tabPage1.Controls.Add(panelClientInfo);
            tabPage1.Location = new Point(4, 42);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1034, 572);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reservation";
            // 
            // metroSetPanel1
            // 
            metroSetPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            metroSetPanel1.BackgroundColor = Color.SeaShell;
            metroSetPanel1.BorderColor = Color.FromArgb(150, 150, 150);
            metroSetPanel1.BorderThickness = 1;
            metroSetPanel1.Controls.Add(btnDelete);
            metroSetPanel1.Controls.Add(btnEdit);
            metroSetPanel1.Controls.Add(btnAdd);
            metroSetPanel1.Controls.Add(lblExistingReservation);
            metroSetPanel1.Controls.Add(comboboxExistingReservations);
            metroSetPanel1.IsDerivedStyle = true;
            metroSetPanel1.Location = new Point(710, 16);
            metroSetPanel1.Name = "metroSetPanel1";
            metroSetPanel1.Size = new Size(310, 541);
            metroSetPanel1.Style = MetroSet_UI.Enums.Style.Custom;
            metroSetPanel1.StyleManager = styleManager1;
            metroSetPanel1.TabIndex = 1;
            metroSetPanel1.ThemeAuthor = null;
            metroSetPanel1.ThemeName = null;
            // 
            // btnDelete
            // 
            btnDelete.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnDelete.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnDelete.DisabledForeColor = Color.Gray;
            btnDelete.Font = new Font("Microsoft Sans Serif", 10F);
            btnDelete.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnDelete.HoverColor = Color.FromArgb(95, 207, 255);
            btnDelete.HoverTextColor = Color.White;
            btnDelete.IsDerivedStyle = true;
            btnDelete.Location = new Point(16, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnDelete.NormalColor = Color.Red;
            btnDelete.NormalTextColor = Color.White;
            btnDelete.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnDelete.PressColor = Color.FromArgb(35, 147, 195);
            btnDelete.PressTextColor = Color.White;
            btnDelete.Size = new Size(276, 35);
            btnDelete.Style = MetroSet_UI.Enums.Style.Custom;
            btnDelete.StyleManager = null;
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.ThemeAuthor = "";
            btnDelete.ThemeName = "";
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnEdit.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnEdit.DisabledForeColor = Color.Gray;
            btnEdit.Font = new Font("Microsoft Sans Serif", 10F);
            btnEdit.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnEdit.HoverColor = Color.FromArgb(95, 207, 255);
            btnEdit.HoverTextColor = Color.White;
            btnEdit.IsDerivedStyle = true;
            btnEdit.Location = new Point(16, 433);
            btnEdit.Name = "btnEdit";
            btnEdit.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnEdit.NormalColor = Color.FromArgb(65, 177, 225);
            btnEdit.NormalTextColor = Color.White;
            btnEdit.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnEdit.PressColor = Color.FromArgb(35, 147, 195);
            btnEdit.PressTextColor = Color.White;
            btnEdit.Size = new Size(276, 35);
            btnEdit.Style = MetroSet_UI.Enums.Style.Light;
            btnEdit.StyleManager = null;
            btnEdit.TabIndex = 40;
            btnEdit.Text = "Edit Existing Reservation";
            btnEdit.ThemeAuthor = "Narwin";
            btnEdit.ThemeName = "MetroLite";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnAdd.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnAdd.DisabledForeColor = Color.Gray;
            btnAdd.Font = new Font("Microsoft Sans Serif", 10F);
            btnAdd.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnAdd.HoverColor = Color.FromArgb(95, 207, 255);
            btnAdd.HoverTextColor = Color.White;
            btnAdd.IsDerivedStyle = true;
            btnAdd.Location = new Point(16, 490);
            btnAdd.Name = "btnAdd";
            btnAdd.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnAdd.NormalColor = Color.FromArgb(65, 177, 225);
            btnAdd.NormalTextColor = Color.White;
            btnAdd.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnAdd.PressColor = Color.FromArgb(35, 147, 195);
            btnAdd.PressTextColor = Color.White;
            btnAdd.Size = new Size(276, 35);
            btnAdd.Style = MetroSet_UI.Enums.Style.Light;
            btnAdd.StyleManager = null;
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add New Reservation";
            btnAdd.ThemeAuthor = "Narwin";
            btnAdd.ThemeName = "MetroLite";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblExistingReservation
            // 
            lblExistingReservation.Font = new Font("Leelawadee UI", 10F, FontStyle.Bold);
            lblExistingReservation.IsDerivedStyle = true;
            lblExistingReservation.Location = new Point(5, 4);
            lblExistingReservation.Name = "lblExistingReservation";
            lblExistingReservation.Size = new Size(317, 29);
            lblExistingReservation.Style = MetroSet_UI.Enums.Style.Light;
            lblExistingReservation.StyleManager = null;
            lblExistingReservation.TabIndex = 33;
            lblExistingReservation.Text = "Existing Reservations Rooms Numbers";
            lblExistingReservation.ThemeAuthor = "Narwin";
            lblExistingReservation.ThemeName = "MetroLite";
            lblExistingReservation.Visible = false;
            // 
            // comboboxExistingReservations
            // 
            comboboxExistingReservations.AllowDrop = true;
            comboboxExistingReservations.ArrowColor = Color.FromArgb(150, 150, 150);
            comboboxExistingReservations.BackColor = Color.Transparent;
            comboboxExistingReservations.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboboxExistingReservations.BorderColor = Color.FromArgb(150, 150, 150);
            comboboxExistingReservations.CausesValidation = false;
            comboboxExistingReservations.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboboxExistingReservations.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboboxExistingReservations.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboboxExistingReservations.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxExistingReservations.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxExistingReservations.Font = new Font("Microsoft Sans Serif", 11F);
            comboboxExistingReservations.FormattingEnabled = true;
            comboboxExistingReservations.IsDerivedStyle = true;
            comboboxExistingReservations.ItemHeight = 20;
            comboboxExistingReservations.Location = new Point(16, 40);
            comboboxExistingReservations.Name = "comboboxExistingReservations";
            comboboxExistingReservations.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboboxExistingReservations.SelectedItemForeColor = Color.White;
            comboboxExistingReservations.Size = new Size(276, 26);
            comboboxExistingReservations.Style = MetroSet_UI.Enums.Style.Light;
            comboboxExistingReservations.StyleManager = null;
            comboboxExistingReservations.TabIndex = 0;
            comboboxExistingReservations.ThemeAuthor = "Narwin";
            comboboxExistingReservations.ThemeName = "MetroLite";
            comboboxExistingReservations.Visible = false;
            // 
            // styleManager1
            // 
            styleManager1.CustomTheme = "C:\\Users\\ahmed\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            styleManager1.MetroForm = this;
            styleManager1.Style = MetroSet_UI.Enums.Style.Custom;
            styleManager1.ThemeAuthor = null;
            styleManager1.ThemeName = null;
            // 
            // panelClientInfo
            // 
            panelClientInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelClientInfo.BackgroundColor = Color.SeaShell;
            panelClientInfo.BorderColor = Color.FromArgb(150, 150, 150);
            panelClientInfo.BorderThickness = 1;
            panelClientInfo.Controls.Add(lblNewAdd);
            panelClientInfo.Controls.Add(btnSave);
            panelClientInfo.Controls.Add(checkboxRoomServiceStatus);
            panelClientInfo.Controls.Add(metroSetLabel17);
            panelClientInfo.Controls.Add(metroSetLabel16);
            panelClientInfo.Controls.Add(metroSetLabel15);
            panelClientInfo.Controls.Add(metroSetLabel14);
            panelClientInfo.Controls.Add(metroSetLabel13);
            panelClientInfo.Controls.Add(metroSetLabel9);
            panelClientInfo.Controls.Add(checkboxCheckedIn);
            panelClientInfo.Controls.Add(btnBill);
            panelClientInfo.Controls.Add(btnRoomService);
            panelClientInfo.Controls.Add(comboboxRoomNum);
            panelClientInfo.Controls.Add(comboboxFloor);
            panelClientInfo.Controls.Add(comboboxRoomType);
            panelClientInfo.Controls.Add(comboboxNumGuests);
            panelClientInfo.Controls.Add(pickerToDate);
            panelClientInfo.Controls.Add(pickerFromDate);
            panelClientInfo.Controls.Add(txtboxZipCode);
            panelClientInfo.Controls.Add(txtboxApt);
            panelClientInfo.Controls.Add(txtboxCity);
            panelClientInfo.Controls.Add(txtboxStreet);
            panelClientInfo.Controls.Add(comboboxGovernment);
            panelClientInfo.Controls.Add(txtboxPhone);
            panelClientInfo.Controls.Add(txtboxEmailAddress);
            panelClientInfo.Controls.Add(comboboxGender);
            panelClientInfo.Controls.Add(pickerBirthday);
            panelClientInfo.Controls.Add(txtboxLname);
            panelClientInfo.Controls.Add(txtboxFname);
            panelClientInfo.Controls.Add(metroSetLabel10);
            panelClientInfo.Controls.Add(metroSetLabel8);
            panelClientInfo.Controls.Add(metroSetLabel6);
            panelClientInfo.Controls.Add(metroSetLabel5);
            panelClientInfo.Controls.Add(metroSetLabel4);
            panelClientInfo.Controls.Add(metroSetLabel3);
            panelClientInfo.Controls.Add(metroSetLabel2);
            panelClientInfo.Controls.Add(metroSetLabel1);
            panelClientInfo.IsDerivedStyle = true;
            panelClientInfo.Location = new Point(12, 16);
            panelClientInfo.Name = "panelClientInfo";
            panelClientInfo.Size = new Size(683, 541);
            panelClientInfo.Style = MetroSet_UI.Enums.Style.Custom;
            panelClientInfo.StyleManager = styleManager1;
            panelClientInfo.TabIndex = 0;
            panelClientInfo.ThemeAuthor = null;
            panelClientInfo.ThemeName = null;
            // 
            // lblNewAdd
            // 
            lblNewAdd.Font = new Font("Leelawadee UI", 10F, FontStyle.Bold);
            lblNewAdd.IsDerivedStyle = true;
            lblNewAdd.Location = new Point(3, 4);
            lblNewAdd.Name = "lblNewAdd";
            lblNewAdd.Size = new Size(153, 27);
            lblNewAdd.Style = MetroSet_UI.Enums.Style.Custom;
            lblNewAdd.StyleManager = null;
            lblNewAdd.TabIndex = 42;
            lblNewAdd.Text = "New Reservation";
            lblNewAdd.ThemeAuthor = "";
            lblNewAdd.ThemeName = "";
            lblNewAdd.Visible = false;
            // 
            // btnSave
            // 
            btnSave.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnSave.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnSave.DisabledForeColor = Color.Gray;
            btnSave.Font = new Font("Microsoft Sans Serif", 10F);
            btnSave.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnSave.HoverColor = Color.FromArgb(95, 207, 255);
            btnSave.HoverTextColor = Color.White;
            btnSave.IsDerivedStyle = true;
            btnSave.Location = new Point(380, 489);
            btnSave.Name = "btnSave";
            btnSave.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnSave.NormalColor = Color.FromArgb(10, 182, 139);
            btnSave.NormalTextColor = Color.White;
            btnSave.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnSave.PressColor = Color.FromArgb(35, 147, 195);
            btnSave.PressTextColor = Color.White;
            btnSave.Size = new Size(293, 35);
            btnSave.Style = MetroSet_UI.Enums.Style.Custom;
            btnSave.StyleManager = null;
            btnSave.TabIndex = 42;
            btnSave.Text = "Save Changes";
            btnSave.ThemeAuthor = "";
            btnSave.ThemeName = "";
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // checkboxRoomServiceStatus
            // 
            checkboxRoomServiceStatus.BackColor = Color.Transparent;
            checkboxRoomServiceStatus.BackgroundColor = Color.White;
            checkboxRoomServiceStatus.BorderColor = Color.FromArgb(155, 155, 155);
            checkboxRoomServiceStatus.Checked = false;
            checkboxRoomServiceStatus.CheckSignColor = Color.FromArgb(65, 177, 225);
            checkboxRoomServiceStatus.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            checkboxRoomServiceStatus.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            checkboxRoomServiceStatus.Enabled = false;
            checkboxRoomServiceStatus.Font = new Font("Microsoft Sans Serif", 10F);
            checkboxRoomServiceStatus.IsDerivedStyle = true;
            checkboxRoomServiceStatus.Location = new Point(380, 395);
            checkboxRoomServiceStatus.Name = "checkboxRoomServiceStatus";
            checkboxRoomServiceStatus.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            checkboxRoomServiceStatus.Size = new Size(208, 16);
            checkboxRoomServiceStatus.Style = MetroSet_UI.Enums.Style.Light;
            checkboxRoomServiceStatus.StyleManager = null;
            checkboxRoomServiceStatus.TabIndex = 19;
            checkboxRoomServiceStatus.Text = "Room Service Status ";
            checkboxRoomServiceStatus.ThemeAuthor = "Narwin";
            checkboxRoomServiceStatus.ThemeName = "MetroLite";
            // 
            // metroSetLabel17
            // 
            metroSetLabel17.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel17.IsDerivedStyle = true;
            metroSetLabel17.Location = new Point(538, 97);
            metroSetLabel17.Name = "metroSetLabel17";
            metroSetLabel17.Size = new Size(135, 23);
            metroSetLabel17.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel17.StyleManager = null;
            metroSetLabel17.TabIndex = 37;
            metroSetLabel17.Text = "Room Num.";
            metroSetLabel17.ThemeAuthor = "Narwin";
            metroSetLabel17.ThemeName = "MetroLite";
            // 
            // metroSetLabel16
            // 
            metroSetLabel16.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel16.IsDerivedStyle = true;
            metroSetLabel16.Location = new Point(380, 99);
            metroSetLabel16.Name = "metroSetLabel16";
            metroSetLabel16.Size = new Size(135, 23);
            metroSetLabel16.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel16.StyleManager = null;
            metroSetLabel16.TabIndex = 36;
            metroSetLabel16.Text = "Floor";
            metroSetLabel16.ThemeAuthor = "Narwin";
            metroSetLabel16.ThemeName = "MetroLite";
            // 
            // metroSetLabel15
            // 
            metroSetLabel15.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel15.IsDerivedStyle = true;
            metroSetLabel15.Location = new Point(538, 33);
            metroSetLabel15.Name = "metroSetLabel15";
            metroSetLabel15.Size = new Size(135, 23);
            metroSetLabel15.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel15.StyleManager = null;
            metroSetLabel15.TabIndex = 35;
            metroSetLabel15.Text = "Room Type";
            metroSetLabel15.ThemeAuthor = "Narwin";
            metroSetLabel15.ThemeName = "MetroLite";
            // 
            // metroSetLabel14
            // 
            metroSetLabel14.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel14.IsDerivedStyle = true;
            metroSetLabel14.Location = new Point(380, 33);
            metroSetLabel14.Name = "metroSetLabel14";
            metroSetLabel14.Size = new Size(135, 23);
            metroSetLabel14.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel14.StyleManager = null;
            metroSetLabel14.TabIndex = 34;
            metroSetLabel14.Text = "Num. Of Guests";
            metroSetLabel14.ThemeAuthor = "Narwin";
            metroSetLabel14.ThemeName = "MetroLite";
            // 
            // metroSetLabel13
            // 
            metroSetLabel13.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel13.IsDerivedStyle = true;
            metroSetLabel13.Location = new Point(14, 476);
            metroSetLabel13.Name = "metroSetLabel13";
            metroSetLabel13.Size = new Size(146, 19);
            metroSetLabel13.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel13.StyleManager = null;
            metroSetLabel13.TabIndex = 33;
            metroSetLabel13.Text = "Governorate";
            metroSetLabel13.ThemeAuthor = "Narwin";
            metroSetLabel13.ThemeName = "MetroLite";
            // 
            // metroSetLabel9
            // 
            metroSetLabel9.Font = new Font("Leelawadee UI", 10F, FontStyle.Bold);
            metroSetLabel9.IsDerivedStyle = true;
            metroSetLabel9.Location = new Point(467, 4);
            metroSetLabel9.Name = "metroSetLabel9";
            metroSetLabel9.Size = new Size(216, 29);
            metroSetLabel9.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel9.StyleManager = null;
            metroSetLabel9.TabIndex = 32;
            metroSetLabel9.Text = "Room Details";
            metroSetLabel9.ThemeAuthor = "Narwin";
            metroSetLabel9.ThemeName = "MetroLite";
            // 
            // checkboxCheckedIn
            // 
            checkboxCheckedIn.BackColor = Color.Transparent;
            checkboxCheckedIn.BackgroundColor = Color.White;
            checkboxCheckedIn.BorderColor = Color.FromArgb(155, 155, 155);
            checkboxCheckedIn.Checked = false;
            checkboxCheckedIn.CheckSignColor = Color.FromArgb(65, 177, 225);
            checkboxCheckedIn.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            checkboxCheckedIn.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            checkboxCheckedIn.Font = new Font("Microsoft Sans Serif", 10F);
            checkboxCheckedIn.IsDerivedStyle = true;
            checkboxCheckedIn.Location = new Point(380, 354);
            checkboxCheckedIn.Name = "checkboxCheckedIn";
            checkboxCheckedIn.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            checkboxCheckedIn.Size = new Size(125, 16);
            checkboxCheckedIn.Style = MetroSet_UI.Enums.Style.Light;
            checkboxCheckedIn.StyleManager = null;
            checkboxCheckedIn.TabIndex = 18;
            checkboxCheckedIn.Text = "Checked-in";
            checkboxCheckedIn.ThemeAuthor = "Narwin";
            checkboxCheckedIn.ThemeName = "MetroLite";
            // 
            // btnBill
            // 
            btnBill.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnBill.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnBill.DisabledForeColor = Color.Gray;
            btnBill.Font = new Font("Microsoft Sans Serif", 10F);
            btnBill.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnBill.HoverColor = Color.FromArgb(95, 207, 255);
            btnBill.HoverTextColor = Color.White;
            btnBill.IsDerivedStyle = true;
            btnBill.Location = new Point(380, 433);
            btnBill.Name = "btnBill";
            btnBill.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnBill.NormalColor = Color.FromArgb(65, 177, 225);
            btnBill.NormalTextColor = Color.White;
            btnBill.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnBill.PressColor = Color.FromArgb(35, 147, 195);
            btnBill.PressTextColor = Color.White;
            btnBill.Size = new Size(293, 35);
            btnBill.Style = MetroSet_UI.Enums.Style.Light;
            btnBill.StyleManager = null;
            btnBill.TabIndex = 27;
            btnBill.Text = "Bill";
            btnBill.ThemeAuthor = "Narwin";
            btnBill.ThemeName = "MetroLite";
            btnBill.Click += btnBill_Click;
            // 
            // btnRoomService
            // 
            btnRoomService.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnRoomService.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnRoomService.DisabledForeColor = Color.Gray;
            btnRoomService.Font = new Font("Microsoft Sans Serif", 10F);
            btnRoomService.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnRoomService.HoverColor = Color.FromArgb(95, 207, 255);
            btnRoomService.HoverTextColor = Color.White;
            btnRoomService.IsDerivedStyle = true;
            btnRoomService.Location = new Point(380, 298);
            btnRoomService.Name = "btnRoomService";
            btnRoomService.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnRoomService.NormalColor = Color.FromArgb(65, 177, 225);
            btnRoomService.NormalTextColor = Color.White;
            btnRoomService.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnRoomService.PressColor = Color.FromArgb(35, 147, 195);
            btnRoomService.PressTextColor = Color.White;
            btnRoomService.Size = new Size(293, 35);
            btnRoomService.Style = MetroSet_UI.Enums.Style.Light;
            btnRoomService.StyleManager = null;
            btnRoomService.TabIndex = 27;
            btnRoomService.Text = "Room Service Options";
            btnRoomService.ThemeAuthor = "Narwin";
            btnRoomService.ThemeName = "MetroLite";
            btnRoomService.Click += btnRoomService_Click;
            // 
            // comboboxRoomNum
            // 
            comboboxRoomNum.AllowDrop = true;
            comboboxRoomNum.ArrowColor = Color.FromArgb(150, 150, 150);
            comboboxRoomNum.BackColor = Color.Transparent;
            comboboxRoomNum.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboboxRoomNum.BorderColor = Color.FromArgb(150, 150, 150);
            comboboxRoomNum.CausesValidation = false;
            comboboxRoomNum.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboboxRoomNum.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboboxRoomNum.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboboxRoomNum.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxRoomNum.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxRoomNum.Font = new Font("Microsoft Sans Serif", 11F);
            comboboxRoomNum.FormattingEnabled = true;
            comboboxRoomNum.IsDerivedStyle = true;
            comboboxRoomNum.ItemHeight = 20;
            comboboxRoomNum.Items.AddRange(new object[] { "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309" });
            comboboxRoomNum.Location = new Point(538, 123);
            comboboxRoomNum.MaxDropDownItems = 20;
            comboboxRoomNum.Name = "comboboxRoomNum";
            comboboxRoomNum.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboboxRoomNum.SelectedItemForeColor = Color.White;
            comboboxRoomNum.Size = new Size(135, 26);
            comboboxRoomNum.Style = MetroSet_UI.Enums.Style.Light;
            comboboxRoomNum.StyleManager = null;
            comboboxRoomNum.TabIndex = 15;
            comboboxRoomNum.ThemeAuthor = "Narwin";
            comboboxRoomNum.ThemeName = "MetroLite";
            // 
            // comboboxFloor
            // 
            comboboxFloor.AllowDrop = true;
            comboboxFloor.ArrowColor = Color.FromArgb(150, 150, 150);
            comboboxFloor.BackColor = Color.Transparent;
            comboboxFloor.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboboxFloor.BorderColor = Color.FromArgb(150, 150, 150);
            comboboxFloor.CausesValidation = false;
            comboboxFloor.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboboxFloor.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboboxFloor.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboboxFloor.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxFloor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxFloor.Font = new Font("Microsoft Sans Serif", 11F);
            comboboxFloor.FormattingEnabled = true;
            comboboxFloor.IsDerivedStyle = true;
            comboboxFloor.ItemHeight = 20;
            comboboxFloor.Items.AddRange(new object[] { "1", "2", "3" });
            comboboxFloor.Location = new Point(380, 123);
            comboboxFloor.Name = "comboboxFloor";
            comboboxFloor.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboboxFloor.SelectedItemForeColor = Color.White;
            comboboxFloor.Size = new Size(135, 26);
            comboboxFloor.Style = MetroSet_UI.Enums.Style.Light;
            comboboxFloor.StyleManager = null;
            comboboxFloor.TabIndex = 14;
            comboboxFloor.ThemeAuthor = "Narwin";
            comboboxFloor.ThemeName = "MetroLite";
            // 
            // comboboxRoomType
            // 
            comboboxRoomType.AllowDrop = true;
            comboboxRoomType.ArrowColor = Color.FromArgb(150, 150, 150);
            comboboxRoomType.BackColor = Color.Transparent;
            comboboxRoomType.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboboxRoomType.BorderColor = Color.FromArgb(150, 150, 150);
            comboboxRoomType.CausesValidation = false;
            comboboxRoomType.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboboxRoomType.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboboxRoomType.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboboxRoomType.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxRoomType.Font = new Font("Microsoft Sans Serif", 11F);
            comboboxRoomType.FormattingEnabled = true;
            comboboxRoomType.IsDerivedStyle = true;
            comboboxRoomType.ItemHeight = 20;
            comboboxRoomType.Items.AddRange(new object[] { "Single", "Double", "Duplex", "Suite" });
            comboboxRoomType.Location = new Point(538, 59);
            comboboxRoomType.Name = "comboboxRoomType";
            comboboxRoomType.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboboxRoomType.SelectedItemForeColor = Color.White;
            comboboxRoomType.Size = new Size(135, 26);
            comboboxRoomType.Style = MetroSet_UI.Enums.Style.Light;
            comboboxRoomType.StyleManager = null;
            comboboxRoomType.TabIndex = 13;
            comboboxRoomType.ThemeAuthor = "Narwin";
            comboboxRoomType.ThemeName = "MetroLite";
            // 
            // comboboxNumGuests
            // 
            comboboxNumGuests.AllowDrop = true;
            comboboxNumGuests.ArrowColor = Color.FromArgb(150, 150, 150);
            comboboxNumGuests.BackColor = Color.Transparent;
            comboboxNumGuests.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboboxNumGuests.BorderColor = Color.FromArgb(150, 150, 150);
            comboboxNumGuests.CausesValidation = false;
            comboboxNumGuests.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboboxNumGuests.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboboxNumGuests.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboboxNumGuests.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxNumGuests.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxNumGuests.Font = new Font("Microsoft Sans Serif", 11F);
            comboboxNumGuests.FormattingEnabled = true;
            comboboxNumGuests.IsDerivedStyle = true;
            comboboxNumGuests.ItemHeight = 20;
            comboboxNumGuests.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboboxNumGuests.Location = new Point(380, 59);
            comboboxNumGuests.Name = "comboboxNumGuests";
            comboboxNumGuests.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboboxNumGuests.SelectedItemForeColor = Color.White;
            comboboxNumGuests.Size = new Size(135, 26);
            comboboxNumGuests.Style = MetroSet_UI.Enums.Style.Light;
            comboboxNumGuests.StyleManager = null;
            comboboxNumGuests.TabIndex = 12;
            comboboxNumGuests.ThemeAuthor = "Narwin";
            comboboxNumGuests.ThemeName = "MetroLite";
            // 
            // pickerToDate
            // 
            pickerToDate.Font = new Font("Microsoft Sans Serif", 10F);
            pickerToDate.Location = new Point(481, 247);
            pickerToDate.Name = "pickerToDate";
            pickerToDate.Size = new Size(192, 26);
            pickerToDate.TabIndex = 17;
            // 
            // pickerFromDate
            // 
            pickerFromDate.Font = new Font("Microsoft Sans Serif", 10F);
            pickerFromDate.Location = new Point(481, 186);
            pickerFromDate.Name = "pickerFromDate";
            pickerFromDate.Size = new Size(192, 26);
            pickerFromDate.TabIndex = 16;
            // 
            // txtboxZipCode
            // 
            txtboxZipCode.AutoCompleteCustomSource = null;
            txtboxZipCode.AutoCompleteMode = AutoCompleteMode.None;
            txtboxZipCode.AutoCompleteSource = AutoCompleteSource.None;
            txtboxZipCode.BorderColor = Color.FromArgb(155, 155, 155);
            txtboxZipCode.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtboxZipCode.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtboxZipCode.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtboxZipCode.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxZipCode.HoverColor = Color.FromArgb(102, 102, 102);
            txtboxZipCode.Image = null;
            txtboxZipCode.IsDerivedStyle = true;
            txtboxZipCode.Lines = null;
            txtboxZipCode.Location = new Point(178, 498);
            txtboxZipCode.MaxLength = 32767;
            txtboxZipCode.Multiline = false;
            txtboxZipCode.Name = "txtboxZipCode";
            txtboxZipCode.ReadOnly = false;
            txtboxZipCode.Size = new Size(139, 26);
            txtboxZipCode.Style = MetroSet_UI.Enums.Style.Light;
            txtboxZipCode.StyleManager = null;
            txtboxZipCode.TabIndex = 11;
            txtboxZipCode.TextAlign = HorizontalAlignment.Left;
            txtboxZipCode.ThemeAuthor = "Narwin";
            txtboxZipCode.ThemeName = "MetroLite";
            txtboxZipCode.UseSystemPasswordChar = false;
            txtboxZipCode.WatermarkText = "ZipCode";
            // 
            // txtboxApt
            // 
            txtboxApt.AutoCompleteCustomSource = null;
            txtboxApt.AutoCompleteMode = AutoCompleteMode.None;
            txtboxApt.AutoCompleteSource = AutoCompleteSource.None;
            txtboxApt.BorderColor = Color.FromArgb(155, 155, 155);
            txtboxApt.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtboxApt.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtboxApt.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtboxApt.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxApt.HoverColor = Color.FromArgb(102, 102, 102);
            txtboxApt.Image = null;
            txtboxApt.IsDerivedStyle = true;
            txtboxApt.Lines = null;
            txtboxApt.Location = new Point(178, 436);
            txtboxApt.MaxLength = 32767;
            txtboxApt.Multiline = false;
            txtboxApt.Name = "txtboxApt";
            txtboxApt.ReadOnly = false;
            txtboxApt.Size = new Size(139, 26);
            txtboxApt.Style = MetroSet_UI.Enums.Style.Light;
            txtboxApt.StyleManager = null;
            txtboxApt.TabIndex = 9;
            txtboxApt.TextAlign = HorizontalAlignment.Left;
            txtboxApt.ThemeAuthor = "Narwin";
            txtboxApt.ThemeName = "MetroLite";
            txtboxApt.UseSystemPasswordChar = false;
            txtboxApt.WatermarkText = "Apt.";
            // 
            // txtboxCity
            // 
            txtboxCity.AutoCompleteCustomSource = null;
            txtboxCity.AutoCompleteMode = AutoCompleteMode.None;
            txtboxCity.AutoCompleteSource = AutoCompleteSource.None;
            txtboxCity.BorderColor = Color.FromArgb(155, 155, 155);
            txtboxCity.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtboxCity.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtboxCity.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtboxCity.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxCity.HoverColor = Color.FromArgb(102, 102, 102);
            txtboxCity.Image = null;
            txtboxCity.IsDerivedStyle = true;
            txtboxCity.Lines = null;
            txtboxCity.Location = new Point(14, 436);
            txtboxCity.MaxLength = 32767;
            txtboxCity.Multiline = false;
            txtboxCity.Name = "txtboxCity";
            txtboxCity.ReadOnly = false;
            txtboxCity.Size = new Size(138, 26);
            txtboxCity.Style = MetroSet_UI.Enums.Style.Light;
            txtboxCity.StyleManager = null;
            txtboxCity.TabIndex = 8;
            txtboxCity.TextAlign = HorizontalAlignment.Left;
            txtboxCity.ThemeAuthor = "Narwin";
            txtboxCity.ThemeName = "MetroLite";
            txtboxCity.UseSystemPasswordChar = false;
            txtboxCity.WatermarkText = "City";
            // 
            // txtboxStreet
            // 
            txtboxStreet.AutoCompleteCustomSource = null;
            txtboxStreet.AutoCompleteMode = AutoCompleteMode.None;
            txtboxStreet.AutoCompleteSource = AutoCompleteSource.None;
            txtboxStreet.BorderColor = Color.FromArgb(155, 155, 155);
            txtboxStreet.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtboxStreet.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtboxStreet.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtboxStreet.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxStreet.HoverColor = Color.FromArgb(102, 102, 102);
            txtboxStreet.Image = null;
            txtboxStreet.IsDerivedStyle = true;
            txtboxStreet.Lines = null;
            txtboxStreet.Location = new Point(15, 376);
            txtboxStreet.MaxLength = 32767;
            txtboxStreet.Multiline = false;
            txtboxStreet.Name = "txtboxStreet";
            txtboxStreet.ReadOnly = false;
            txtboxStreet.Size = new Size(302, 26);
            txtboxStreet.Style = MetroSet_UI.Enums.Style.Light;
            txtboxStreet.StyleManager = null;
            txtboxStreet.TabIndex = 7;
            txtboxStreet.TextAlign = HorizontalAlignment.Left;
            txtboxStreet.ThemeAuthor = "Narwin";
            txtboxStreet.ThemeName = "MetroLite";
            txtboxStreet.UseSystemPasswordChar = false;
            txtboxStreet.WatermarkText = "Street";
            // 
            // comboboxGovernment
            // 
            comboboxGovernment.AllowDrop = true;
            comboboxGovernment.ArrowColor = Color.FromArgb(150, 150, 150);
            comboboxGovernment.BackColor = Color.Transparent;
            comboboxGovernment.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboboxGovernment.BorderColor = Color.FromArgb(150, 150, 150);
            comboboxGovernment.CausesValidation = false;
            comboboxGovernment.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboboxGovernment.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboboxGovernment.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboboxGovernment.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxGovernment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxGovernment.Font = new Font("Microsoft Sans Serif", 11F);
            comboboxGovernment.FormattingEnabled = true;
            comboboxGovernment.IsDerivedStyle = true;
            comboboxGovernment.ItemHeight = 20;
            comboboxGovernment.Items.AddRange(new object[] { "cairo", "giza", "alex", "assyut", "minia" });
            comboboxGovernment.Location = new Point(14, 498);
            comboboxGovernment.Name = "comboboxGovernment";
            comboboxGovernment.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboboxGovernment.SelectedItemForeColor = Color.White;
            comboboxGovernment.Size = new Size(138, 26);
            comboboxGovernment.Style = MetroSet_UI.Enums.Style.Light;
            comboboxGovernment.StyleManager = null;
            comboboxGovernment.TabIndex = 10;
            comboboxGovernment.ThemeAuthor = "Narwin";
            comboboxGovernment.ThemeName = "MetroLite";
            // 
            // txtboxPhone
            // 
            txtboxPhone.AutoCompleteCustomSource = null;
            txtboxPhone.AutoCompleteMode = AutoCompleteMode.None;
            txtboxPhone.AutoCompleteSource = AutoCompleteSource.None;
            txtboxPhone.BorderColor = Color.FromArgb(155, 155, 155);
            txtboxPhone.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtboxPhone.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtboxPhone.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtboxPhone.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxPhone.HoverColor = Color.FromArgb(102, 102, 102);
            txtboxPhone.Image = null;
            txtboxPhone.IsDerivedStyle = true;
            txtboxPhone.Lines = null;
            txtboxPhone.Location = new Point(14, 246);
            txtboxPhone.MaxLength = 32767;
            txtboxPhone.Multiline = false;
            txtboxPhone.Name = "txtboxPhone";
            txtboxPhone.ReadOnly = false;
            txtboxPhone.Size = new Size(302, 26);
            txtboxPhone.Style = MetroSet_UI.Enums.Style.Light;
            txtboxPhone.StyleManager = null;
            txtboxPhone.TabIndex = 5;
            txtboxPhone.TextAlign = HorizontalAlignment.Left;
            txtboxPhone.ThemeAuthor = "Narwin";
            txtboxPhone.ThemeName = "MetroLite";
            txtboxPhone.UseSystemPasswordChar = false;
            txtboxPhone.WatermarkText = "011-1111-1111";
            // 
            // txtboxEmailAddress
            // 
            txtboxEmailAddress.AutoCompleteCustomSource = null;
            txtboxEmailAddress.AutoCompleteMode = AutoCompleteMode.None;
            txtboxEmailAddress.AutoCompleteSource = AutoCompleteSource.None;
            txtboxEmailAddress.BorderColor = Color.FromArgb(155, 155, 155);
            txtboxEmailAddress.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtboxEmailAddress.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtboxEmailAddress.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtboxEmailAddress.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxEmailAddress.HoverColor = Color.FromArgb(102, 102, 102);
            txtboxEmailAddress.Image = null;
            txtboxEmailAddress.IsDerivedStyle = true;
            txtboxEmailAddress.Lines = null;
            txtboxEmailAddress.Location = new Point(14, 184);
            txtboxEmailAddress.MaxLength = 32767;
            txtboxEmailAddress.Multiline = false;
            txtboxEmailAddress.Name = "txtboxEmailAddress";
            txtboxEmailAddress.ReadOnly = false;
            txtboxEmailAddress.Size = new Size(302, 26);
            txtboxEmailAddress.Style = MetroSet_UI.Enums.Style.Light;
            txtboxEmailAddress.StyleManager = null;
            txtboxEmailAddress.TabIndex = 4;
            txtboxEmailAddress.TextAlign = HorizontalAlignment.Left;
            txtboxEmailAddress.ThemeAuthor = "Narwin";
            txtboxEmailAddress.ThemeName = "MetroLite";
            txtboxEmailAddress.UseSystemPasswordChar = false;
            txtboxEmailAddress.WatermarkText = "abc123@xyz.com";
            // 
            // comboboxGender
            // 
            comboboxGender.AllowDrop = true;
            comboboxGender.ArrowColor = Color.FromArgb(150, 150, 150);
            comboboxGender.BackColor = Color.Transparent;
            comboboxGender.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboboxGender.BorderColor = Color.FromArgb(150, 150, 150);
            comboboxGender.CausesValidation = false;
            comboboxGender.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboboxGender.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboboxGender.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboboxGender.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxGender.Font = new Font("Microsoft Sans Serif", 11F);
            comboboxGender.FormattingEnabled = true;
            comboboxGender.IsDerivedStyle = true;
            comboboxGender.ItemHeight = 20;
            comboboxGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboboxGender.Location = new Point(14, 122);
            comboboxGender.Name = "comboboxGender";
            comboboxGender.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboboxGender.SelectedItemForeColor = Color.White;
            comboboxGender.Size = new Size(302, 26);
            comboboxGender.Style = MetroSet_UI.Enums.Style.Light;
            comboboxGender.StyleManager = null;
            comboboxGender.TabIndex = 3;
            comboboxGender.ThemeAuthor = "Narwin";
            comboboxGender.ThemeName = "MetroLite";
            // 
            // pickerBirthday
            // 
            pickerBirthday.Font = new Font("Microsoft Sans Serif", 10F);
            pickerBirthday.Location = new Point(15, 307);
            pickerBirthday.Name = "pickerBirthday";
            pickerBirthday.Size = new Size(302, 26);
            pickerBirthday.TabIndex = 6;
            // 
            // txtboxLname
            // 
            txtboxLname.AutoCompleteCustomSource = null;
            txtboxLname.AutoCompleteMode = AutoCompleteMode.None;
            txtboxLname.AutoCompleteSource = AutoCompleteSource.None;
            txtboxLname.BorderColor = Color.FromArgb(155, 155, 155);
            txtboxLname.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtboxLname.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtboxLname.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtboxLname.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxLname.HoverColor = Color.FromArgb(102, 102, 102);
            txtboxLname.Image = null;
            txtboxLname.IsDerivedStyle = true;
            txtboxLname.Lines = null;
            txtboxLname.Location = new Point(177, 58);
            txtboxLname.MaxLength = 32767;
            txtboxLname.Multiline = false;
            txtboxLname.Name = "txtboxLname";
            txtboxLname.ReadOnly = false;
            txtboxLname.Size = new Size(139, 29);
            txtboxLname.Style = MetroSet_UI.Enums.Style.Light;
            txtboxLname.StyleManager = null;
            txtboxLname.TabIndex = 2;
            txtboxLname.TextAlign = HorizontalAlignment.Left;
            txtboxLname.ThemeAuthor = "Narwin";
            txtboxLname.ThemeName = "MetroLite";
            txtboxLname.UseSystemPasswordChar = false;
            txtboxLname.WatermarkText = "Last";
            // 
            // txtboxFname
            // 
            txtboxFname.AutoCompleteCustomSource = null;
            txtboxFname.AutoCompleteMode = AutoCompleteMode.None;
            txtboxFname.AutoCompleteSource = AutoCompleteSource.None;
            txtboxFname.BorderColor = Color.FromArgb(155, 155, 155);
            txtboxFname.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtboxFname.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtboxFname.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtboxFname.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxFname.HoverColor = Color.FromArgb(102, 102, 102);
            txtboxFname.Image = null;
            txtboxFname.IsDerivedStyle = true;
            txtboxFname.Lines = null;
            txtboxFname.Location = new Point(14, 58);
            txtboxFname.MaxLength = 32767;
            txtboxFname.Multiline = false;
            txtboxFname.Name = "txtboxFname";
            txtboxFname.ReadOnly = false;
            txtboxFname.Size = new Size(139, 29);
            txtboxFname.Style = MetroSet_UI.Enums.Style.Light;
            txtboxFname.StyleManager = null;
            txtboxFname.TabIndex = 1;
            txtboxFname.TextAlign = HorizontalAlignment.Left;
            txtboxFname.ThemeAuthor = "Narwin";
            txtboxFname.ThemeName = "MetroLite";
            txtboxFname.UseSystemPasswordChar = false;
            txtboxFname.WatermarkText = "First";
            // 
            // metroSetLabel10
            // 
            metroSetLabel10.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel10.IsDerivedStyle = true;
            metroSetLabel10.Location = new Point(380, 247);
            metroSetLabel10.Name = "metroSetLabel10";
            metroSetLabel10.Size = new Size(125, 29);
            metroSetLabel10.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel10.StyleManager = null;
            metroSetLabel10.TabIndex = 9;
            metroSetLabel10.Text = "To Date";
            metroSetLabel10.ThemeAuthor = "Narwin";
            metroSetLabel10.ThemeName = "MetroLite";
            // 
            // metroSetLabel8
            // 
            metroSetLabel8.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel8.IsDerivedStyle = true;
            metroSetLabel8.Location = new Point(380, 186);
            metroSetLabel8.Name = "metroSetLabel8";
            metroSetLabel8.Size = new Size(125, 29);
            metroSetLabel8.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel8.StyleManager = null;
            metroSetLabel8.TabIndex = 7;
            metroSetLabel8.Text = "From Date";
            metroSetLabel8.ThemeAuthor = "Narwin";
            metroSetLabel8.ThemeName = "MetroLite";
            // 
            // metroSetLabel6
            // 
            metroSetLabel6.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel6.IsDerivedStyle = true;
            metroSetLabel6.Location = new Point(14, 224);
            metroSetLabel6.Name = "metroSetLabel6";
            metroSetLabel6.Size = new Size(125, 29);
            metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel6.StyleManager = null;
            metroSetLabel6.TabIndex = 5;
            metroSetLabel6.Text = "Phone Number";
            metroSetLabel6.ThemeAuthor = "Narwin";
            metroSetLabel6.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            metroSetLabel5.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel5.IsDerivedStyle = true;
            metroSetLabel5.Location = new Point(14, 99);
            metroSetLabel5.Name = "metroSetLabel5";
            metroSetLabel5.Size = new Size(125, 29);
            metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel5.StyleManager = null;
            metroSetLabel5.TabIndex = 4;
            metroSetLabel5.Text = "Gender";
            metroSetLabel5.ThemeAuthor = "Narwin";
            metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            metroSetLabel4.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel4.IsDerivedStyle = true;
            metroSetLabel4.Location = new Point(15, 350);
            metroSetLabel4.Name = "metroSetLabel4";
            metroSetLabel4.Size = new Size(125, 29);
            metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel4.StyleManager = null;
            metroSetLabel4.TabIndex = 3;
            metroSetLabel4.Text = "Address";
            metroSetLabel4.ThemeAuthor = "Narwin";
            metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            metroSetLabel3.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel3.IsDerivedStyle = true;
            metroSetLabel3.Location = new Point(14, 284);
            metroSetLabel3.Name = "metroSetLabel3";
            metroSetLabel3.Size = new Size(125, 29);
            metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel3.StyleManager = null;
            metroSetLabel3.TabIndex = 2;
            metroSetLabel3.Text = "Birthday";
            metroSetLabel3.ThemeAuthor = "Narwin";
            metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            metroSetLabel2.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel2.IsDerivedStyle = true;
            metroSetLabel2.Location = new Point(14, 161);
            metroSetLabel2.Name = "metroSetLabel2";
            metroSetLabel2.Size = new Size(125, 29);
            metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel2.StyleManager = null;
            metroSetLabel2.TabIndex = 1;
            metroSetLabel2.Text = "Email Address";
            metroSetLabel2.ThemeAuthor = "Narwin";
            metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            metroSetLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel1.IsDerivedStyle = true;
            metroSetLabel1.Location = new Point(14, 33);
            metroSetLabel1.Name = "metroSetLabel1";
            metroSetLabel1.Size = new Size(125, 29);
            metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel1.StyleManager = null;
            metroSetLabel1.TabIndex = 0;
            metroSetLabel1.Text = "Name";
            metroSetLabel1.ThemeAuthor = "Narwin";
            metroSetLabel1.ThemeName = "MetroLite";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(0, 0, 0, 1);
            tabPage2.Controls.Add(btnSearch);
            tabPage2.Controls.Add(txtboxSearch);
            tabPage2.Controls.Add(searchGridView);
            tabPage2.Location = new Point(4, 42);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1034, 572);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackgroundImage = Properties.Resources.magnifying_glass_or_search_icon_on_white_background_illustration_eps_10_vector;
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnSearch.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnSearch.DisabledForeColor = Color.Gray;
            btnSearch.Font = new Font("Microsoft Sans Serif", 10F);
            btnSearch.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnSearch.HoverColor = Color.FromArgb(95, 207, 255);
            btnSearch.HoverTextColor = Color.White;
            btnSearch.IsDerivedStyle = false;
            btnSearch.Location = new Point(820, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.NormalBorderColor = Color.Black;
            btnSearch.NormalColor = Color.FromArgb(0, 0, 0, 1);
            btnSearch.NormalTextColor = Color.White;
            btnSearch.PressBorderColor = Color.FromArgb(0, 0, 0, 1);
            btnSearch.PressColor = Color.FromArgb(0, 0, 0, 1);
            btnSearch.PressTextColor = Color.White;
            btnSearch.Size = new Size(55, 46);
            btnSearch.Style = MetroSet_UI.Enums.Style.Custom;
            btnSearch.StyleManager = null;
            btnSearch.TabIndex = 2;
            btnSearch.ThemeAuthor = "";
            btnSearch.ThemeName = "";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtboxSearch.AutoCompleteCustomSource = null;
            txtboxSearch.AutoCompleteMode = AutoCompleteMode.None;
            txtboxSearch.AutoCompleteSource = AutoCompleteSource.None;
            txtboxSearch.BorderColor = Color.FromArgb(155, 155, 155);
            txtboxSearch.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtboxSearch.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtboxSearch.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtboxSearch.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxSearch.HoverColor = Color.FromArgb(102, 102, 102);
            txtboxSearch.Image = null;
            txtboxSearch.IsDerivedStyle = true;
            txtboxSearch.Lines = null;
            txtboxSearch.Location = new Point(132, 46);
            txtboxSearch.MaxLength = 32767;
            txtboxSearch.Multiline = false;
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.ReadOnly = false;
            txtboxSearch.Size = new Size(697, 46);
            txtboxSearch.Style = MetroSet_UI.Enums.Style.Light;
            txtboxSearch.StyleManager = null;
            txtboxSearch.TabIndex = 0;
            txtboxSearch.Text = "search";
            txtboxSearch.TextAlign = HorizontalAlignment.Left;
            txtboxSearch.ThemeAuthor = "Narwin";
            txtboxSearch.ThemeName = "MetroLite";
            txtboxSearch.UseSystemPasswordChar = false;
            txtboxSearch.WatermarkText = "";
            // 
            // searchGridView
            // 
            searchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGridView.Location = new Point(15, 98);
            searchGridView.Name = "searchGridView";
            searchGridView.RowHeadersWidth = 51;
            searchGridView.Size = new Size(1004, 457);
            searchGridView.TabIndex = 3;
            searchGridView.Visible = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(allClientsGridView);
            tabPage3.Location = new Point(4, 42);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1034, 572);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "All Clients";
            // 
            // allClientsGridView
            // 
            allClientsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            allClientsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allClientsGridView.Location = new Point(14, 17);
            allClientsGridView.Name = "allClientsGridView";
            allClientsGridView.RowHeadersWidth = 51;
            allClientsGridView.Size = new Size(1006, 537);
            allClientsGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(metroSetPanel5);
            tabPage4.Controls.Add(metroSetPanel4);
            tabPage4.Controls.Add(metroSetPanel2);
            tabPage4.Controls.Add(listboxOccupied);
            tabPage4.Controls.Add(listboxReserved);
            tabPage4.Location = new Point(4, 42);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1034, 572);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Room Availability";
            // 
            // metroSetPanel5
            // 
            metroSetPanel5.BackgroundColor = Color.FromArgb(75, 180, 222);
            metroSetPanel5.BorderColor = Color.FromArgb(150, 150, 150);
            metroSetPanel5.BorderThickness = 1;
            metroSetPanel5.Controls.Add(metroSetLabel19);
            metroSetPanel5.IsDerivedStyle = false;
            metroSetPanel5.Location = new Point(19, 306);
            metroSetPanel5.Name = "metroSetPanel5";
            metroSetPanel5.Size = new Size(996, 38);
            metroSetPanel5.Style = MetroSet_UI.Enums.Style.Custom;
            metroSetPanel5.StyleManager = null;
            metroSetPanel5.TabIndex = 5;
            metroSetPanel5.ThemeAuthor = "";
            metroSetPanel5.ThemeName = "";
            // 
            // metroSetLabel19
            // 
            metroSetLabel19.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            metroSetLabel19.IsDerivedStyle = true;
            metroSetLabel19.Location = new Point(439, 2);
            metroSetLabel19.Name = "metroSetLabel19";
            metroSetLabel19.Size = new Size(125, 35);
            metroSetLabel19.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel19.StyleManager = null;
            metroSetLabel19.TabIndex = 2;
            metroSetLabel19.Text = "Occupied";
            metroSetLabel19.ThemeAuthor = "Narwin";
            metroSetLabel19.ThemeName = "MetroLite";
            // 
            // metroSetPanel4
            // 
            metroSetPanel4.BackgroundColor = Color.White;
            metroSetPanel4.BorderColor = Color.FromArgb(150, 150, 150);
            metroSetPanel4.BorderThickness = 1;
            metroSetPanel4.Controls.Add(metroSetLabel18);
            metroSetPanel4.IsDerivedStyle = true;
            metroSetPanel4.Location = new Point(20, 8);
            metroSetPanel4.Name = "metroSetPanel4";
            metroSetPanel4.Size = new Size(996, 38);
            metroSetPanel4.Style = MetroSet_UI.Enums.Style.Light;
            metroSetPanel4.StyleManager = null;
            metroSetPanel4.TabIndex = 5;
            metroSetPanel4.ThemeAuthor = "Narwin";
            metroSetPanel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel18
            // 
            metroSetLabel18.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            metroSetLabel18.IsDerivedStyle = true;
            metroSetLabel18.Location = new Point(16, 4);
            metroSetLabel18.Name = "metroSetLabel18";
            metroSetLabel18.Size = new Size(990, 32);
            metroSetLabel18.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel18.StyleManager = null;
            metroSetLabel18.TabIndex = 2;
            metroSetLabel18.Text = "ID          ||          Full Name          ||          Room#          ||          Arival Date          ||          Leaving Date ";
            metroSetLabel18.ThemeAuthor = "Narwin";
            metroSetLabel18.ThemeName = "MetroLite";
            // 
            // metroSetPanel2
            // 
            metroSetPanel2.BackgroundColor = Color.FromArgb(75, 180, 222);
            metroSetPanel2.BorderColor = Color.FromArgb(150, 150, 150);
            metroSetPanel2.BorderThickness = 1;
            metroSetPanel2.Controls.Add(metroSetLabel11);
            metroSetPanel2.IsDerivedStyle = false;
            metroSetPanel2.Location = new Point(19, 49);
            metroSetPanel2.Name = "metroSetPanel2";
            metroSetPanel2.Size = new Size(996, 38);
            metroSetPanel2.Style = MetroSet_UI.Enums.Style.Custom;
            metroSetPanel2.StyleManager = null;
            metroSetPanel2.TabIndex = 4;
            metroSetPanel2.ThemeAuthor = "";
            metroSetPanel2.ThemeName = "";
            // 
            // metroSetLabel11
            // 
            metroSetLabel11.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            metroSetLabel11.IsDerivedStyle = true;
            metroSetLabel11.Location = new Point(439, 4);
            metroSetLabel11.Name = "metroSetLabel11";
            metroSetLabel11.Size = new Size(125, 32);
            metroSetLabel11.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel11.StyleManager = null;
            metroSetLabel11.TabIndex = 2;
            metroSetLabel11.Text = "Reserved";
            metroSetLabel11.ThemeAuthor = "Narwin";
            metroSetLabel11.ThemeName = "MetroLite";
            // 
            // listboxOccupied
            // 
            listboxOccupied.BackColor = Color.White;
            listboxOccupied.BorderColor = Color.Black;
            listboxOccupied.DisabledBackColor = Color.FromArgb(204, 204, 204);
            listboxOccupied.DisabledForeColor = Color.FromArgb(136, 136, 136);
            listboxOccupied.Font = new Font("Microsoft Sans Serif", 10F);
            listboxOccupied.HoveredItemBackColor = Color.LightGray;
            listboxOccupied.HoveredItemColor = Color.DimGray;
            listboxOccupied.IsDerivedStyle = true;
            listboxOccupied.ItemHeight = 30;
            listboxOccupied.Location = new Point(20, 346);
            listboxOccupied.MultiSelect = false;
            listboxOccupied.Name = "listboxOccupied";
            listboxOccupied.SelectedIndex = -1;
            listboxOccupied.SelectedItem = null;
            listboxOccupied.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            listboxOccupied.SelectedItemColor = Color.White;
            listboxOccupied.SelectedText = null;
            listboxOccupied.SelectedValue = null;
            listboxOccupied.ShowBorder = true;
            listboxOccupied.ShowScrollBar = true;
            listboxOccupied.Size = new Size(996, 212);
            listboxOccupied.Style = MetroSet_UI.Enums.Style.Custom;
            listboxOccupied.StyleManager = null;
            listboxOccupied.TabIndex = 1;
            listboxOccupied.ThemeAuthor = "";
            listboxOccupied.ThemeName = "";
            // 
            // listboxReserved
            // 
            listboxReserved.BackColor = Color.White;
            listboxReserved.BorderColor = Color.Black;
            listboxReserved.DisabledBackColor = Color.FromArgb(204, 204, 204);
            listboxReserved.DisabledForeColor = Color.FromArgb(136, 136, 136);
            listboxReserved.Font = new Font("Microsoft Sans Serif", 10F);
            listboxReserved.HoveredItemBackColor = Color.LightGray;
            listboxReserved.HoveredItemColor = Color.DimGray;
            listboxReserved.IsDerivedStyle = true;
            listboxReserved.ItemHeight = 30;
            listboxReserved.Location = new Point(19, 85);
            listboxReserved.MultiSelect = false;
            listboxReserved.Name = "listboxReserved";
            listboxReserved.SelectedIndex = -1;
            listboxReserved.SelectedItem = null;
            listboxReserved.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            listboxReserved.SelectedItemColor = Color.White;
            listboxReserved.SelectedText = null;
            listboxReserved.SelectedValue = null;
            listboxReserved.ShowBorder = true;
            listboxReserved.ShowScrollBar = true;
            listboxReserved.Size = new Size(996, 212);
            listboxReserved.Style = MetroSet_UI.Enums.Style.Custom;
            listboxReserved.StyleManager = null;
            listboxReserved.TabIndex = 0;
            listboxReserved.ThemeAuthor = "";
            listboxReserved.ThemeName = "";
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = false;
            metroSetControlBox1.Location = new Point(957, 7);
            metroSetControlBox1.MaximizeBox = true;
            metroSetControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroSetControlBox1.MaximumSize = new Size(100, 30);
            metroSetControlBox1.MinimizeBox = true;
            metroSetControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroSetControlBox1.Name = "metroSetControlBox1";
            metroSetControlBox1.Size = new Size(100, 25);
            metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Custom;
            metroSetControlBox1.StyleManager = null;
            metroSetControlBox1.TabIndex = 0;
            metroSetControlBox1.ThemeAuthor = null;
            metroSetControlBox1.ThemeName = null;
            // 
            // lblFrontEnd
            // 
            lblFrontEnd.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrontEnd.IsDerivedStyle = false;
            lblFrontEnd.Location = new Point(16, 16);
            lblFrontEnd.Name = "lblFrontEnd";
            lblFrontEnd.Size = new Size(426, 49);
            lblFrontEnd.Style = MetroSet_UI.Enums.Style.Custom;
            lblFrontEnd.StyleManager = null;
            lblFrontEnd.TabIndex = 2;
            lblFrontEnd.Text = "Frontend Reservation";
            lblFrontEnd.ThemeAuthor = null;
            lblFrontEnd.ThemeName = null;
            // 
            // Frontend
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 0, 1);
            BackgroundColor = Color.FloralWhite;
            BorderColor = Color.Black;
            ClientSize = new Size(1072, 706);
            Controls.Add(metroSetControlBox1);
            Controls.Add(tabControl);
            Controls.Add(lblFrontEnd);
            HeaderColor = Color.White;
            MinimumSize = new Size(1072, 706);
            Name = "Frontend";
            SmallLineColor1 = Color.FromArgb(0, 0, 0, 1);
            SmallLineColor2 = Color.FromArgb(0, 0, 0, 1);
            Style = MetroSet_UI.Enums.Style.Custom;
            StyleManager = styleManager1;
            ThemeAuthor = null;
            ThemeName = null;
            FormClosing += FrontEnd_FormClosing;
            Load += FrontEnd_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            metroSetPanel1.ResumeLayout(false);
            panelClientInfo.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)searchGridView).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allClientsGridView).EndInit();
            tabPage4.ResumeLayout(false);
            metroSetPanel5.ResumeLayout(false);
            metroSetPanel4.ResumeLayout(false);
            metroSetPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MetroSet_UI.Controls.MetroSetTabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetPanel panelClientInfo;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetLabel lblFrontEnd;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel10;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private DateTimePicker pickerBirthday;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxLname;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxFname;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxPhone;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxEmailAddress;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxGender;
        private DateTimePicker pickerFromDate;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxZipCode;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxApt;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxCity;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxStreet;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxGovernment;
        private MetroSet_UI.Controls.MetroSetButton btnRoomService;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxRoomNum;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxFloor;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxNumGuests;
        private DateTimePicker pickerToDate;
        private MetroSet_UI.Controls.MetroSetCheckBox checkboxCheckedIn;
        private MetroSet_UI.Controls.MetroSetButton btnBill;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxExistingReservations;
        private MetroSet_UI.Controls.MetroSetLabel lblExistingReservation;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel9;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel13;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel17;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel16;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel15;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel14;
        private MetroSet_UI.Controls.MetroSetButton btnDelete;
        private MetroSet_UI.Controls.MetroSetButton btnEdit;
        private MetroSet_UI.Controls.MetroSetButton btnAdd;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxRoomType;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxSearch;
        private MetroSet_UI.Controls.MetroSetButton btnSearch;
        private DataGridView searchGridView;
        private DataGridView allClientsGridView;
        private MetroSetListBox listboxReserved;
        private MetroSetListBox listboxOccupied;
        private MetroSetLabel metroSetLabel11;
        private MetroSetPanel metroSetPanel2;
        private MetroSetLabel metroSetLabel18;
        private MetroSetPanel metroSetPanel5;
        private MetroSetLabel metroSetLabel19;
        private MetroSetPanel metroSetPanel4;
        private MetroSetCheckBox checkboxRoomServiceStatus;
        private MetroSetButton btnSave;
        private MetroSetLabel lblNewAdd;
    }
}
