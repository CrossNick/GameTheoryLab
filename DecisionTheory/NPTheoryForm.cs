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
    public partial class NPTheoryForm : Form
    {
        public int nOfSteps;
        public int currentStep;
        public NPStep[] steps;

        public NPTheoryForm()
        {
            InitializeComponent();
        }

        private void NPTheoryForm_Load(object sender, EventArgs e)
        {
            currentStep = 0;
            nOfSteps = 16;
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
                TextToDisplay = "В этой программе вы узнаете о Критерии Неймана-Пирсона принятия решений. Для начала ознакомимся с интерфейсом программы. В этом текстовом поле вы будете видеть теоретический текстовый материал, который пошагово будет рассказывать о том, как работает критерий. Ниже находится поле для рисунков и графиков, а слева таблицы для вывода значений матриц. Что бы перейти на следующий шаг или вернуться на предыдущий, нажмите на кнопки \"Дальше\" или \"Назад\". По завершению изучения теории, вам будет предложено решить задачу на Критерий Неймана-Пирсона самостоятельно. Если вы готовы, нажмите на кнопку \"Дальше\", что бы начать ознакомление",
                ImageFileName = Application.StartupPath+@"\Images\NPStep0.bmp"
            };
            //Step 1
            steps[1] = new NPStep()
            {
                Number = 1,
                TextToDisplay = "Для начала немного об условиях. Применяется критерий Неймана-Пирсона в том случае когда природа может находиться в одном из двух состояний, причем одно из которых контролируемо, а другое нет. Для контроллируемого состояния природы вводиться порговое значение состояния, его обозначение можете увидеть ниже.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep1.bmp"
            };
            //Step 2
            steps[2] = new NPStep()
            {
                Number = 2,
                TextToDisplay = "Изучение критерия Неймана-Пирсона будем проводить параллельно на конкретном примере, в котором из двух состояний, контроллируемым будет первое. Зададим матрицу эффективности, а так же пороговое значение контроллируемого состояние природы. Запишем их в соответсвующие текстовое поле и таблицу слева.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep2.bmp",
                QMatrix = new string[,] { { "1","0"}, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f
            };
            //Step 3
            steps[3] = new NPStep()
            {
                Number = 3,
                TextToDisplay = "Поговорим о назначении порогового значения. Все решения, которые для контроллируемого состояня природы приводят к потерям большим чем пороговое значение, не рассматриваем. А в качестве оптималного решения выбираем то, которое при неконтроллируемом состоянии приводит к минимальным потерям.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep3.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f
            };
            //Step 4
            steps[4] = new NPStep()
            {
                Number = 4,
                TextToDisplay = "Для приминения критерия Неймана-Пирсона, преобразуем матрицу эффективности в матрицу потерь. Снизу представленная формула для преобразования, а так же его результат. Запишем матрицу потерь в соответствующую таблицу.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep4.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix=new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "0.4", "0.6" } }
            };
            //Step 5
            steps[5] = new NPStep()
            {
                Number = 5,
                TextToDisplay = "Проверим, все ли состояния природы удовлетворяют пороговому значеню. Как можно заметить, в третьем решении, колличество потерь больше чем пороговое состояние, поэтому исключаем его из рассмотрения.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep5.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix = new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "-", "-" } }
            };
            //Step 6
            steps[6] = new NPStep()
            {
                Number = 6,
                TextToDisplay = "Из оставшихся решений выбираем то, у которого минимальные потери по неконтроллируемому состоянию, то есть по второму. Из матрицы потерь видно чо это второе решение с потерями 0.9, оно и будет оптимальным по критерию Неймана-Пирсона.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep6.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix = new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "-", "-" } }
            };
            //Step 7
            steps[7] = new NPStep()
            {
                Number = 7,
                TextToDisplay = "Рассмотрим геометрическую интерпретацию критерия Неймана-Пирсона в общем случае, а затем для нашего примера. Начертим на координатной плоскости точки соответствующие решениям, где ось абсцис это контроллируемое состояние природы, а ось ординат неконтроллиремое.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep7.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix = new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "-", "-" } }
            };
            //Step 8
            steps[8] = new NPStep()
            {
                Number = 8,
                TextToDisplay = "Построим выпуклую оболочку этих точек. Получим наше платежное множество. Так же проведем вертикальную линию, которая будем обозначать пороговое значение для контролируемого состояния природы.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep8.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix = new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "-", "-" } }
            };
            //Step 9
            steps[9] = new NPStep()
            {
                Number = 9,
                TextToDisplay = "А теперь рассмотрим четыре возможных случая. Если все платежное множество оказалось правее этой прямой, то задача не имеет решения по критерию Неймана-Пирсона.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep9.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix = new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "-", "-" } }
            };
            //Step 10
            steps[10] = new NPStep()
            {
                Number = 10,
                TextToDisplay = "Если наоборот, все платежное множество лежит левее от порогового значения, то за оптимальное решение принимаем точку с минимальной ординатой.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep10.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix = new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "-", "-" } }
            };
            //Step 11
            steps[11] = new NPStep()
            {
                Number = 11,
                TextToDisplay = "Если прямая проходит через платежное множество, то все точки и часть множество, что лежат правее, исключаем из рассмотрения. В качестве оптимального решения выбираем точку с минимальной ординатой из оставшихся решений.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep11.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix = new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "-", "-" } }
            };
            //Step 12
            steps[12] = new NPStep()
            {
                Number = 12,
                TextToDisplay = "Может быть случай когда точки с минимальной ординатой лежат на отрезке. Тгда можем применить два подхода. Либо записать ее как выпукдую линейную комбинацию концов отрезка",
                ImageFileName = Application.StartupPath + @"\Images\NPStep12.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix = new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "-", "-" } }
            };
            //Step 13
            steps[13] = new NPStep()
            {
                Number = 13,
                TextToDisplay = "Либо как точку с известной абсциссой и неизвестной ординатой. Тогда получим уравнение, из которого найдем оптимальное решение.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep13.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix = new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "-", "-" } }
            };
            //Step 14
            steps[14] = new NPStep()
            {
                Number = 14,
                TextToDisplay = "Теперь рассмотрим геомтерическую интерпретацию на нашем примере. Построив выпуклую линейную оболочку и пороговое значение, используя описанные шаги, устанавливаем что второе решение являеться оптимальным.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep13.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix = new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "-", "-" } }
            };
            //Step 15
            steps[15] = new NPStep()
            {
                Number = 15,
                TextToDisplay = "На этом заканчиваетс ознакомление с критерием Неймана-Пирсона и, если вы чувствуете что усвоили материал достаточно то нажмите на кнопку \"Далее\" что бы самостоятельно решить практический пример.",
                ImageFileName = Application.StartupPath + @"\Images\NPStep15.bmp",
                QMatrix = new string[,] { { "1", "0" }, { "0.9", "0.1" }, { "0.6", "0.4" } },
                B1 = 0.5f,
                LMatrix = new string[,] { { "0", "1" }, { "0.1", "0.9" }, { "-", "-" } }
            };
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentStep != nOfSteps-1)
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

        private void FillDataTable(DataGridView dt, string[,] data)
        {
            dt.Rows.Clear();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                dt.Rows.Add();
                dt.Rows[i].HeaderCell.Value = "a" + i;
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    dt.Rows[i].Cells[j].Value = data[i, j];
                }
            }
        }
    }
}
