using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject monsterType1;
    [SerializeField]
    GameObject monsterType2;
    // Start is called before the first frame update
    void Awake()
    {
        int day = GameObject.Find("PlayerData").GetComponent<PlayerData>().GetDay();
        switch (day)
        {
            case 1:
                {
                    SpawnMonster(100, 100, monsterType1);
                    break;
                }
            case 2:
                {
                    SpawnMonster(200, 200, monsterType1);
                    SpawnMonster(300, 300, monsterType2);
                    break;
                }
        }
    }

    private void SpawnMonster(float x, float y, GameObject monsterType)
    {
        GameObject monster = (GameObject)Instantiate(monsterType);
        monster.transform.SetParent(this.transform);
        monster.transform.localPosition = new Vector2(x, y);
        monster.transform.localScale = new Vector2(1, 1);
    }
}
