using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartTimer : MonoBehaviour{
    public float totalTime = 3f;
    public float currentTime;
    public Text countdownText;
    public AudioSource countdownsound;
    public AudioSource failsound;
    public GameObject NPC2, NPC21, NPC22, NPC23, NPC24, NPC25, NPC26, NPC27, NPC28, NPC29, NPC210;
    public GameObject Timerobject, TimerText;
    private void Start(){
        currentTime = totalTime;
    }
    private void Update(){
        currentTime -= Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if(currentTime <= 0){
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
            Timerobject.SetActive(true);
            TimerText.SetActive(true);
            Destroy(this.gameObject);
            Destroy(countdownText, 4f);
        }
    }
    public void checkfail(){
        if (currentTime > 0)
        {
            countdownsound.Stop();
            failsound.Play();
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }
}