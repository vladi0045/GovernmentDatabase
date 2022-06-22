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
    public partial class PositionsForm : Form
    {
        private DBManager<Position, int> dBManager;
        private Position selectedPosition;
        private IEnumerable<Position> positions;
        int selectedRowIndex = -1;

        public PositionsForm()
        {
            InitializeComponent();

            dBManager = new DBManager<Position, int>(DBContextManager.CreatePositionContext(DBContextManager.CreateContext()));

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

                    Position position = new Position(name);

                    dBManager.Create(position);

                    MessageBox.Show("Position created successfully!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddPositionRow(position);

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
                    selectedPosition.PositionName = nameTxtBox.Text;

                    dBManager.Update(selectedPosition);

                    MessageBox.Show("Position updated successfully!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdatePositionRow();

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
                if (selectedPosition != null)
                {
                    dBManager.Delete(selectedPosition.Id);

                    MessageBox.Show("Position deleted successfully!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DeletePositionRow();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select position!", "0_0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "0_0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void positionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int id= Convert.ToInt32(positionsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                string name = positionsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

                selectedPosition = new Position(id,name);

                nameTxtBox.Text = name;
               
                selectedRowIndex = e.RowIndex;
            }
        }

        #region Helper Methods

        private void LoadHeaderRow()
        {
            positionsDataGridView.Columns.Add("id", "Id");
            positionsDataGridView.Columns.Add("name", "Name");
        }

        private void LoadProducts()
        {
            positions = dBManager.ReadAll();

            foreach (Position item in positions)
            {
                DataGridViewRow row = (DataGridViewRow)positionsDataGridView.Rows[0].Clone();
 

                row.Cells[0].Value = item.Id;
                row.Cells[1].Value = item.PositionName;

                positionsDataGridView.Rows.Add(row);
            }
        }

        private void AddPositionRow(Position item)
        {
            DataGridViewRow row = (DataGridViewRow)positionsDataGridView.Rows[0].Clone();

            row.Cells[0].Value = item.Id;
            row.Cells[1].Value = item.PositionName;

            positionsDataGridView.Rows.Add(row);
        }

        private void UpdatePositionRow()
        {
            positionsDataGridView.Rows[selectedRowIndex].Cells[0].Value = selectedPosition.Id;
            positionsDataGridView.Rows[selectedRowIndex].Cells[1].Value = selectedPosition.PositionName;
        }

        private void DeletePositionRow()
        {
            positionsDataGridView.Rows.RemoveAt(selectedRowIndex);
        }

        private bool ValidateData()
        {
            if (nameTxtBox.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            nameTxtBox.Text = string.Empty;
            selectedPosition = null;
            selectedRowIndex = -1;
        }

        #endregion

    }
}
