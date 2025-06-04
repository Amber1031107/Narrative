using UnityEngine;

public class OpenGlassDoor : MonoBehaviour
{
    public float speed = 5f; // Speed of movement

    public GameObject GlassDoor;

    public void OnTriggerEnter(Collider other)
    {
        if(GetComponent<Collider>().gameObject.tag == "Player")
        {
            GlassDoor.transform.Translate(Vector3.left * speed * Time.deltaTime);
            Debug.Log("It works");
        }
        // Move the object forward along its z-axis
        
    }
}
