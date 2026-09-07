using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [Header("Transicion de nivel")]
    [SerializeField] private string nextSceneName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (GameManager.Instance.HasKey())
            {
                if (string.IsNullOrEmpty(nextSceneName))
                {
                    // No hay siguiente nivel configurado: fin del prototipo por ahora
                    Debug.Log("Nivel completado! Fin del prototipo por ahora.");
                    collision.gameObject.GetComponent<Player1Controller>().enabled = false;
                    collision.gameObject.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
                }
                else
                {
                    Debug.Log("Puerta abierta! Cargando siguiente nivel...");
                    SceneManager.LoadScene(nextSceneName);
                }
            }
            else
            {
                Debug.Log("Necesitas la llave para abrir esta puerta");
            }
        }

    }
}