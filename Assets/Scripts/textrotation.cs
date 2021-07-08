using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textrotation : MonoBehaviour
{
    float lockPos = 0;

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "texttag")
        {
            transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
            this.transform.RotateAround(this.transform.parent.position, this.transform.parent.forward, 90 * Time.deltaTime);
        }
    }
}
