using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargetObject : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winText;
    [SerializeField] TextMeshProUGUI endingText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            endingText.gameObject.SetActive(false);
            winText.gameObject.SetActive(true);
        }
    }
}
