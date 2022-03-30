Even/Odd
        if(arr.Length % 2 == 0) //even
        {

            return (Convert.ToDouble(arr[(n / 2) - 1]) + Convert.ToDouble(arr[(n / 2)])) / 2.0;
        }
        else
        {
            return arr[((n + 1) / 2) - 1];
        }
