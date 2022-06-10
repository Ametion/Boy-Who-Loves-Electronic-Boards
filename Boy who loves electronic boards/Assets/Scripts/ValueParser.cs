namespace Components
{
    public static class ValueParser 
    {
        private static string[] names = { "", "K", "M", "B", "T" };
        public static string Parse(decimal digit)
        {
            if (digit < 1000)
                return digit.ToString();

            int n = 0;
            while (n + 1 < names.Length && digit >= 1000m)
            {
                digit /= 1000m;
                n++;
            }
            return digit.ToString("#.##") + names[n];
        }

        public static string UnParse(string val)
        {
            char suffix=val[val.Length - 1];
            float multiplier = 0;
            switch(suffix)
            {
                case 'K':
                    multiplier = 1000;
                    break;
                case 'M':
                    multiplier = 1000000;
                    break;
                case 'B':
                    multiplier = 1000000000;
                    break;
                case 'T':
                    multiplier = 1000000000000;
                    break;
            }
            if (multiplier != 0)
            {
                val = val.Remove(val.Length - 1);
                float res= float.Parse(val) * multiplier;
                return res.ToString();
            }
            else
            {
                return float.Parse(val).ToString();
            }
        }
    }
}