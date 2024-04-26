using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndLevelTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _endLevelCanvas;

    public UnityEvent Triggered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<FirstPersonMovement>(out FirstPersonMovement firstPersonMovement))
        {
            Triggered?.Invoke();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _endLevelCanvas.SetActive(true);
            YandexSDK.instance.ShowInterstitial();
        }
    }
}