using UnityEngine;

public class MovingTargetController : MonoBehaviour
{
    [SerializeField] private GameObject movingTargetOne, movingTargetTwo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (movingTargetOne == null)
        {
            movingTargetOne = GameObject.Find("MovingTargetOne");
        }
        if (movingTargetTwo == null)
        {
            movingTargetTwo = GameObject.Find("MovingTargetTwo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        movingTargetOne.transform.position = movingTargetOne.transform.position.x <= -18 ? new Vector3(18, 0, 0) : 
            new Vector3(movingTargetOne.transform.position.x - Time.deltaTime, 0, 0);
        
        movingTargetTwo.transform.position = movingTargetTwo.transform.position.x <= -18 ? new Vector3(18, 0, 0) : 
            new Vector3(movingTargetTwo.transform.position.x - Time.deltaTime, 0, 0);
        
        //Debug.Log(movingTargetOne.transform.position);
        //Debug.Log(movingTargetTwo.transform.position);
    }
}
