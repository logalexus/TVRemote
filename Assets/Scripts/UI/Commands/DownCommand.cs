using UI.Controllers;

namespace UI.Commands
{
    public class DownCommand : ICommand
    {
        private UIController _uiController;

        public DownCommand(UIController uiController)
        {
            _uiController = uiController;
        }

        public void Execute()
        {
            _uiController.LoginScreen.SelectNextField();
        }

        public void Undo()
        {
            
        }
    }
}