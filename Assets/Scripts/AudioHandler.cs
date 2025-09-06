using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class AudioHandler : MonoBehaviour
{
    public AudioClip ButtonSound;
    public AudioClip ObstacleHit;
    public AudioClip CoinCollect;

    public AudioSource audioSource;
    public static AudioHandler instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    public void PlayButtonClickSound()
    {
        audioSource.clip= ButtonSound;
        audioSource.loop = false;
        audioSource.playOnAwake = false;
        audioSource.Play();
    }
    public void PlayCoinCollectSound()
    {
        audioSource.clip = CoinCollect;
        audioSource.loop = false;
        audioSource.playOnAwake = false;
        audioSource.Play();
    }
    public void PlayOnObstacleHit()
    {
        audioSource.clip = ObstacleHit;
        audioSource.loop = false;
        audioSource.playOnAwake = false;
        audioSource.Play();
    }
}
