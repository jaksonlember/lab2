namespace BL2
{
    public class iOSButtonFactory : IButtonFactory
    {
        public IButton CreateButton()
        {
            return new iOSButton();
        }
    }
}
