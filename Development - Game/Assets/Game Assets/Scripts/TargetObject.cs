using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargetObject : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winText.gameObject.SetActive(true);
        }
    }
}
