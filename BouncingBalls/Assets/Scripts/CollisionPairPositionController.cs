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
        foreach (CollisionPairValues pair in collisionPairs)
        {
            pair.CalculateNewPositions();
        }
    }
}
