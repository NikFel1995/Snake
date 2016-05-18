
namespace Snake
{
    internal static class HelperMethods
    {
        /// <summary>
        /// Поменять местами значения переменных
        /// </summary>
        /// <param name="xLeft">Переменная 1</param>
        /// <param name="xRight">Переменная 2</param>
        public static void Swap(ref int xLeft, ref int xRight)
        {
            var temp = xLeft;
            xLeft = xRight;
            xRight = temp;
        }
    }
}
