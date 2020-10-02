using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int start;
    public AudioClip tick;
    private AudioSource _audioSource;
    private int current = 0;
    private TextMeshProUGUI _text;

    private void Start()
    {
        _audioSource = gameObject.AddComponent<AudioSource>();
        _text = GetComponent<TextMeshProUGUI>();
        _text.text = "00:00";
        current = start;
        StartCoroutine(Tick());
    }
    
    private IEnumerator Tick()
    {
        while (current >= 0)
        {
            _audioSource.PlayOneShot(tick, 1f);
            var min = current / 60;
            var sec = current % 60;
            _text.text = min.ToString("00") + ":" + sec.ToString("00");
            current--;
            yield return new WaitForSeconds(1f);
        }
    }
}
