using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.VFX;

public class Switcher : MonoBehaviour
{
    [SerializeField] private Camera _fpsCam;
    [SerializeField] private float _maxdistray;
    [SerializeField] public Light _light;

    private Vector2 _screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
    private RaycastHit _hit;
    private AudioSource audioSource;
    [SerializeField] private AudioClip _clip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        _light.enabled = false;


    }
    private void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (enterzone.coll)
            {
                Ray ray = _fpsCam.ScreenPointToRay(_screenCenter);
                if (Physics.Raycast(ray, out _hit, _maxdistray))
                {
                    if (_light)
                    {
                        Enable();
                    }
                }
            }
        }

    }
    public void Enable()
    {
        _light.enabled = !_light.enabled;

        audioSource.PlayOneShot(_clip);
    }
}