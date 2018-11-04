using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionTheory
{
    public class Step
    {
        public Step()
        {
            ElementsToDisplay = new List<Control>();
            ActionsToDo = new List<Action>();
        }
        public int Number { get; set; }
        public List<Control> ElementsToDisplay {get;set;}
        public string TextToDisplay { get; set; }
        public List<Action> ActionsToDo { get; set; }
        public string ImageFileName { get; set; }
    }

    public class NPStep : Step
    {
        public NPStep() : base()
        {
            QMatrix = new float[3,2];
            LMatrix = new float[3,2];
        }
        public float[,] QMatrix { get; set; }
        public float[,] LMatrix { get; set; }
        public float B1 { get; set; }
    }

    public class SStep : Step
    {
        public SStep() : base()
        {
            QMatrix = new float[3, 2];
            LMatrix = new float[3, 2];
            ZMatrix = new float[3, 2];
            GMatrix = new float[2, 8];
        }
        public float[,] QMatrix { get; set; }
        public float[,] LMatrix { get; set; }
        public float[,] ZMatrix { get; set; }
        public float[,] GMatrix { get; set; }
    }
}
