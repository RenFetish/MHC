using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    [SerializeField] private Camera _fpsCam;
    [SerializeField] private float _maxdistray;
    private Vector2 _screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
    private RaycastHit _hit;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = _fpsCam.ScreenPointToRay(_screenCenter);
            if (Physics.Raycast(ray, out _hit, _maxdistray))
            {
                Door door = _hit.transform.GetComponent<Door>();
                if (door)
                {
                    door.Open();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = _fpsCam.ScreenPointToRay(_screenCenter);
            if (Physics.Raycast(ray, out _hit, _maxdistray))
            {
                Light light = _hit.transform.GetComponent<Light>();
                if (light)
                {
                    light.enabled = !light.enabled;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = _fpsCam.ScreenPointToRay(_screenCenter);
            if (Physics.Raycast(ray, out _hit, _maxdistray))
            {
               
            }
        }
    }

}