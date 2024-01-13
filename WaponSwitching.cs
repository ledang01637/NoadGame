using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaponSwitching : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;


    private void Update()
    {
        // Kiểm tra phím 1, 2, 3, 4
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gameObject1.SetActive(true);
            gameObject2.SetActive(false);
            gameObject3.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gameObject1.SetActive(false);
            gameObject2.SetActive(true);
            gameObject3.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            gameObject1.SetActive(false);
            gameObject2.SetActive(false);
            gameObject3.SetActive(true);
        }

    }

}
