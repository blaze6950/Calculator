namespace WindowsFormsApplication1.Actions
{
    class NotAction : IAction
    {
        public double? Execute(double? num1, double? num2)
        {
            if (num1 != null)
            {
                if (num2 == null)
                {
                    return num1 - (num1 * 2);
                }
                else
                {
                    // in future process that situation, but now : 
                    return num1 - (num1 * 2);
                }
            }
            return null;
        }
        public override string ToString()
        {
            return "!";
        }
    }
}
