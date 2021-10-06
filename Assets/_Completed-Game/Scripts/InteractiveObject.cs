using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractiveObject : MonoBehaviour, IInteractable
{
    public bool IsInteractable { get; }
    protected abstract void Interaction();

    private void Start()
    {
        ((IAction)this).Action();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!IsInteractable || !other.CompareTag("Player"))
        {
            return;
        }
        Interaction();
        Destroy(gameObject);
    }

    void IAction.Action()
    {
        if (TryGetComponent(out Renderer renderer))
        {
            renderer.material.color = Random.ColorHSV();
        }
    }

}


