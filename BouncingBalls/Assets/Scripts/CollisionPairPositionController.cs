using UnityEngine;

public class CollisionPairPositionController : MonoBehaviour
{
    [SerializeField] private CollisionPairValues[] collisionPairs;
    [SerializeField] private CollisionPairValues previousTargetFinalPairPositions;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (collisionPairs.Length == 0)
        {
            collisionPairs = GetComponentsInChildren<CollisionPairValues>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: Change this, this isn't a once per update, this only needs to be handled upon moving the collision
        //set from -18 to 18, in the MovingTargetController script.
        foreach (CollisionPairValues pair in collisionPairs)
        {
            pair.CalculateNewPositions();
        }
    }
}
