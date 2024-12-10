/* Name: Idan Shaviner
 * Date: 12/9/2024
 * Desb: Resize the player character 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResize : MonoBehaviour
{
    //variables
    public float resizeSpeed = 0.05f;
    public float minSize = 0.5f;
    public float maxSize = 3f;

    // Update is called once per frame
    void Update()
    {

        //get smaller if Q is pressed
        if (Input.GetKey(KeyCode.Q))
        {
            resizePlayer(-resizeSpeed);
        }
        //get bigger if E is pressed
        if (Input.GetKey(KeyCode.E))
        {
            resizePlayer(resizeSpeed);
        }
    }
    void resizePlayer(float amount)
    {
        //current scale
        Vector3 current = transform.localScale;
        //add new scale to each axis
        float newX = Mathf.Clamp(current.x + amount, minSize, maxSize);
        float newY = Mathf.Clamp(current.y + amount, minSize, maxSize);
        float newZ = Mathf.Clamp(current.z + amount, minSize, maxSize);
        // new scale
        transform.localScale = new Vector3(newX, newY, newZ);
    }
}
