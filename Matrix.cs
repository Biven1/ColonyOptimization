using System;
using System.Windows.Forms;

namespace ColonyOptimization
{
    public partial class app : Form
    {
        private void ReloadDistMatrix()
        {
            this.DistMatrix.Rows.Clear();  // удаление всех строк

            int NumColumns = this.DistMatrix.Columns.Count;
            for (int i = 0; i < NumColumns; i++)     // удаление всех столбцов
                this.DistMatrix.Columns.RemoveAt(0);

            for (int i = 0; i < colony.n; i++)
                DistMatrix.Columns.Add(i.ToString(), i.ToString());

            for (int i = 0; i < colony.n; i++)
            {
                string[] t = new string[colony.n];
                for (int j = 0; j < colony.n; j++)
                    t[j] = Math.Round(colony.dist[i, j], 1).ToString();

                DistMatrix.Rows.Add(t);
            }

            for (int i = 0; i < colony.n; i++)
                DistMatrix.Columns[i].Width = 40;

            for (int i = 0; i < colony.n; i++)
                this.DistMatrix.Rows[i].HeaderCell.Value = i.ToString();

            PanelDistMatrix.Height = Math.Min(305, DistMatrix.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
                                                   DistMatrix.ColumnHeadersHeight + 3);
            PanelMatrix.Width = Math.Min(562, 3000);
        }
        private void ReloadPhMatrix()
        {
            this.PhMatrix.Rows.Clear();  // удаление всех строк

            int NumColumns = this.PhMatrix.Columns.Count;
            for (int i = 0; i < NumColumns; i++)     // удаление всех столбцов
                this.PhMatrix.Columns.RemoveAt(0);

            for (int i = 0; i < colony.n; i++)
                PhMatrix.Columns.Add(i.ToString(), i.ToString());

            for (int i = 0; i < colony.n; i++)
            {
                string[] t = new string[colony.n];
                for (int j = 0; j < colony.n; j++)
                    t[j] = Math.Round(colony.pheromone[i, j], 3).ToString();

                PhMatrix.Rows.Add(t);
            }

            for (int i = 0; i < colony.n; i++)
                PhMatrix.Columns[i].Width = 40;

            for (int i = 0; i < colony.n; i++)
                this.PhMatrix.Rows[i].HeaderCell.Value = i.ToString();

            PanelPhMatrix.Height = Math.Min(305, PhMatrix.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
                                                 PhMatrix.ColumnHeadersHeight + 3);
        }

        #region Event handlers

        private void DistMatrixBtn_Click(object sender, EventArgs e)
        {
            PanelDistMatrix.Visible = !PanelDistMatrix.Visible;
        }

        private void PhMatrixBtn_Click(object sender, EventArgs e)
        {
            PanelPhMatrix.Visible = !PanelPhMatrix.Visible;
        }

        #endregion
    }
}