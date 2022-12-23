using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    private bool isOpened;
    [SerializeField] private Animator animator;
    private AudioSource audioSource;
    [SerializeField] private List <AudioClip> doorzvukList;
    private void Reset()
    {
        animator = GetComponent<Animator>();
    }
    private void OpenSound()
    {
      audioSource.PlayOneShot(doorzvukList[Random.Range(0, doorzvukList.Count)]);
    }
    public void Open()
    {
        isOpened = !isOpened;
        animator.SetBool("isOpened", isOpened);
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
