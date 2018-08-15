namespace WindowsFormsApplication1.Actions
{
    class MinusAction : IAction
    {
        public double? Execute(double? num1, double? num2)
        {
            if (num1 != null) if (num2 != null) return num1 - num2;
            return null;
        }

        public override string ToString()
        {
            return "-";
        }
    }
}
