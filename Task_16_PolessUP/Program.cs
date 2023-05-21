{
    static bool CheckPowersOfThree(int n)
    {
        while (n > 0)
        {
            int remainder = n % 3;
            if (remainder == 2)
            {
                return false;
            }
            n /= 3;
        }
        return true;

    }
    int n = 12;
    Console.WriteLine(CheckPowersOfThree(n));
}
