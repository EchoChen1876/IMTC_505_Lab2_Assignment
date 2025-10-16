using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleParticle : MonoBehaviour
{
    public ParticleSystem particleSystem; // The particle system to control
    private bool isActive = false;        // Whether the particles are currently active (playing)

    public void Toggle()
    {
        if (particleSystem == null)
        {
            Debug.LogWarning("⚠️ No particle system assigned!");
            return;
        }

        if (isActive)
        {
            particleSystem.Stop();
            isActive = false;
        }
        else
        {
            particleSystem.Play();
            isActive = true;
        }
    }
}