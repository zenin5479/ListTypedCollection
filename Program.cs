// Использование Enumerable.Contains() метод (System.Linq)

namespace ListTypedCollection
{
    public static class Extensions
    {
        private static int _indexOf;

        public static int Find<T>(this List<T> list, T target)
        {
            _indexOf = list.IndexOf(target);
            return _indexOf;
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            const int target = 4;

            var isExist = list.Find(target);

            if (isExist != 0)
            {
                Console.WriteLine(isExist);
            }
            else
            {
                Console.WriteLine("Элемент, не найден в данном списке");
            }
        }
    }
}