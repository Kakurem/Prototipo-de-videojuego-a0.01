using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificamos que quien choco sea el Player
        if (collision.gameObject.CompareTag("Player"))
        {
            if (GameManager.Instance.HasKey())
            {
                Debug.Log("Puerta abierta! Nivel completado");
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Necesitas la llave para abrir esta puerta");
            }
        }
    }
}
