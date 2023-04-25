using UI.Controllers;

namespace UI.Commands
{
    public class OkCommand : ICommand
    {
        private UIController _uiController;

        public OkCommand(UIController uiController)
        {
            _uiController = uiController;
        }

        public void Execute()
        {
            _uiController.InvokeOk();
        }

        public void Undo()
        {
            
        }
    }
}