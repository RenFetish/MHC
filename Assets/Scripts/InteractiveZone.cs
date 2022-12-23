using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveZone : MonoBehaviour
{
    [SerializeField] Canvas _canvas;
    
    [SerializeField] private Camera _fpsCam;
    [SerializeField] private float _maxdistray;
    private Vector2 _screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
    private RaycastHit _hit;
    public GameObject _player;
    public static bool _coll;
    private void Update()
    {
        if (_coll == true)
        {
            Ray ray = _fpsCam.ScreenPointToRay(_screenCenter);
            if (Physics.Raycast(ray, out _hit, _maxdistray))
            {
                Object @object = _hit.transform.GetComponent<Interactive>();
                if (@object)
                {
_canvas.enabled = true;
                }
                
            }
        }
    }
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == _player)
            _coll = true;
    }
    private void OnTriggerExit(Collider collider)
    {

        if (collider.gameObject == _player)
            _coll = false;
    }
}