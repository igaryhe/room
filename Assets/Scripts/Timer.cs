using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float start;
    private float current = 0;
    private TextMeshProUGUI _text;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _text.text = "00:00";
        current = start;
    }

    private void Update()
    {
        if (current <= 0) current = 0;
        current -= 1 * Time.deltaTime;
        var min = (int) (current / 60f);
        var sec = (int) (current % 60f);
        _text.text = min.ToString("00") + ":" + sec.ToString("00");
    }
}
