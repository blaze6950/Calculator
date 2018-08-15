using System;
using WindowsFormsApplication1.Actions;

namespace WindowsFormsApplication1
{
    class Calc
    {
        private double? _num1;
        private double? _num2;
        private double? _memory;
        public double? Num1
        {
            get { return _num1; }
            set { _num1 = value; }
        }
        public double? Num2
        {
            get { return _num2; }
            set { _num2 = value; }
        }
        public double? Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }

        public IAction Action
        {
            get { return _action; }
            set { _action = value; }
        }
        

        private IAction _action;

        public bool IsActionNull()
        {
            if (Action == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double? Calculate()
        {
            return Action.Execute(Num1, Num2);
        }

        public override string ToString()
        {
            string result = String.Empty;
            if (Num1 != null)
            {
                result += Num1.ToString() + " ";
                if (Action != null)
                {
                    result += Action + " ";
                }
                if (Num2 != null)
                {
                    result += Num2.ToString();
                }
            }
            else
            {
                result = "0";
            }
            
            return result;
        }
    }
}
