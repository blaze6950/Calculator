namespace WindowsFormsApplication1.Actions
{
    class GetPercentAction : IAction
    {
        public double? Execute(double? num1, double? num2)
        {
            if (num1 != null && num2 != null)
            {
                return num2 * (num1 / 100);
            }
            else
            {
                return num1;
            }
        }

        public override string ToString()
        {
            return "%";
        }
    }
}
