using UnityEngine;

public class CurveManager : MonoBehaviour
{
    public Transform point1, point2, point3, point4; // Points of a Segment

    [Header("Objects for interpolating between 2 points")]
    public Transform ip1, ip2, ip3; // interpolating objects between 2 points

    [Space, Header("Drawing Objects")]
    public Transform curveBrush1;
    public Transform curveBrush2;

    public Transform segmentCurveBrush;

    [Space]
    [Range(0, 1f)]
    public float speed;

    private void Update()
    {
        ip1.position = Lerp(point1.position, point2.position);
        ip2.position = Lerp(point2.position, point3.position);
        ip3.position = Lerp(point3.position, point4.position);


        curveBrush1.position = Lerp(ip1.position, ip2.position);
        curveBrush2.position = Lerp(ip2.position, ip3.position);

        segmentCurveBrush.position = Lerp(curveBrush1.position, curveBrush2.position);
    }


    private Vector3 Lerp(Vector3 point1, Vector3 point2)
    {
        return Vector3.Lerp(point1, point2, speed * Time.time);
    }
}
