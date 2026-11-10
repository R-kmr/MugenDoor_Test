using OVR.OpenVR;
using UnityEngine;
using TMPro;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.SceneManagement;



public class ScoreScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Text;

    [SerializeField] GameObject Rdoor;
    [SerializeField] GameObject Ldoor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int score = GenerateDoor.GetScore();

        string opened = score.ToString();
        Text.text = opened;

        if(Rdoor.GetComponent<Open>().open)
        {

        }

        if(Ldoor.GetComponent<Open>().open)
        {
            Invoke("ChangeScene", 2.0f);
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
