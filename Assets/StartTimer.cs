using UnityEngine;
using UnityEngine.UI;
public class StartTimer : MonoBehaviour
{
    public GameObject Lhand;
    public GameObject Rhand;
    public float totalTime = 3f;
    public float currentTime;
    public Text countdownText;

    private void Start()
    {
       // Lhand.SetActive(false);
      //  Rhand.SetActive(false);
        // countdownText = GetComponent<Text>();
        currentTime = totalTime;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {            
            countdownText.text = "START!!!";
            // Lhand.SetActive(true);
            //  Rhand.SetActive(true);
            Destroy(countdownText, 4f);
            // �˼ƭp�ɵ����᪺�ާ@�A�ҦpĲ�o�ƥ�ΰ����L�N�X
        }
    }
}