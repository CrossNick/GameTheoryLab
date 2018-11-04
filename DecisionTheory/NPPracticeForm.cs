using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionTheory
{
    public partial class NPPracticeForm : Form
    {
        public int nOfSteps;
        public int currentStep;
        public NPStep[] steps;

        public NPPracticeForm()
        {
            InitializeComponent();
        }

        private void NPTheoryForm_Load(object sender, EventArgs e)
        {
            currentStep = 0;
            nOfSteps = 10;
            InitializeNPTheorySteps();
            ApplyStep();
        }

        private void InitializeNPTheorySteps()
        {
            steps = new NPStep[nOfSteps];
            //Step 0
            steps[0] = new NPStep()
            {
                Number = 0,
                TextToDisplay = "Критерий Неймана-Пирсона применяется в том случае, когда природа находится в одном из двух состояний, одно из которых контролируемо, а другое нет.",
                ImageFileName = Application.StartupPath+@"\Images\NPStep0.bmp"
            };
            //Step 1
            steps[1] = new NPStep()
            {
                Number = 1,
                TextToDisplay = "STEP 2",
                ImageFileName = Application.StartupPath + @"\Images\NPStep1.jpg"
            };

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentStep != nOfSteps)
            {
                DisableStepElements();
                currentStep++;
                ApplyStep();
            }
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if (currentStep != 0)
            {
                DisableStepElements();
                currentStep--;
                ApplyStep();
            }
            
        }

        private void ApplyStep()
        {
            MainTxt.Text = steps[currentStep].TextToDisplay;
            pct1.Image = Image.FromFile(steps[currentStep].ImageFileName);
            FillDataTable(dataGridL, steps[currentStep].LMatrix);
            FillDataTable(dataGridQ, steps[currentStep].QMatrix);
            EnableStepElements();
            PerformStepActions();
            txtB1.Text = steps[currentStep].B1.ToString();
        }

        private void DisableStepElements()
        {
            foreach(var element in steps[currentStep].ElementsToDisplay)
            {
                element.Visible = false;
            }
        }

        private void EnableStepElements()
        {
            foreach (var element in steps[currentStep].ElementsToDisplay)
            {
                element.Visible = true;
            }
        }

        private void PerformStepActions()
        {
            foreach (var element in steps[currentStep].ActionsToDo)
            {
                element();
            }
        }

        private void FillDataTable(DataGridView dt, float[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                dt.Rows.Add();
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    dt.Rows[i].Cells[j].Value = data[i, j];
                }
            }
        }

  

    }
}
