using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float limitTime = 60;

    [SerializeField] TextMeshProUGUI TimerText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        limitTime -= Time.deltaTime;
        if(limitTime<0)
        {
            limitTime=0;
        }

        TimerText.text = limitTime.ToString("F0");
    }
}
