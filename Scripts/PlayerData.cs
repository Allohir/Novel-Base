using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private static PlayerData Instance;

    private int day = 1;
    private float stamina = 100;
    private float suspicion = 0;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public int GetDay()
    {
        return this.day;
    }

    public float GetStamina()
    {
        return this.stamina;
    }

    public float GetSuspicion()
    {
        return this.suspicion;
    }

    public void DamageStamina(float damage)
    {
        this.stamina -= damage;
    }

    public void RestoreStamina(float restore)
    {
        this.stamina += restore;
    }

    public void increaseSuspicion(float increase)
    {
        this.suspicion += increase;
    }

    public void decreaseSuspicion(float decrease)
    {
        this.suspicion += decrease;
    }

    public void changeDay()
    {
        this.day++;
    }
}