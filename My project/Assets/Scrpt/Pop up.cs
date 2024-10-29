using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private GameObject eButton;
    private Ray _ray;
    private RaycastHit hit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _ray = new Ray(gameObject.transform.position, Vector3.forward * 1000f);
        Debug.DrawRay(gameObject.transform.position, Vector3.forward, Color.magenta, 1000f);
        if (Physics.Raycast(_ray, out hit))
        {
            if (hit.collider.gameObject.CompareTag("ePopup"))
            {
                eButton.SetActive(true);
            }
            else
                eButton.SetActive(false);
        }
        else
        {
            eButton.SetActive(false);
        }
    }
}
