using UnityEngine;
using UnityEngine.UI;
public class StartTimer : MonoBehaviour
{
    //public GameObject Lhand;
   // public GameObject Rhand;
    public float totalTime = 3f;
    public float currentTime;
    public Text countdownText;
    public GameObject fake12345;
    public GameObject f1,f2,f3,f4,f5;
    public GameObject NPC2, NPC21, NPC22, NPC23, NPC24, NPC25, NPC26, NPC27, NPC28, NPC29, NPC210;
    private void Start()
    {
     //   Lhand.SetActive(false);
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
            f1.SetActive(true);
            f2.SetActive(true);
            f3.SetActive(true);
            f4.SetActive(true);
            f5.SetActive(true);
            fake12345.SetActive(false);
            NPC2.GetComponent<npc_climb>().startClimb = true;
            NPC21.GetComponent<npc_climb>().startClimb = true;
            NPC22.GetComponent<npc_climb>().startClimb = true;
            NPC23.GetComponent<npc_climb>().startClimb = true;
            NPC24.GetComponent<npc_climb>().startClimb = true;
            NPC25.GetComponent<npc_climb>().startClimb = true;
            NPC26.GetComponent<npc_climb>().startClimb = true;
            NPC27.GetComponent<npc_climb>().startClimb = true;
            NPC28.GetComponent<npc_climb>().startClimb = true;
            NPC29.GetComponent<npc_climb>().startClimb = true;
            NPC210.GetComponent<npc_climb>().startClimb = true;
            countdownText.text = "START!!!";

            // Lhand.SetActive(true);
           //   Rhand.SetActive(true);
            Destroy(this.gameObject);
            Destroy(countdownText, 4f);
            // 倒數計時結束後的操作，例如觸發事件或執行其他代碼
        }
    }
}