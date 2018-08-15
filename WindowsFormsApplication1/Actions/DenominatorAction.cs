namespace WindowsFormsApplication1.Actions
{
    class DenominatorAction : IAction
    {
        public double? Execute(double? num1, double? num2)
        {
            if (num1 != null)
            {
                return 1 / num1;
            }
            else
            {
                return null;
            }
        }
    }
}
