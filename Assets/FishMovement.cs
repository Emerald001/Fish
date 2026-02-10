using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float speed;
    private float currentspeed;

    private void Update() {
        if (Input.GetKey(KeyCode.W)) {
            MoveForwards();
        }
        else if (currentspeed > 1) {
            currentspeed--;
            Debug.Log("Reduce!");
        }

        transform.position += Camera.main.transform.forward * currentspeed * Time.deltaTime;
    }

    public void MoveForwards() {
        transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward);

        if (currentspeed < speed) {
            currentspeed++;
            Debug.Log("Increase!");
        }
    }
}
