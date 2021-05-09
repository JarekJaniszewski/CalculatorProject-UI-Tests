namespace CalculatorProject.Logic.WindowsObjects
{
    public interface IStandardOperatorsView : ICalculatorView
    {
        ICalculatorView DivideBy();

        ICalculatorView MultiplyBy();

        ICalculatorView Minus();

        ICalculatorView Plus();

        ICalculatorView Equals();
    }
}