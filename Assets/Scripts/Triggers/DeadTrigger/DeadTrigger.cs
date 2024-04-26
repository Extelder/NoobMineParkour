using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeadTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _deadCanvas;

    public UnityEvent Triggered;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<FirstPersonMovement>(out FirstPersonMovement firstPersonMovement))
        {
            Triggered?.Invoke();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _deadCanvas.SetActive(true);
        }
    }
}
