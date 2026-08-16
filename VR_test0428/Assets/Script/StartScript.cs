using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    [SerializeField] GameObject Rdoor;
    [SerializeField] GameObject Ldoor;


    [SerializeField] TextMeshProUGUI TimerText;
    float countdown = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Rdoor.GetComponent<Open>().open && Ldoor.GetComponent<Open>().open) //瀬裕の扉が開いたら
        {
            countdown -= Time.deltaTime;　　//カウントダウン開始
            if (countdown <= 1)
            {
                countdown = 1;
                ChangeScene();
            }
            TimerText.text = countdown.ToString("F0");
        }

    }

    void ChangeScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
