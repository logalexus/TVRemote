using UI.Controllers;
using UI.Screens;

namespace UI.Commands
{
    public class DigitCommand : ICommand
    {
        private UIController _uiController;
        private int _digit;

        public DigitCommand(UIController uiController, int digit)
        {
            _uiController = uiController;
            _digit = digit;
        }

        public void Execute()
        {
            _uiController.ChannelsScreen.SelectChannel(_digit);
        }

        public void Undo()
        {
            
        }
    }
}