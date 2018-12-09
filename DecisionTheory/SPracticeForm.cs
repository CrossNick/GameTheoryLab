using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DecisionTheory
{
    public partial class SPracticeForm : Form
    {

        private bool IsLMatrixLoaded = false;
        private bool IsQMatrixLoaded = false;
        private int DecisionCount;
        private int GCount;
        private double[,] QMatrix;
        private List<Point> QPoints;
        private double[,] LMatrix;
        private List<Point> LPoints;
        private double[,] ZMatrix;
        private List<Point> ZPoints;
        private double[,] GMatrix;
        private List<Point> GPoints;
        private double[,] convexHull;
        private List<Point> convexPoints;

        public SPracticeForm()
        {
            InitializeComponent();
        }

        private void SPracticeForm_Load(object sender, EventArgs e)
        {

        }
        private void EnableEditing(DataGridView dt)
        {
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dt.Rows[i].Cells.Count; j++)
                {
                    dt.Rows[i].Cells[j].ReadOnly = false;
                    dt.Rows[i].Cells[j].Value = "0";
                }
            }
        }

        private List<Point> PointFromArray(double[,] points)
        {
            if (points.GetLength(1) != 2)
                throw new Exception();
            var result = new List<Point>();
            for (int i = 0; i < points.GetLength(0); i++)
            {
                result.Add(new Point(points[i, 0], points[i, 1]));
            }
            return result;
        }

        private double[,] PointToArray(List<Point> points)
        {
            var result = new double[points.Count, 2];
            int i = 0;
            foreach (var point in points)
            {
                result[i, 0] = point.x;
                result[i, 1] = point.y;
                i++;
            }
            return result;
        }

        private string GetFileContent()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            return fileContent;
        }

        private List<Point> StringToPoints(string s)
        {
            var rows = s.Split('\n');
            var result = new List<Point>();
            foreach (var item in rows)
            {
                var values = item.Split(' ', '\r');
                if (values.Length < 2 || values.Length > 3)
                    throw new Exception();
                result.Add(new Point(Convert.ToDouble(values[0]), Convert.ToDouble(values[1])));
            }
            return result;
        }

        private void SetGridValues(DataGridView dt, double[,] values)
        {
            dt.Rows.Clear();
            for (int i = 0; i < values.GetLength(0); i++)
            {
                dt.Rows.Add();
                dt.Rows[i].Cells[0].Value = values[i, 0].ToString();
                dt.Rows[i].Cells[1].Value = values[i, 1].ToString();
            }
        }

        private void btnLoadQ_Click(object sender, EventArgs e)
        {
            try
            {
                var str = GetFileContent();
                QPoints = StringToPoints(str);
                QMatrix = PointToArray(QPoints);
                SetGridValues(dataGridQ, QMatrix);
                IsQMatrixLoaded = true;
            }
            catch
            {
                MessageBox.Show("Вы выбрали неверный файл!");
            }
        }

        private double[,] GetGridValues(DataGridView dt)
        {
            var result = new double[dt.RowCount - 1, dt.ColumnCount];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = Convert.ToDouble(dt.Rows[i].Cells[j].Value);
                }

            }
            return result;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            QMatrix = GetGridValues(dataGridQ);
            QPoints = PointFromArray(QMatrix);
            LMatrix = ConvertToLoses(QMatrix);
                LPoints = PointFromArray(LMatrix);
                SetGridValues(dataGridL, LMatrix);
                IsLMatrixLoaded = true;
        }

        public double[,] ConvertToLoses(double[,] q)
        {
            var result = new double[q.GetLength(0), q.GetLength(1)];
            var max = q[0, 0];
            for (int i = 0; i < q.GetLength(0); i++)
            {
                for (int j = 0; j < q.GetLength(1); j++)
                {
                    if (q[i, j] > max) max = q[i, j];
                }
            }
            for (int i = 0; i < q.GetLength(0); i++)
            {
                for (int j = 0; j < q.GetLength(1); j++)
                {
                    result[i, j] = max - q[i, j];
                }
            }
            return result;
        }

        private void btnLoadL_Click(object sender, EventArgs e)
        {
            try
            {
                var str = GetFileContent();
                LPoints = StringToPoints(str);
                LMatrix = PointToArray(LPoints);
                SetGridValues(dataGridL, LMatrix);
                IsLMatrixLoaded = true;
            }
            catch
            {
                MessageBox.Show("Вы выбрали неверный файл!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var str = GetFileContent();
                ZPoints = StringToPoints(str);
                ZMatrix = PointToArray(ZPoints);
                for (int i = 0; i < ZMatrix.GetLength(1); i++)
                {
                    double sum = 0;
                    for (int j = 0; j < ZMatrix.GetLength(0); j++)
                    {
                        sum += ZMatrix[j, i];
                    }
                    if (sum > 1 || sum <= 0.9)
                        throw new Exception();
                }
                SetGridValues(dataGridZ, ZMatrix);
            }
            catch
            {
                MessageBox.Show("Вы выбрали неверный файл!");
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                var val = Convert.ToInt32(txtDecisionNumber.Text);
                if (val < 1)
                    throw new Exception();
                DecisionCount = val;
                dataGridQ.Rows.Clear();
                dataGridL.Rows.Clear();
                dataGridZ.Rows.Clear();
                for (int i = 0; i < DecisionCount; i++)
                {
                    dataGridQ.Rows.Add();
                    dataGridL.Rows.Add();
                    dataGridZ.Rows.Add();
                }
                EnableEditing(dataGridQ);
                EnableEditing(dataGridL);
                EnableEditing(dataGridZ);
                IsLMatrixLoaded = true;
                IsQMatrixLoaded = true;
            }
            catch
            {
                MessageBox.Show("Вы ввели неправильное число!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsLMatrixLoaded)
            {
                ClauclateGMatrix();
                RenderGTable();
                var b = Convert.ToDouble(txtB1.Text);
                var result = FindSolution(convexPoints.Where(x => x.x <= b).ToList());
                DrawGraphics();
                if (result.Count == 0)
                {
                    txtFinal.Text = "Решений нет. Платежное множество лежит справа от порогового значения.";
                }
                else if (result.Count == 1)
                {
                    ProcessSingleSolution(result.First());
                }
                else
                {
                    ProcessMultipleSolution(result);
                }
            }
        }

        private void ClauclateGMatrix()
        {
            GCount = (int)Math.Pow(LPoints.Count, ZPoints.Count);
            GMatrix = new double[GCount, 2];
            for (int i = 0; i < GMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < GMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < ZPoints.Count; k++)
                    {
                        GMatrix[i, j] += ZMatrix[k, j] * LMatrix[CalculateG(i, k+1)-1, j];
                    }
                }
            }
            GPoints = PointFromArray(GMatrix);
            convexPoints = ConvexHull.MakeHull(GPoints).ToList();
            convexHull = PointToArray(convexPoints);
        }

        private int CalculateG(int I, int K)
        {
            int A = (int)Math.Pow(LPoints.Count, ZPoints.Count - K);
            if (A == 0)
                A++;
            int B = A * LPoints.Count;
            I = I - (I / B) * B;
            int result = I / A + 1;
            return result;
        }
        private void RenderGTable()
        {
            dataGridG.ColumnCount = GCount;
            dataGridG.RowCount = 2;
            for (int i = 0; i < GMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < GMatrix.GetLength(0); j++)
                {
                    dataGridG.Rows[i].Cells[j].Value = GMatrix[j, i];
                }
            }
        }

        private void ProcessSingleSolution(Point result)
        {
            var adjacent = FindAdjacentPoint(result);
            if (adjacent.HasValue)
            {
                var x = (Convert.ToDouble(txtB1.Text) - adjacent.Value.x) / (result.x - adjacent.Value.x);
                var L = x * result.y - (1 - x) * adjacent.Value.y;
                var resultString = "(";
                for (int i = 0; i < GMatrix.GetLength(0); i++)
                {
                    if (GMatrix[i, 0] == result.x && GMatrix[i, 1] == result.y)
                        resultString += x + " ;";
                    else if (GMatrix[i, 0] == adjacent.Value.x && GMatrix[i, 1] == adjacent.Value.y)
                        resultString += (1 - x) + " ;";
                    else
                        resultString += "0 ;";
                }
                resultString += ")";
                txtFinal.Text = "Оптимальное решение по критерию Неймана Пирсона по данной задаче X*=" + resultString + ".";
            }
            else
            {
                var resultString = "(";
                for (int i = 0; i < GMatrix.GetLength(0); i++)
                {
                    if (GMatrix[i, 1] == result.y)
                        resultString += "1 ;";
                    else
                        resultString += "0 ;";
                }
                resultString += ")";
                txtFinal.Text = "Оптимальное решение по критерию Неймана Пирсона по данной задаче X*=" + resultString + ".";
            }

        }

        private Point? FindAdjacentPoint(Point result)
        {
            int index = 0, adjacentIndex = 0;
            for (int i = 0; i < convexHull.GetLength(0); i++)
            {
                if (convexHull[i, 0] == result.x && convexHull[i, 1] == result.y)
                    index = i;
            }

            if (index == 0)
                adjacentIndex = convexHull.GetLength(0) - 1;
            else
                adjacentIndex = index - 1;

            if (convexHull[adjacentIndex, 1] < result.y)
                return new Point(convexHull[adjacentIndex, 0], convexHull[adjacentIndex, 1]);
            else
                return null;
        }

        private void ProcessMultipleSolution(List<Point> result)
        {
            var lst = new List<int>();
            for (int i = 0; i < GMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if (GMatrix[i, 1] == result[j].y)
                    {
                        lst.Add(i);
                        break;
                    }
                }
            }
            string res = "";
            foreach (var item in lst)
            {
                res += "A" + item + "; ";
            }
            txtFinal.Text = "Оптимальных решений по критерию Неймана Пирсона по данной задаче несколько. Это: " + res;
        }

        private List<Point> FindSolution(List<Point> allowedPoints)
        {
            var result = new List<Point>();
            if (allowedPoints.Count == 0)
                return result;
            var minY = allowedPoints[0].y;
            foreach (var item in allowedPoints)
            {
                if (item.y < minY) minY = item.y;
            }
            return convexPoints.Where(x => x.y == minY).ToList();
        }

        private void DrawGraphics()
        {
            MainChart.Series.Clear();
            MainChart.ChartAreas.Clear();
            double max = convexPoints[0].y;
            Series mySeries = new Series("Graphic");
            mySeries.ChartType = SeriesChartType.Line;
            ChartArea MyChartArea = new ChartArea("Math functions");
            MainChart.ChartAreas.Add(MyChartArea);
            mySeries.BorderWidth = 3;
            mySeries.ChartArea = "Math functions";
            foreach (var item in convexPoints)
            {
                mySeries.Points.Add(new DataPoint(item.x, item.y));
                if (max < item.y) max = item.y;
            }
            MyChartArea.Axes[0].Interval = max / 10;
            MyChartArea.Axes[1].Interval = max / 10;
            mySeries.Points.Add(new DataPoint(convexPoints[0].x, convexPoints[0].y));
            MainChart.Series.Add(mySeries);

            var b = Convert.ToDouble(txtB1.Text);
            Series newSeries = new Series("Barriee");
            newSeries.ChartType = SeriesChartType.Line;
            newSeries.BorderWidth = 2;
            newSeries.ChartArea = "Math functions";


            newSeries.Points.Add(new DataPoint(b, 0));
            newSeries.Points.Add(new DataPoint(b, max + max * 0.2));
            MainChart.Series.Add(newSeries);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
