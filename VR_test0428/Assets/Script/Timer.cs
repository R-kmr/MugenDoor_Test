using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class Timer : MonoBehaviour
{
    public float limitTime = 60;

    public TextMeshProUGUI TimerText;
    public TextMeshProUGUI timeUpText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (0 < limitTime)   //カウントダウン
        {
            limitTime -= Time.deltaTime;
            TimerText.text = limitTime.ToString("F0");
        }

        else if (limitTime <= 0)  //タイムアップ
        {
            timeUpText.text = "TIME UP!";

            // Invoke("ChangeScene", 2.f);
            StartCoroutine("ChangeScene");
        }

    }

    //void ChangeScene()
    //{
    //    SceneManager.LoadScene("ResultScene");
    //}

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2.0f);

        SceneManager.LoadScene("ResultScene");
    }
}
