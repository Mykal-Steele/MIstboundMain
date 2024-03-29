using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Guns : MonoBehaviour
{
    public float offset;
    public GameObject projectile;
    public Transform shotPoint;
    private void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; 
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if(Input.GetMouseButtonDown(0)){
            Instantiate(projectile, shotPoint.position, transform.rotation);
        }
    }
}
