using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private bool hasKey = false;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectKey()
    {
        hasKey = true;
        Debug.Log("Llave recogida");
    }

    public bool HasKey()
    {
        return hasKey;
    }
}
