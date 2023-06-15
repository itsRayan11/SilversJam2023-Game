using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mechanics
{
    public class NextLevel : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
