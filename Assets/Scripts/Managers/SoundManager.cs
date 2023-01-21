using System.Collections;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _failSound;
    [SerializeField] private Transform _crystalSoundsRoot;

    public static SoundManager Instance;

    private void Start()
    {
        Instance = this;
    }
    

    public void PlayFailSound()
    {
        PlaySound(_failSound);
    }
    public void DiamondTookSound()
    {
        PlaySound(_crystalSoundsRoot.Find(Random.RandomRange(0, 4).ToString()).GetComponent<AudioSource>());
    }
    private void PlaySound(AudioSource audioSource)
    {
        StartCoroutine(Play(audioSource));
    }
    private IEnumerator Play(AudioSource audioSource)
    {
        AudioSource audio = Instantiate(audioSource);
        audio.Play();

        yield return new WaitForSeconds(5);
        Destroy(audio);
    }
}
