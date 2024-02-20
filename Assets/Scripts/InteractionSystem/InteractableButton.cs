using System;
using UnityEngine;
using UnityEngine.Events;

namespace InteractionSystem
{
    public class InteractableButton : BasicInteractable
    {
        [SerializeField] private UnityEvent onClick;

        private bool _isEnabled;

        public override void Interact()
        {
            return;
        }

        public override void Interact(InteractorController interactor)
        {
            onClick.Invoke();
        }
    }
}