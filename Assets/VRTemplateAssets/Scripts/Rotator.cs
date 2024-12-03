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

        [SerializeField, Tooltip("Liner velocity in mm per second")]
        Vector3 m_VelocityToMove;

        void Update()
        {
            transform.Rotate(m_Velocity * Time.deltaTime);
            transform.Translate(m_VelocityToMove);
        }
    }
}
