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
                Notification.ShowMessage(MessageType.UnknownInput, null, null);
                return CheckNumber(Console.ReadLine());
            }
        }
    }
}
