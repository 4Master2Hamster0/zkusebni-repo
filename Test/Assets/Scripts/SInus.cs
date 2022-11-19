using UnityEngine;

public class SInus : MonoBehaviour
{
    public static int ID = 0;
    private int offset;
    private int amplitude = 50;

    private void Awake() {
        ID += 1;
        offset = ID;
    }
    
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time + offset * amplitude), transform.position.x);
    }

    public void printInfo(){
        print("offset: " + offset + ", ID: " + ID);
    }

}
