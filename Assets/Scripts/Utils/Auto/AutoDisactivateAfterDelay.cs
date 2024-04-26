using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDisactivateAfterDelay : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private GameObject _toDisactivate;

    private void Start()
    {
        Invoke(nameof(Disactivate), _delay);
    }

    private void Disactivate()
    {
        _toDisactivate.SetActive(false);
    }
}