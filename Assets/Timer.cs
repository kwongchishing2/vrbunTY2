using UnityEngine;using UnityEngine.UI;
public class Timer:MonoBehaviour{
    public float totalTime = 30f; 
    public float currentTime;
    public Text countdownText; 

    private void Start()
    {
       // countdownText = GetComponent<Text>();
        currentTime = totalTime;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;
        countdownText.text = "Time Left " +currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            // �˼ƭp�ɵ����᪺�ާ@�A�ҦpĲ�o�ƥ�ΰ����L�N�X
        }
    }
}