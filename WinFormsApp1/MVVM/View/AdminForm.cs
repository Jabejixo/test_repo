using System;
using System.Data;
using System.Windows.Forms;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using WinFormsApp1.MVVM.Model;
using WinFormsApp1.MVVM.ViewModel;
using WinFormsApp1.MVVM.ViewModel.Helpers;
using Xceed.Words.NET;
using Document = iText.Layout.Document;
using iText.Layout.Properties;
using System.Drawing;
using Microsoft.Office.Interop.Excel;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {
        private AdminFormViewModel _viewModel;
        public CollectionType _collectionType = CollectionType.Users;
        public AdminForm()
        {
            InitializeComponent();
            _viewModel = new AdminFormViewModel();
            userNameTxtBox.DataBindings.Add("Text", _viewModel, "UserName", true, DataSourceUpdateMode.OnPropertyChanged);
            PasswordTxtBox.DataBindings.Add("Text", _viewModel, "Password", true, DataSourceUpdateMode.OnPropertyChanged);
            PriceTxtBox.DataBindings.Add("Text", _viewModel, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
            ServiceNameTxtBox.DataBindings.Add("Text", _viewModel, "ServiceName", true, DataSourceUpdateMode.OnPropertyChanged);
            MasterNameTxtBox.DataBindings.Add("Text", _viewModel, "MasterName", true, DataSourceUpdateMode.OnPropertyChanged);
            DatePicker.DataBindings.Add("Value", _viewModel, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
            TimePicker.DataBindings.Add("Value", _viewModel, "Time", true, DataSourceUpdateMode.OnPropertyChanged);
            RoleCbx.DataBindings.Add("Text", _viewModel, "Role", true, DataSourceUpdateMode.OnPropertyChanged);
            MasterCbx.DataBindings.Add("DataSource", _viewModel, "Masters", true, DataSourceUpdateMode.OnPropertyChanged);
            MasterCbx.DisplayMember = "MasterName";
            MasterCbx.ValueMember = "MasterId";
            MasterCbx.DataBindings.Add("SelectedValue", _viewModel, "MasterId", true, DataSourceUpdateMode.OnPropertyChanged);
            SerciceCbx.DataBindings.Add("DataSource", _viewModel, "Services", true, DataSourceUpdateMode.OnPropertyChanged);
            SerciceCbx.DisplayMember = "ServiceName";
            SerciceCbx.ValueMember = "ServiceId";
            UserCbx.DataBindings.Add("DataSource", _viewModel, "Users", true, DataSourceUpdateMode.OnPropertyChanged);
            UserCbx.DisplayMember = "Email";
            UserCbx.ValueMember = "UserId";
            SerciceCbx.DataBindings.Add("SelectedValue", _viewModel, "ServiceId", true, DataSourceUpdateMode.OnPropertyChanged);
            UserCbx.DataBindings.Add("SelectedValue", _viewModel, "UserId", true, DataSourceUpdateMode.OnPropertyChanged);
            RoleCbx.DataSource = new List<string> { "Admin", "User" };
            DataGrid.DataBindings.Add("DataSource", _viewModel, "CurrentCollection", true, DataSourceUpdateMode.OnPropertyChanged);

            // Привязываем свойство SelectedItem к выбранной строке в DataGridView
            DataGrid.SelectionChanged += (sender, e) =>
            {
                if (DataGrid.SelectedRows.Count > 0)
                {
                    _viewModel.SelectedItem = DataGrid.SelectedRows[0].DataBoundItem;
                    _viewModel.SetParam(_collectionType);
                }
            };
            DataContext = _viewModel;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            _viewModel.Create(_collectionType);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            _viewModel.Update(_collectionType);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            _viewModel.Delete(_collectionType);
        }

        private void WordBtn_Click(object sender, EventArgs e)
        {
            ExportToWord(DataGrid);
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            ExportToExcel(DataGrid);
        }

        private void PdfBtn_Click(object sender, EventArgs e)
        {
            ExportToPDF(DataGrid);
        }

        private void UserDataTableBtn_Click(object sender, EventArgs e)
        {
            _viewModel.UpdateCurrentCollection(CollectionType.Users);
            _collectionType = CollectionType.Users;
            UpdatePanels();
        }

        private void ServicesDataTableBtn_Click(object sender, EventArgs e)
        {
            _viewModel.UpdateCurrentCollection(CollectionType.Services);
            _collectionType = CollectionType.Services;
            UpdatePanels();

        }

        private void MastersDataTableBtn_Click(object sender, EventArgs e)
        {
            _viewModel.UpdateCurrentCollection(CollectionType.Masters);
            _collectionType = CollectionType.Masters;
            UpdatePanels();

        }

        private void ScheduleDataTableBtn_Click(object sender, EventArgs e)
        {
            _viewModel.UpdateCurrentCollection(CollectionType.Schedules);
            _collectionType = CollectionType.Schedules;
            UpdatePanels();

        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // Заголовки столбцов
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cell(1, i).Value = dataGridView.Columns[i - 1].HeaderText;
                }

                // Данные
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Сохранение в файл
                workbook.SaveAs("exported_data.xlsx");
            }

            MessageBox.Show("Данные успешно экспортированы в Excel.");
        }

        private void ExportToWord(DataGridView dataGridView)
        {
            using (var doc = DocX.Create("exported_data.docx"))
            {
                // Заголовки столбцов
                var table = doc.AddTable(dataGridView.Rows.Count + 1, dataGridView.Columns.Count);
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    table.Rows[0].Cells[i].Paragraphs[0].Append(dataGridView.Columns[i].HeaderText);
                }

                // Данные
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        table.Rows[i + 1].Cells[j].Paragraphs[0].Append(dataGridView.Rows[i].Cells[j].Value.ToString());
                    }
                }

                doc.InsertTable(table);

                doc.Save();
            }

            MessageBox.Show("Данные успешно экспортированы в Word.");
        }

        private void ExportToPDF(DataGridView dataGridView)
        {
            PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument();
            document.Info.Title = "DataGridView to PDF";
            
            PdfSharp.Pdf.PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            var options = new XPdfFontOptions(PdfFontEmbedding.Always);
            var font = new XFont("Times New Roman", 12);
            // Заголовки столбцов
            int yPoint = 0;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                gfx.DrawString(dataGridView.Columns[i].HeaderText, font, XBrushes.Black, new XRect(10, yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                yPoint += 20;
            }

            // Данные
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                yPoint += 20;
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    gfx.DrawString(dataGridView.Rows[i].Cells[j].Value.ToString(), font, XBrushes.Black, new XRect(10 + j * 100, yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                }
            }

            // Сохранение в файл
            document.Save("exported_data.pdf");
            
            MessageBox.Show("Данные успешно экспортированы в PDF.");
        }



        private void UpdatePanels()
        {
            switch (_collectionType)
            {
                case CollectionType.Users:
                    NoVisible();
                    userPanel.Visible = true;
                    break;
                case CollectionType.Services:
                    NoVisible();
                    ServicesPanel.Visible = true;
                    break;
                case CollectionType.Masters:
                    NoVisible();
                    MasterPanel.Visible = true;
                    break;
                case CollectionType.Schedules:
                    NoVisible();
                    SchedulePanel.Visible = true;
                    break;
            }
        }

        private void NoVisible()
        {
            userPanel.Visible = false;
            MasterPanel.Visible = false;
            ServicesPanel.Visible = false;
            SchedulePanel.Visible = false;
        }
    }
}
