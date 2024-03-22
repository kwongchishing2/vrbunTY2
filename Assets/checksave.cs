using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class checksave : MonoBehaviour
{
    public GameObject GreenTick;
    void Start(){
        int finishTutor = PlayerPrefs.GetInt("finishTutor");
        if(finishTutor==1){
            GreenTick.SetActive(true);
        }
    }

}
