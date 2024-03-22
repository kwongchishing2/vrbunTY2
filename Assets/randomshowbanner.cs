using UnityEngine;

public class randomshowbanner : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    private float timer;
    public float switchInterval = 5f;
   
    private void Start()
    {
        ShowRandomImage();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= switchInterval)
        {
            timer = 0f;

            ShowRandomImage();
        }
    }
    private void ShowRandomImage()
    {
        int randomIndex = Random.Range(0, 2);

        if (randomIndex == 0)
        {
            image1.SetActive(true);
            image2.SetActive(false);
        }
        else
        {
            image1.SetActive(false);
            image2.SetActive(true);
        }
    }
}