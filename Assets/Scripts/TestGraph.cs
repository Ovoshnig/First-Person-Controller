using UnityEngine;

public class TestGraph : MonoBehaviour
{
    [SerializeField] private AnimationCurve _curveX;
    [SerializeField] private AnimationCurve _curveY;

    private Keyframe keyframeX;
    private Keyframe keyframeY;

    private void Update()
    {
        keyframeX = new Keyframe(Time.time, transform.eulerAngles.x, 0, 0, 0, 0);
        keyframeY = new Keyframe(Time.time, transform.eulerAngles.y, 0, 0, 0, 0);

        _curveX.AddKey(keyframeX);
        _curveY.AddKey(keyframeY);
    }
}
