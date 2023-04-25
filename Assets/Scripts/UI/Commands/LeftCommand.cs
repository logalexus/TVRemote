using UI.Controllers;

namespace UI.Commands
{
    public class LeftCommand : ICommand
    {
        private UIController _uiController;

        public LeftCommand(UIController uiController)
        {
            _uiController = uiController;
        }

        public void Execute()
        {
            _uiController.ChannelsScreen.SelectNextChannel(-1);
        }

        public void Undo()
        {
            
        }
    }
}