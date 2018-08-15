using System;

namespace WindowsFormsApplication1.Actions
{
    class SquareRootAction : IAction
    {
        public double? Execute(double? num1, double? num2)
        {
            if (num1 != null)
            {
                if (num2 == null)
                {
                    if (num1 >= 0)
                    {
                        return Math.Sqrt(num1.Value);
                    }
                    else
                    {
                        throw new Exception("Для этой операции исходное значение не может быть меньше нуля!");
                    }
                }
                else
                {
                    // in future process that situation, but now : 
                    if (num1 >= 0)
                    {
                        return Math.Sqrt(num1.Value);
                    }
                    else
                    {
                        throw new Exception("Для этой операции исходное значение не может быть меньше нуля!");
                    }
                }
            }
            return null;
        }
        public override string ToString()
        {
            return "√";
        }
    }
}
