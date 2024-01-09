namespace BL2
{
    public class AndroidButtonFactory : IButtonFactory
    {
        public IButton CreateButton()
        {
            return new AndroidButton();
        }
    }
}
