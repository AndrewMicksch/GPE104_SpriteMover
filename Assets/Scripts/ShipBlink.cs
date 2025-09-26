using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //TODO: Specify the Location variables
    private Transform currentLocation;
    public float maxPosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentLocation = gameObject.GetComponent<Transform>();
        float maxPosition ()
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: Create The Teleport Code
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("The T key is down");
            //Set the locations it can teleport to
            float axisValue = Input.GetAxis(1,1,0);
            float position = axisValue * localPosition;
            currentLocation.localPosition += Vector3.one * positionAmount;
        }

    }
}
