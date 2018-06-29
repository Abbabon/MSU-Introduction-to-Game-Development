using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public Transform target; // the object to rotate around
	public int speed; // the speed of rotation
    public int direction=0; // the direction of the rotation
	
	void Start() {
		if (target == null) 
		{
			target = this.gameObject.transform;
			Debug.Log ("RotateAround target not specified. Defaulting to parent GameObject");
		}
	}

	// Update is called once per frame
	void Update () {
        // RotateAround takes three arguments, first is the Vector to rotate around
        // second is a vector that axis to rotate around
        // third is the degrees to rotate, in this case the speed per second

        Vector3 rotationDirectionVector = new Vector3(0,0,0);

        switch (direction)
        {
            case 0:
                rotationDirectionVector = target.transform.up;
                break;
            case 1:
                rotationDirectionVector = target.transform.forward;
                break;
            case 2:
                rotationDirectionVector = target.transform.right;
                break;
            default:
                break;
        }

        transform.RotateAround(target.transform.position, rotationDirectionVector, speed * Time.deltaTime);
	}
}
