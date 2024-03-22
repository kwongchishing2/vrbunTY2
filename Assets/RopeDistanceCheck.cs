using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RopeDistanceCheck : MonoBehaviour
{
    public GameObject rope;
    public GameObject Center_piece, finishToBlackPanel;
    public AudioSource die;
    public float distance;
    public float grounddistance;
    public colliderBun colliderBun;
    public Text uitext;
    private Rigidbody rb;
    public checkpointtick1 checkpointtick1;
    public int finishTutor=0;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        distance = Vector3.Distance(transform.position, rope.transform.position);
        grounddistance = Vector3.Distance(transform.position, Center_piece.transform.position);
        if (distance > 53.06f||distance<53f) { 
            rb.isKinematic = false;
        }
        if (grounddistance > 10f||checkpointtick1.dead)
        {            
            finishToBlackPanel.SetActive(true);
            die.Play();
            uitext.text = "!!!!!!!!!!Tutorial Level Finish!!!!!!!!!!";
            Destroy(this.gameObject);
            colliderBun.bunCount += 3;
            colliderBun.bunCountText.text = colliderBun.bunCount.ToString();
            finishTutor=1;
            PlayerPrefs.SetInt("finishTutor", finishTutor);
        }
        
    }
}