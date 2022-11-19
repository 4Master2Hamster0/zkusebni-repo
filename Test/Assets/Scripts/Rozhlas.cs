using UnityEngine;

public class Rozhlas : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) {
            foreach(SInus sinGO in GameObject.FindObjectsOfType<SInus>()) {
                sinGO.GetComponent<SInus>().printInfo();
            }
        }
    }
}
