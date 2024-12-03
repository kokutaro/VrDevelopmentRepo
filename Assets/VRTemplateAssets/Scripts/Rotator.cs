using UnityEngine;

namespace Unity.VRTemplate
{
    /// <summary>
    /// Rotates this object at a user defined speed
    /// </summary>
    public class Rotator : MonoBehaviour
    {
        [SerializeField, Tooltip("Angular velocity in degrees per second")]
        Vector3 m_Velocity;
        [SerializeField, Tooltip("Angular velocity in degrees per second1")]
        Vector3 m_Velocity1;

        void Update()
        {
            transform.Rotate(m_Velocity * Time.deltaTime);
        }
    }
}
