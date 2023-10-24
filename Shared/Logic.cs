namespace BookBrowser.Shared
{
    public class Logic
    {
        public int CheckNumber(string a)
        {
            if (int.TryParse(a, out int inputNum))
            {
                return inputNum;
            }
            else
            {
                //Error
                return 999;
            }
        }
    }
}
