using System;
using System.Collections.Generic;
using System.ComponentModel;
using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class PartiesForm : Form
    {
        private DBManager<Party, int> dBManager;
        private Party selectedParty;
        private IEnumerable<Party> parties;
        int selectedRowIndex = -1;

        public PartiesForm()
        {
            InitializeComponent();

            dBManager = new DBManager<Party, int>(DBContextManager.CreatePartyContext(DBContextManager.CreateContext()));

            LoadHeaderRow();
            LoadProducts();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    string name = nameTxtBox.Text;
                    string ideology = ideologyTxtBox.Text;
                    DateTime dateOfCreation = dateTimePicker.Value;
                    Party party = new Party(name,ideology,dateOfCreation);

                    dBManager.Create(party);

                    MessageBox.Show("Party created successfully!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddPartyRow(party);

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must fill all the textboxes", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    selectedParty.Name = nameTxtBox.Text;
                    selectedParty.Ideology = ideologyTxtBox.Text;
                    selectedParty.DateOfCreation =dateTimePicker.Value;

                    dBManager.Update(selectedParty);

                    MessageBox.Show("Party updated successfully!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdatePartyRow();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must fill all the textboxes!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (selectedParty != null)
                {
                    dBManager.Delete(selectedParty.Id);

                    MessageBox.Show("Party deleted successfully!", ":]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DeletePartyRow();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select party!", ">:@", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void partiesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int id = Convert.ToInt32(partiesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                string name = partiesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string ideology= partiesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateTime dateOfCreation = Convert.ToDateTime(partiesDataGridView.Rows[e.RowIndex].Cells[3].Value);

                selectedParty = new Party(id, name, ideology, dateOfCreation);

                nameTxtBox.Text = name;
                ideologyTxtBox.Text = ideology;
                dateTimePicker.Value = dateOfCreation;
                selectedRowIndex = e.RowIndex;
            }
        }

        #region Helper Methods

        private void LoadHeaderRow()
        {
            partiesDataGridView.Columns.Add("id", "ID");
            partiesDataGridView.Columns.Add("name", "Name");
            partiesDataGridView.Columns.Add("ideology", "Ideology");
            partiesDataGridView.Columns.Add("dateOfCreation", "Date Of Creation");
        }

        private void LoadProducts()
        {
            parties = dBManager.ReadAll();

            foreach (Party item in parties)
            {
                DataGridViewRow row = (DataGridViewRow)partiesDataGridView.Rows[0].Clone();

                row.Cells[0].Value = item.Id;
                row.Cells[1].Value = item.Name;
                row.Cells[2].Value = item.Ideology;
                row.Cells[3].Value = item.DateOfCreation.ToString("MM/dd/yyyy");

                partiesDataGridView.Rows.Add(row);
            }
        }

        private void AddPartyRow(Party item)
        {
            DataGridViewRow row = (DataGridViewRow)partiesDataGridView.Rows[0].Clone();

            row.Cells[0].Value = item.Id;
            row.Cells[1].Value = item.Name;
            row.Cells[2].Value = item.Ideology;
            row.Cells[3].Value = item.DateOfCreation.ToString("MM/dd/yyyy");

            partiesDataGridView.Rows.Add(row);
        }

        private void UpdatePartyRow()
        {
            partiesDataGridView.Rows[selectedRowIndex].Cells[0].Value = selectedParty.Id;
            partiesDataGridView.Rows[selectedRowIndex].Cells[1].Value = selectedParty.Name;
            partiesDataGridView.Rows[selectedRowIndex].Cells[2].Value = selectedParty.Ideology;
            partiesDataGridView.Rows[selectedRowIndex].Cells[3].Value = selectedParty.DateOfCreation.ToString("MM/dd/yyyy");
        }

        private void DeletePartyRow()
        {
            partiesDataGridView.Rows.RemoveAt(selectedRowIndex);
        }

        private bool ValidateData()
        {
            if (nameTxtBox.Text != string.Empty && ideologyTxtBox.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            nameTxtBox.Text = string.Empty;
            ideologyTxtBox.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
            selectedParty = null;
            selectedRowIndex = -1;
        }

        #endregion

    }
}
