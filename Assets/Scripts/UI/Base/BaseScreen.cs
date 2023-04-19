using UnityEngine;

namespace UI.Base
{
    [RequireComponent(typeof(Animation))]
    public abstract class BaseScreen : MonoBehaviour, IScreen
    {
        [Header("Animation")]
        [SerializeField] protected bool isAnimated = false;
        [SerializeField] protected AnimationClip openClip;
        [SerializeField] protected AnimationClip closeClip;
        [SerializeField] protected bool isTopLayer = false;

        protected Animation _animation;
        protected BaseUIController _baseUIController;

        public bool IsTopLayer => isTopLayer;

        public virtual void Init(BaseUIController baseUIController)
        {
            _baseUIController = baseUIController;

            if (isAnimated)
            {
                _animation = GetComponent<Animation>();
                _animation.AddClip(openClip, openClip.name);
                _animation.AddClip(closeClip, closeClip.name);
                openClip.legacy = true;
                closeClip.legacy = true;
            }

            Close();
        }

        public virtual void Open()
        {
            if(isAnimated)
                _animation.Play(openClip.name);
            else
                gameObject.SetActive(true);
        }

        public virtual void Close()
        {
            if (isAnimated)
                _animation.Play(closeClip.name);
            else
                gameObject.SetActive(false);
        }

    }
}