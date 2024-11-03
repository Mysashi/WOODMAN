using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private GameObject eButton;
    private Ray _ray;
    private RaycastHit hit;
    [SerializeField] private Camera camera;
    public float interactionDistance = 0.3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Ray ray = Camera.main.ScreenPointToRay(screenCenter);

        //_ray = new Ray(gameObject.transform.position, Vector3.forward * 1000f);

        Debug.DrawRay(ray.origin, ray.direction * interactionDistance, Color.red);
        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            if (hit.collider.tag == ("ePopup"))
            {
                if (Input.GetKey(KeyCode.E))
                {
                    this.gameObject.SetActive(false);
                    hit.collider.gameObject.SetActive(true);
                    hit.c
                }
                Debug.Log(hit.collider.gameObject);
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
