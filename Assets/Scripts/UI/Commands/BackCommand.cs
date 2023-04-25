using UI.Controllers;

namespace UI.Commands
{
    public class BackCommand : ICommand
    {
        private UIController _uiController;

        public BackCommand(UIController uiController)
        {
            _uiController = uiController;
        }

        public void Execute()
        {
            _uiController.InvokeBack();
        }

        public void Undo()
        {
            
        }
    }
}