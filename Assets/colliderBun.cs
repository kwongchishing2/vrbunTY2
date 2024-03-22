using UnityEngine;
using UnityEngine.UI;

public class colliderBun : MonoBehaviour
{
    public checkpointtick1 checkpointtick1;
    public Text bunCountText,tutorialText;
    public int bunCount;
    public GameObject NPC;
    public AudioSource pulldown;
    public bool collected;
    private void OnTriggerEnter(Collider other){
        if (other.tag == "cangrabbun") collected=true;Destroy(other.gameObject);bunCount++; bunCountText.text = bunCount.ToString(); this.gameObject.GetComponent<AudioSource>().Play();
             pulldown.Play(); tutorialText.text = "                         Next, pull your opponent down and steal his buns.";
    }
    void Update()
    {
        collected=checkpointtick1.collected;
        if (collected)
        {
            NPC.SetActive(true);
           // tutorialText.text = "                         Next, pull your opponent down and steal his buns.";
        }
    }
}
