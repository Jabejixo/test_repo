using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.MVVM.Model;
using WinFormsApp1.MVVM.ViewModel;

namespace WinFormsApp1
{
    public partial class UserServiceRecordForm : Form
    {
        private UserServiceRecordViewModel _viewModel;
        private User _user;
        public UserServiceRecordForm(User user)
        {
            InitializeComponent();
            _viewModel = new UserServiceRecordViewModel(user);
            _user = user;
            DataContext = _viewModel;
            MastersListBox.DataSource = _viewModel.Masters;
            ServiseListBox.DataSource = _viewModel.Services;
            MastersListBox.SelectionMode = SelectionMode.One;
            ServiseListBox.SelectionMode = SelectionMode.One;
            MastersListBox.DisplayMember = "MasterName";
            ServiseListBox.DisplayMember = "ServiceName";
            MastersListBox.ValueMember = "MasterId";
            ServiseListBox.ValueMember = "ServiceId";
            MasterNameTxtBox.DataBindings.Add("Text", _viewModel, "MasterName", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            ServiceNameTxtBox.DataBindings.Add("Text", _viewModel, "ServiceName", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            DateTxtBox.DataBindings.Add("Text", _viewModel, "DateUi", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            TimeTxtBox.DataBindings.Add("Text", _viewModel, "TimeUi", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            DatePicker.DataBindings.Add("Value", _viewModel, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
            TimePicker.DataBindings.Add("Value", _viewModel, "Time", true, DataSourceUpdateMode.OnPropertyChanged);
            DateTxtBox.Enabled = false;
            TimeTxtBox.Enabled = false;
            MasterNameTxtBox.Enabled = false;
            ServiceNameTxtBox.Enabled = false;
        }

        private void UserServiceRecordForm_Load(object sender, EventArgs e)
        {

        }

        private void ServiseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServiseListBox.SelectedIndex != -1)
            {
                _viewModel.ServiceId = ((Service)ServiseListBox.SelectedItem).ServiceId;
                _viewModel.ServiceName = ((Service)ServiseListBox.SelectedItem).ServiceName;
            }
        }

        private void MastersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MastersListBox.SelectedItem != null)
            {
                _viewModel.MasterId = ((Master)MastersListBox.SelectedItem).MasterId;
                _viewModel.MasterName = ((Master)MastersListBox.SelectedItem).MasterName;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm(_user.UserId);
            form.Show();
            Hide();
        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            _viewModel.Record();
            MessageBox.Show("Запись успешно создана");
            UserForm form = new UserForm(_user.UserId);
            form.Show();
            Hide();
        }
    }
}
