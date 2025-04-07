using UnityEngine;

public class Clock : MonoBehaviour {

    const float hours_to_degrees = -30.0f, minutes_to_degrees = -6.0f, seconds_to_degrees = -6.0f;

    [SerializeField]
    Transform hours_pivot, minutes_pivot, seconds_pivot;

    void Awake () {
        System.TimeSpan time = System.DateTime.Now.TimeOfDay;
        hours_pivot.localRotation = Quaternion.Euler(0f, 0f, (float)time.TotalHours * hours_to_degrees);
        minutes_pivot.localRotation = Quaternion.Euler(0f, 0f, (float)time.TotalMinutes * minutes_to_degrees);
        seconds_pivot.localRotation = Quaternion.Euler(0f, 0f, (float)time.TotalSeconds * seconds_to_degrees);
    }

    void Update() {
        System.TimeSpan time = System.DateTime.Now.TimeOfDay;
        hours_pivot.localRotation = Quaternion.Euler(0f, 0f, (float)time.TotalHours * hours_to_degrees);
        minutes_pivot.localRotation = Quaternion.Euler(0f, 0f, (float)time.TotalMinutes * minutes_to_degrees);
        seconds_pivot.localRotation = Quaternion.Euler(0f, 0f, (float)time.TotalSeconds * seconds_to_degrees);
    }
}