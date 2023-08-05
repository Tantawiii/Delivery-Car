using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerTrigger : MonoBehaviour
{
    [SerializeField] GameObject bridgemark;
    [SerializeField] bool activate;
    private void OnTriggerEnter2D(Collider2D other) {
        bridgemark.SetActive(activate);
    }
}
