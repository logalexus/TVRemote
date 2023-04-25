using System;

namespace DefaultNamespace.UI.Remotes
{
    public interface IRemote
    {
        event Action<int> OnPressed;
    }
}