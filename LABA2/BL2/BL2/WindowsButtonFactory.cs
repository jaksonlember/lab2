namespace BL2
{
    public class WindowsButtonFactory : IButtonFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
