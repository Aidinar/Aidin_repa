using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] GameObject cam1;
    [SerializeField] GameObject cam2;
    private void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }
}
