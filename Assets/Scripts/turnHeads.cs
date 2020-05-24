using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnHeads : MonoBehaviour
{
    public GameObject head1;
    public GameObject head2;
    public GameObject head3;
    public GameObject head4;
    public float yAngle = -180;



    private void onTriggerEnter(Collider collider)
    {
        head1.transform.Rotate(0f, yAngle, 0f, Space.World);
        head2.transform.Rotate(0f, yAngle, 0f, Space.World);
        head3.transform.Rotate(0f, yAngle, 0f, Space.World);
        head4.transform.Rotate(0f, yAngle, 0f, Space.World);
    }

    /*

    private void OnCollisionEnter(Collision collision)
    {
        head1.transform.Rotate(0f, yAngle, 0f, Space.Self);
        head2.transform.Rotate(0f, yAngle, 0f, Space.Self);
        head3.transform.Rotate(0f, yAngle, 0f, Space.Self);
        head4.transform.Rotate(0f, yAngle, 0f, Space.Self);
    }
    */
}
