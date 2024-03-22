using UnityEngine.UI;
using UnityEngine;

public class changeText : MonoBehaviour
{
    public Text tutorialText;
    public AudioSource hereShowyou;
    bool showed = false;
    public GameObject arrow;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "p" && showed == false)
        {
            tutorialText.text = "                         Here is to show you how many buns you collected.";
            hereShowyou.Play();
            arrow.SetActive(true);
            showed = true;
        }
    }
}
