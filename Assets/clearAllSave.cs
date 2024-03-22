using UnityEngine;
public class clearAllSave : MonoBehaviour
{
	public GameObject GreenTick;
   public void Delsave(){
	   PlayerPrefs.DeleteAll();Destroy(GreenTick);
   }
}
