using System;

namespace BL2
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Створено кнопку у стилі WINDOWS");
        }
    }
}
