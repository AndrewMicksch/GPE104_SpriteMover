using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //TODO: Specify the Location variables
    private Transform location;
    public Vector2 currentLocation = new Vector2(0f, 0f);
    public Vector2 randomX = new Vector2();
    public Vector2 randomY = new Vector2();
    float minX = -10f;
    float maxX = 10f;
    float minY = -5f;
    float maxY = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        // Limits of position
       

        //Random location within range
       
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: Create The Teleport Code
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("The T key is down");
            //Set the locations it can teleport to
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            transform.position = new Vector2(randomX, randomY);
        }

    }
}
