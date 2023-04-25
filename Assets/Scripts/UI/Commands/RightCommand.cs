using UI.Controllers;

namespace UI.Commands
{
    public class RightCommand : ICommand
    {
        private UIController _uiController;

        public RightCommand(UIController uiController)
        {
            _uiController = uiController;
        }

        public void Execute()
        {
            _uiController.ChannelsScreen.SelectNextChannel();
        }

        public void Undo()
        {
            
        }
    }
}