using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private GameObject eButton;
    private Ray _ray;
    private RaycastHit hit;
    [SerializeField] private Camera camera;
    public float interactionDistance = 10f;
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
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == ("ePopup"))
            {
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
