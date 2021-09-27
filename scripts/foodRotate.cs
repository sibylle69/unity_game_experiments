using System.Collections;
using UnityEngine;

public class foodRotate : MonoBehaviour
{
    void Update()
        {
            transform.Rotate(Vector3.up * 50 * Time.deltaTime, Space.Self);
        }
}
