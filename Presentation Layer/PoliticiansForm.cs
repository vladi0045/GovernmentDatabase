using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class PoliticiansForm : Form
    {
        private DBManager<Politician, int> dBManager;
        private DBManager<Position, int> positiondBManager;
        private DBManager<Party, int> partydBManager;
        private Politician selectedPolitician;
        private IEnumerable<Politician> politicians;
        int selectedRowIndex = -1;

        public PoliticiansForm()
        {
            InitializeComponent();

            dBManager = new DBManager<Politician, int>(DBContextManager.CreatePoliticianContext(DBContextManager.CreateContext()));
            positiondBManager = new DBManager<Position, int>(DBContextManager.CreatePositionContext(DBContextManager.GetContext()));
            partydBManager = new DBManager<Party, int>(DBContextManager.CreatePartyContext(DBContextManager.GetContext()));

            LoadHeaderRow();
            LoadProducts();
            LoadPositions();
            LoadParties();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                string firstName = firstNameTxtBox.Text;
                string middleName = middleNameTxtBox.Text;
                string lastName = lastNameTxtBox.Text;
                int age = Convert.ToInt32(ageNumericUpDown.Value);
                DateTime dateOfAppointment = Convert.ToDateTime(dateTimePicker.Value);




                Party party = partydBManager.Read((int)partyComboBox.SelectedValue);
                Position position = positiondBManager.Read((int)positionComboBox.SelectedValue);
                Politician politician = new Politician(firstName, middleName, lastName, age, position, party, dateOfAppointment);
                dBManager.Create(politician);

                MessageBox.Show("Politician created successfully!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddPoliticianRow(politician);

                ClearData();
            }
            else
            {
                MessageBox.Show("You must fill the textbox", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {

                    selectedPolitician.FirstName = firstNameTxtBox.Text;
                    selectedPolitician.MiddleName = middleNameTxtBox.Text;
                    selectedPolitician.LastName = lastNameTxtBox.Text;
                    selectedPolitician.Age = Convert.ToInt32(ageNumericUpDown.Value);
                    selectedPolitician.DateOfAppointment = dateTimePicker.Value;
                    selectedPolitician.Party = partydBManager.Read((int)partyComboBox.SelectedValue);
                    selectedPolitician.Position = positiondBManager.Read((int)positionComboBox.SelectedValue);

                    dBManager.Update(selectedPolitician);

                    MessageBox.Show("Politician updated successfully!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdatePoliticianRow();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must fill the textbox!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPolitician != null)
                {
                    dBManager.Delete(selectedPolitician.Id);

                    MessageBox.Show("Politician deleted successfully!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DeletePoliticianRow();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select politician!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ":|", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void politiciansDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int id = Convert.ToInt32(politiciansDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                string firstName = politiciansDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string middleName = politiciansDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string lastName = politiciansDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                int age = Convert.ToInt32(politiciansDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                DateTime dateOfAppointment = Convert.ToDateTime(politiciansDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
                Party party = partydBManager.Read(dBManager.Read(id).PartyId);
                Position position = positiondBManager.Read(dBManager.Read(id).PositionId);

                selectedPolitician = new Politician(id, firstName, middleName, lastName, age, position, party, dateOfAppointment);

                firstNameTxtBox.Text = selectedPolitician.FirstName;
                middleNameTxtBox.Text = selectedPolitician.MiddleName;
                lastNameTxtBox.Text = selectedPolitician.LastName;
                ageNumericUpDown.Value = selectedPolitician.Age;
                dateTimePicker.Value = selectedPolitician.DateOfAppointment;
                partyComboBox.Text = party.Name;
                positionComboBox.Text = position.PositionName;
                selectedRowIndex = e.RowIndex;
            }
        }

        #region Helper Methods

        private void LoadHeaderRow()
        {
            politiciansDataGridView.Columns.Add("id", "Id");
            politiciansDataGridView.Columns.Add("firstName", "First Name");
            politiciansDataGridView.Columns.Add("middleName", "Middle Name");
            politiciansDataGridView.Columns.Add("lastName", "Last Name");
            politiciansDataGridView.Columns.Add("age", "Age");
            politiciansDataGridView.Columns.Add("position", "Position");
            politiciansDataGridView.Columns.Add("party", "Party");
            politiciansDataGridView.Columns.Add("dateOfAppointment", "Date Of Appoinment");

        }

        private void LoadProducts()
        {
            politicians = dBManager.ReadAll();

            foreach (Politician item in politicians)
            {
                DataGridViewRow row = (DataGridViewRow)politiciansDataGridView.Rows[0].Clone();


                row.Cells[0].Value = item.Id;
                row.Cells[1].Value = item.FirstName;
                row.Cells[2].Value = item.MiddleName;
                row.Cells[3].Value = item.LastName;
                row.Cells[4].Value = item.Age;
                row.Cells[5].Value = positiondBManager.Read(item.PositionId).PositionName;
                row.Cells[6].Value = partydBManager.Read(item.PartyId).Name;
                row.Cells[7].Value = item.DateOfAppointment.ToString("MM/dd/yyyy");

                politiciansDataGridView.Rows.Add(row);
            }
        }

        private void LoadPositions()
        {
            positionComboBox.DataSource = positiondBManager.ReadAll();

            positionComboBox.DisplayMember = "PositionName";
            positionComboBox.ValueMember = "Id";
        }

        private void LoadParties()
        {
            partyComboBox.DataSource = partydBManager.ReadAll();

            partyComboBox.DisplayMember = "Name";
            partyComboBox.ValueMember = "Id";
        }
        private void AddPoliticianRow(Politician item)
        {
            DataGridViewRow row = (DataGridViewRow)politiciansDataGridView.Rows[0].Clone();

            row.Cells[0].Value = item.Id;
            row.Cells[1].Value = item.FirstName;
            row.Cells[2].Value = item.MiddleName;
            row.Cells[3].Value = item.LastName;
            row.Cells[4].Value = item.Age;
            row.Cells[5].Value = item.Position.PositionName;
            row.Cells[6].Value = item.Party.Name;
            row.Cells[7].Value = item.DateOfAppointment.ToString("MM/dd/yyyy");


            politiciansDataGridView.Rows.Add(row);
         
        }

        private void UpdatePoliticianRow()
        {
            politiciansDataGridView.Rows[selectedRowIndex].Cells[0].Value = selectedPolitician.Id;
            politiciansDataGridView.Rows[selectedRowIndex].Cells[1].Value = selectedPolitician.FirstName;
            politiciansDataGridView.Rows[selectedRowIndex].Cells[2].Value = selectedPolitician.MiddleName;
            politiciansDataGridView.Rows[selectedRowIndex].Cells[3].Value = selectedPolitician.LastName;
            politiciansDataGridView.Rows[selectedRowIndex].Cells[4].Value = selectedPolitician.Age;
            politiciansDataGridView.Rows[selectedRowIndex].Cells[5].Value = selectedPolitician.Position.PositionName;
            politiciansDataGridView.Rows[selectedRowIndex].Cells[6].Value = selectedPolitician.Party.Name;
            politiciansDataGridView.Rows[selectedRowIndex].Cells[7].Value = selectedPolitician.DateOfAppointment.ToString("MM/dd/yyyy");

        }

        private void DeletePoliticianRow()
        {
            politiciansDataGridView.Rows.RemoveAt(selectedRowIndex);
        }

        private bool ValidateData()
        {
            if (firstNameTxtBox.Text != string.Empty && middleNameTxtBox.Text != string.Empty && lastNameTxtBox.Text != string.Empty && partyComboBox.DisplayMember != string.Empty && positionComboBox.DisplayMember != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            firstNameTxtBox.Text = string.Empty;
            middleNameTxtBox.Text = string.Empty;
            lastNameTxtBox.Text = string.Empty;
            ageNumericUpDown.Value = ageNumericUpDown.Minimum;
            partyComboBox.Text = string.Empty;
            positionComboBox.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
            selectedPolitician = null;
            selectedRowIndex = -1;
        }


        #endregion



    }
}





