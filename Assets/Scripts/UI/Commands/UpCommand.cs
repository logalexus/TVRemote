using UI.Controllers;

namespace UI.Commands
{
    public class UpCommand : ICommand
    {
        private UIController _uiController;

        public UpCommand(UIController uiController)
        {
            _uiController = uiController;
        }

        public void Execute()
        {
            _uiController.LoginScreen.SelectNextField(-1);
        }

        public void Undo()
        {
            
        }
    }
}