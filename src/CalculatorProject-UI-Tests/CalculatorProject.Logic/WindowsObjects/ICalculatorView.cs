namespace CalculatorProject.Logic.WindowsObjects
{
    public interface ICalculatorView
    {
        INumbersView Numbers { get; }
        IStandardOperatorsView StandardOperatorsView { get; }

        ICalculatorView ClearEntry();
        ICalculatorView SetStandardMode();
        string ReadResult();

        void Close();
    }
}