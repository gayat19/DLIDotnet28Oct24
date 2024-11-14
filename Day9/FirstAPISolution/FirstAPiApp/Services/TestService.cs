using FirstAPiApp.Interfaces;

namespace FirstAPiApp.Services
{
    public class TestService : ITest
    {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int RandomSquare(int max)
        {
            int num = new Random().Next(max);
            return num*num;
        }
    }
}
