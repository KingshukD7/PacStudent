using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip introClip;
        public AudioClip ghostsClip;
        
        private AudioSource audioSource;
    
        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
            PlayMusic();
        }
    
        public void PlayMusic()
        {
            audioSource.clip = introClip;
            audioSource.Play();
            Invoke("PlayGhostsMusic", introClip.length);
        }
    
        private void PlayGhostsMusic()
        {
            audioSource.clip = ghostsClip;
            audioSource.Play();
        }
}
