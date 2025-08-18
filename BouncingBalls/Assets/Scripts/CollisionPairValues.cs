using System;
using UnityEngine;

public class CollisionPairValues : MonoBehaviour
{
    public float upperY, lowerY, spreadDistance;
    
    private GameObject _upperBox, _lowerBox;

    private void Start()
    {
        _upperBox = this.transform.GetChild(0).gameObject;
        _lowerBox = this.transform.GetChild(1).gameObject;
    }

    public float[] GetValues()
    {
        return new[] { upperY, lowerY, spreadDistance };
    }

    private void SetPos(float newUpperY, float newLowerY, float newSpreadDistance)
    {
        upperY = newUpperY;
        _upperBox.transform.position = new Vector3(_upperBox.transform.position.x, newUpperY, _upperBox.transform.position.z);
        lowerY = newLowerY;
        _lowerBox.transform.position = new Vector3(_lowerBox.transform.position.x, newLowerY, _lowerBox.transform.position.z);
        spreadDistance = newSpreadDistance;
    }

    public void CalculateNewPositions()
    {
        //TODO: Figure out what kind of math we want to handle new positions of the two boxes
        //Ensure the new spread distance is still enough for the sphere to go through
        //As well as that the current pair isn't too different from the previous pair
    }
}
