using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shagi : MonoBehaviour
{
    [SerializeField] private AudioSource moveSound;
    void Update()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.35f ^ Mathf.Abs(Input.GetAxis("Vertical")) > 0.35f ^ (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.35f && Mathf.Abs(Input.GetAxis("Vertical")) > 0.35f))
        {
            if (moveSound.isPlaying) return;
            moveSound.Play();
        }
        else
        {
            moveSound.Stop();
        }
    }
}
