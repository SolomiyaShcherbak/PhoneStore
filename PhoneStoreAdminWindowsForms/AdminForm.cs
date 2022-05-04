using PhoneStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStoreAdminWindowsForms
{
    public partial class AdminForm : Form
    {
        private IRepository<Phone> phoneRepository;
        public AdminForm()
        {
            phoneRepository = FactoryCreator.GetFactory().GetPhoneRepository();
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridPhones.DataSource = phoneRepository.GetAll();
        }

        private void buttonAddPhone_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbBrand.Text) ||
                string.IsNullOrEmpty(tbModel.Text))
                {
                    MessageBox.Show("Field is empty", "Error");
                    throw new Error(ErrorCode.FieldIsEmpty);
                }

                if (double.Parse(tbPrice.Text) < 0)
                {
                    MessageBox.Show("Invalid price", "Error");
                    throw new Error(ErrorCode.InvalidPrice);
                }

                for (int i = 0; i < nudQuantity.Value; i++)
                {
                    phoneRepository.Add(new Phone(tbBrand.Text, tbModel.Text, double.Parse(tbPrice.Text)));
                }
                dataGridPhones.DataSource = null;
                dataGridPhones.DataSource = phoneRepository.GetAll();
            }
            catch (Error error)
            {
                Logger.Instance().LogError(error);
            }

            catch
            {
                Logger.Instance().LogError(new Error(ErrorCode.UnknownError));
            }

            tbBrand.Clear();
            tbModel.Clear();
            tbPrice.Clear();
            nudQuantity.Value = 0;
        }

        private void buttonRemovePhone_Click(object sender, EventArgs e)
        {
            try
            {
                if ((rbByBrand.Checked || rbByModel.Checked) &&
                string.IsNullOrEmpty(tbRemoveBy.Text))
                {
                    MessageBox.Show("Field is empty", "Error");
                    throw new Error(ErrorCode.FieldIsEmpty);
                }

                if (rbByBrand.Checked &&
                    !string.IsNullOrEmpty(tbRemoveBy.Text))
                {
                    for (int i = 0; i < phoneRepository.Size; i++)
                    {
                        if (phoneRepository[i].Brand == tbRemoveBy.Text)
                        {
                            phoneRepository.Remove(i);
                            i--;
                        }
                    }
                    tbRemoveBy.Clear();
                    dataGridPhones.DataSource = null;
                    dataGridPhones.DataSource = phoneRepository.GetAll();
                }

                if (rbByModel.Checked &&
                    !string.IsNullOrEmpty(tbRemoveBy.Text))
                {
                    for (int i = 0; i < phoneRepository.Size; i++)
                    {
                        if (phoneRepository[i].Model == tbRemoveBy.Text)
                        {
                            phoneRepository.Remove(i);
                            i--;
                        }
                    }
                    tbRemoveBy.Clear();
                    dataGridPhones.DataSource = null;
                    dataGridPhones.DataSource = phoneRepository.GetAll();
                }

                int selectedRowCount =
                    dataGridPhones.Rows.GetRowCount(DataGridViewElementStates.Selected);

                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        phoneRepository.Remove(dataGridPhones.CurrentRow.Index - i);
                    }
                    dataGridPhones.DataSource = null;
                    dataGridPhones.DataSource = phoneRepository.GetAll();
                }
            }
            catch (Error error)
            {
                Logger.Instance().LogError(error);
            }

            catch
            {
                Logger.Instance().LogError(new Error(ErrorCode.UnknownError));
            }
        }

        private void buttonReplacePhone_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbBrand1.Text) ||
                string.IsNullOrEmpty(tbModel1.Text))
                {
                    MessageBox.Show("Field is empty", "Error");
                    throw new Error(ErrorCode.FieldIsEmpty);
                }

                if (double.Parse(tbPrice1.Text) < 0)
                {
                    MessageBox.Show("Invalid price", "Error");
                    throw new Error(ErrorCode.InvalidPrice);
                }

                phoneRepository.Replace(
                    new Phone(tbBrand1.Text, tbModel1.Text, double.Parse(tbPrice1.Text)),
                    dataGridPhones.CurrentRow.Index);
            }
            catch (Error error)
            {
                Logger.Instance().LogError(error);
            }

            catch
            {
                Logger.Instance().LogError(new Error(ErrorCode.UnknownError));
            }

            tbBrand1.Clear();
            tbModel1.Clear();
            tbPrice1.Clear();

            dataGridPhones.DataSource = null;
            dataGridPhones.DataSource = phoneRepository.GetAll();
        }

        private void buttonSortPhones_Click(object sender, EventArgs e)
        {
            if (!rbSortByBrand.Checked &&
                !rbSortByModel.Checked &&
                !rbSortByPrice.Checked)
            {
                MessageBox.Show("Select sort method", "Warning");
            }

            if (rbSortByBrand.Checked)
            {
                phoneRepository.Sort(new BrandComparer<Phone>());
            }

            if (rbSortByModel.Checked)
            {
                phoneRepository.Sort(new ModelComparer<Phone>());
            }

            if (rbSortByPrice.Checked)
            {
                phoneRepository.Sort(new PriceComparer<Phone>());
            }

            dataGridPhones.DataSource = null;
            dataGridPhones.DataSource = phoneRepository.GetAll();
        }
    }
}
