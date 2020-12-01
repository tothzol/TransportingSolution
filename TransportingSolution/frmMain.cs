using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ILOG.Concert;
using ILOG.CPLEX;

namespace TransportingSolution
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void nudSourceNum_ValueChanged(object sender, EventArgs e)
        {
            dgvTransport.RowCount = (int)nudSourceNum.Value + 1;
            foreach (DataGridViewRow r in dgvTransport.Rows) {
                r.HeaderCell.Value = "";
                
            }
           
            
            if (dgvTransport.RowCount > 2) {
                DataGridViewRow row = dgvTransport.Rows[dgvTransport.RowCount - 1];
                row.HeaderCell.Value = "Nyelők (Drains)";
                
            }
        }

        private void nudDrainNum_ValueChanged(object sender, EventArgs e)
        {
            dgvTransport.ColumnCount = (int)nudDrainNum.Value + 1;
            foreach (DataGridViewColumn c in dgvTransport.Columns) {
                c.HeaderCell.Value = "";
            }

            if (dgvTransport.RowCount > 2)
            {
                DataGridViewColumn column = dgvTransport.Columns[dgvTransport.ColumnCount - 1];
                column.HeaderCell.Value = "Források (Sources)";
                column.Width = 150;

            }
        }



        private void Calculate()
        {

            try
            {
                btnCalc.Enabled = false;
                int ret;

                for (int i = 0; i > dgvTransport.ColumnCount; i++) {

                    for (int j = 0; j > dgvTransport.RowCount; j++)
                    {
                        if ((int.TryParse(dgvTransport[i, j].Value.ToString(), out ret) == false || dgvTransport[i, j].Value.ToString() != "T") && i!=dgvTransport.ColumnCount-1 && j!=dgvTransport.RowCount-1 ){
                            throw new ILOG.Concert.Exception("A beviteli mezők értékének vagy egész számnak, vagy T-nek kell lennie!");
                        }
                    
                    }
                    }


                
                Cplex cplex = new Cplex();
                int Supply = (int)nudSourceNum.Value;
                int Drain = (int)nudDrainNum.Value;
                
                int[] temp;

                int SumSources = 0;
                int SumDrains = 0;
                int sumValue;

                sumValue = 0;
                for (int i = 0; i < dgvTransport.RowCount - 1; i++)
                {
                    int.TryParse(dgvTransport[dgvTransport.ColumnCount - 1, i].Value.ToString(), out sumValue);
                    SumSources += sumValue;
                }

                sumValue = 0;
                for (int i = 0; i < dgvTransport.ColumnCount - 1; i++)
                {
                    int.TryParse(dgvTransport[i, dgvTransport.RowCount - 1].Value.ToString(), out sumValue);
                    SumDrains += sumValue;
                }

                if (SumSources != SumDrains)
                {
                    //Nyílt szállítási feladat

                    if (SumSources < SumDrains)
                    {

                        DataGridViewRow r = new DataGridViewRow();
                        r.HeaderCell.Value = "FIKTÍV";
                        for (int i = 0; i < dgvTransport.ColumnCount - 1; i++)
                        {
                            DataGridViewCell c = new DataGridViewTextBoxCell();
                            c.Value = 0;
                            r.Cells.Add(c);
                        }
                        DataGridViewTextBoxCell cSupply = new DataGridViewTextBoxCell();
                        cSupply.Value = SumDrains - SumSources;
                        r.Cells.Add(cSupply);
                        dgvTransport.Rows.Insert(dgvTransport.RowCount - 1, r);
                        Supply++;
                    }
                    //egyenlő itt nem lehet, mert csak akkor lép be, ha nem egyenlő a két érték
                    else
                    {
                        DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                        col.HeaderText = "FIKTÍV";
                        dgvTransport.Columns.Insert(dgvTransport.ColumnCount - 1, col);
                        for (int i = 0; i < dgvTransport.RowCount - 1; i++)
                        {
                            dgvTransport[dgvTransport.ColumnCount - 2, i].Value = 0;
                        }
                        dgvTransport[dgvTransport.ColumnCount - 2, dgvTransport.RowCount - 1].Value = SumSources - SumDrains;
                        Drain++;
                    }

                }

                int[][] Cmatrix = new int[Supply][];
                int[] sources = new int[Supply];
                int[] drains = new int[Drain];

                INumVar[][] x = new INumVar[Supply][];
                INumVar[][] y = new INumVar[Supply][];

                for (int i = 0; i < Supply; i++)
                {
                    x[i] = cplex.NumVarArray(Drain, 0.0, int.MaxValue);
                    y[i] = cplex.NumVarArray(Drain, 0.0, int.MaxValue);
                }

                //források

                for (int i = 0; i < dgvTransport.RowCount - 1; i++)
                {
                    int.TryParse(dgvTransport[dgvTransport.ColumnCount - 1, i].Value.ToString(), out sources[i]);
                }
                //nyelők 
                for (int i = 0; i < dgvTransport.ColumnCount - 1; i++)
                {
                    int.TryParse(dgvTransport[i, dgvTransport.RowCount - 1].Value.ToString(), out drains[i]);
                }

                //Coef Matrix
                for (int i = 0; i < dgvTransport.RowCount - 1; i++)
                {
                    temp = new int[Drain];
                    for (int j = 0; j < dgvTransport.ColumnCount - 1; j++)
                    {

                        if (dgvTransport[j, i].Value.ToString() != "T")
                        {
                            int.TryParse(dgvTransport[j, i].Value.ToString(), out temp[j]);
                        }
                        else temp[j] = int.MaxValue;
                    }
                    Cmatrix[i] = temp;
                }

                for (int i = 0; i < Supply; i++)       // supply must meet demand
                    cplex.AddEq(cplex.Sum(x[i]), sources[i]);

                for (int j = 0; j < Drain; j++)
                {     // demand must meet supply
                    ILinearNumExpr v = cplex.LinearNumExpr();
                    for (int i = 0; i < Supply; i++)
                        v.AddTerm(1.0, x[i][j]);
                    cplex.AddEq(v, drains[j]);
                }

                ILinearNumExpr expr = cplex.LinearNumExpr();
                for (int i = 0; i < Supply; ++i)
                {
                    for (int j = 0; j < Drain; ++j)
                    {
                        expr.AddTerm(x[i][j], Cmatrix[i][j]);
                    }
                }

                cplex.AddMinimize(expr);

                cplex.Solve();
                MessageBox.Show("A megoldás: "+cplex.GetStatus().ToString());
                lblSolutionType.Text = "A megoldás: " + cplex.GetStatus().ToString();
                System.Console.WriteLine("Solution status = " + cplex.GetStatus());
                System.Console.WriteLine(" - Solution: ");

                dgvSolution.RowCount = Supply;
                dgvSolution.ColumnCount = Drain;

                for (int i = 0; i < Supply; ++i)
                {
                    System.Console.Write("   " + i + ": ");
                    for (int j = 0; j < Drain; ++j) { 
                        System.Console.Write("" + cplex.GetValue(x[i][j]) + "\t");
                   dgvSolution[j, i].Value = cplex.GetValue(x[i][j]);
                    }
                    System.Console.WriteLine();
                }
                System.Console.WriteLine("   Cost = " + cplex.ObjValue);
                lblZValue.Text = "A célfüggvény értéke: " + cplex.ObjValue;
                cplex.End();
                
            }
            catch (ILOG.Concert.Exception icex) { MessageBox.Show(icex.Message); }
            }


        private void Clear() {
            btnCalc.Enabled = true;
            dgvSolution.ColumnCount = 0;
            dgvSolution.RowCount = 0;
            dgvTransport.ColumnCount = 0;
                dgvTransport.RowCount = 0;
                nudDrainNum.Value = 1;
                nudSourceNum.Value = 1;
            
         
        }









        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
            Clear();
        }
    }
}
