using UnityEngine;

public class npc_climb : MonoBehaviour
{
    public Transform ropeTransform;
    public float minClimbingSpeed = 0.0005f;
    public float maxClimbingSpeed = 0.01f;
    public bool startClimb = false;
    public bool pick = false;
    public float climbingSpeed;   
    private void Update(){
        if (startClimb&&!pick)
        {
            this.gameObject.GetComponent<Animator>().SetBool("startClimb", true);
            Vector3 climbDirection = ropeTransform.up;            
            Vector3 targetPosition = ropeTransform.position + climbDirection * ropeTransform.localScale.y;
            targetPosition += transform.forward;
            climbingSpeed = Random.Range(minClimbingSpeed, maxClimbingSpeed);
            transform.position = Vector3.Lerp(transform.position, targetPosition, climbingSpeed * Time.deltaTime);

            
        }if(pick){
                 this.gameObject.GetComponent<Animator>().SetBool("pick",true);
            }


        }

    public void startPick(){
        climbingSpeed=0f;        
    }


    public void finishPick(){
        pick=false;
        this.gameObject.GetComponent<Animator>().SetBool("pick",false);
    }


}