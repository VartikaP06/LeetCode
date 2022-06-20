namespace AdditiveNumbers
{
    public class Implementation
    {
        public bool IsAdditiveNumber(string num)
        {
            var n = num.Length;

            if (n < 3)
            {
                return true;
            }

            for (int i = 2; i < n; i++)
            {
                var fn = Convert.ToInt32(num[i - 2] - '0');
                var sn = Convert.ToInt32(num[i - 1] - '0');
                var tn = Convert.ToInt32(num[i] - '0');

                int sum = fn + sn;
                if (tn != sum)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
