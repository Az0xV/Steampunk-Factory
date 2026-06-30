using UnityEngine;
using System.Collections;

public class CameraTest : MonoBehaviour
{
    [SerializeField] Transform cam;
    bool isMoved = false;
    private void Start()
    {
        StartCoroutine(TestCamera());
    }
    IEnumerator TestCamera()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Vector3 pos;
            Quaternion qua;
            if (isMoved)
            {
                pos = new(0, 0, -10);
                qua = Quaternion.Euler(0, 0, 0);
            }
            else
            {
                pos = new(-10, 0, 0);
                qua = Quaternion.Euler(0, 90, 0);
            }
            isMoved = !isMoved;

            cam.SetPositionAndRotation(pos, qua);
        }
    }
}
