using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField]
    private GameObject _CoinObject;

    [SerializeField]
    private GameObject _trashObject;

    [SerializeField]
    private GameObject _EnemyObject;



    // Start is called before the first frame update

    

    void Start()
    {




        spawncoins();

        spawnTrashCans();








    }

    void spawnTrashCans()
    {
        Instantiate(_trashObject, new Vector3(138f, 1.03f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(160f, 5.2f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(282f, 3f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(350f, 5f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(460f, 7.2f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(460f, 15.9f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(460f, -0.96f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(497f, 8.2f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(574f, 6.3f, 0), Quaternion.identity);
    }

    void spawncoins()
    {
        for (int i = 590; i < 595; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, -1.45f, 0), Quaternion.identity);
            Instantiate(_CoinObject, new Vector3(i, -2.88f, 0), Quaternion.identity);
        }

        for (int i = 637; i < 642; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, -1.45f, 0), Quaternion.identity);
            Instantiate(_CoinObject, new Vector3(i, -2.88f, 0), Quaternion.identity);
        }

        Instantiate(_CoinObject, new Vector3(-2.22f, -5.91f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(-1.14f, -5.91f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(5.18f, -3.77f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(7.08f, -3.77f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(9.17f, -3.77f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(14.15f, -0.88f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(15.5f, -0.88f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(17.16f, -0.88f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(18.88f, -0.88f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(27.60f, -2.29f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(28.83f, -2.29f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(30.06f, -2.29f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(31.47f, -2.29f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(44.12f, -3.72f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(45.56f, -3.72f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(58.8f, -4.97f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(59.89f, -4.97f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(61.07f, -4.97f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(73.83f, -4.97f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(81.13f, -4.97f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(77.35f, -4.97f, 0), Quaternion.identity);

        Instantiate(_CoinObject, new Vector3(106f, 1.12f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(107f, 1.12f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(108f, 1.12f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(109f, 1.12f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(110f, 1.12f, 0), Quaternion.identity);

        Instantiate(_CoinObject, new Vector3(128.01f, -2.44f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(129.51f, -2.44f, 0), Quaternion.identity);

        Instantiate(_CoinObject, new Vector3(138.42f, -2.79f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(137.36f, -2.79f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(136.30f, -2.79f, 0), Quaternion.identity);

        Instantiate(_CoinObject, new Vector3(142.48f, -4.56f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(143.80f, -4.56f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(145.21f, -4.56f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(146.71f, -4.56f, 0), Quaternion.identity);

        Instantiate(_CoinObject, new Vector3(151.31f, 5.51f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(153.34f, 5.51f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(149.63f, 5.51f, 0), Quaternion.identity);

        Instantiate(_CoinObject, new Vector3(167.47f, 4.01f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(175.33f, 1.89f, 0), Quaternion.identity);

        for (int i = 185; i < 189; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 2.67f, 0), Quaternion.identity);
            Instantiate(_CoinObject, new Vector3(i, 3.78f, 0), Quaternion.identity);
        }

        for (int i = 209; i < 212; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 4.72f, 0), Quaternion.identity);
        }

        Instantiate(_CoinObject, new Vector3(234.17f, -4.05f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(238.05f, -2.78f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(241.55f, -1.82f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(248.45f, -0.83f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(249.45f, -0.83f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(249.45f, 3f, 0), Quaternion.identity);

        for (int i = 260; i < 264; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 9.73f, 0), Quaternion.identity);
            Instantiate(_CoinObject, new Vector3(i, 8.83f, 0), Quaternion.identity);
        }

        Instantiate(_CoinObject, new Vector3(264, -3.58f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(274, 2.12f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(273, 2.12f, 0), Quaternion.identity);

        for (int i = 287; i < 291; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 3.42f, 0), Quaternion.identity);
        }

        for (int i = 308; i < 312; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 7.12f, 0), Quaternion.identity);
        }

        for (int i = 376; i < 380; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 1.67f, 0), Quaternion.identity);
        }

        for (int i = 398; i < 402; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 6.2f, 0), Quaternion.identity);
        }

        for (int i = 413; i < 417; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 14.19f, 0), Quaternion.identity);
            Instantiate(_CoinObject, new Vector3(i, -3.08f, 0), Quaternion.identity);
        }

        for (int i = 428; i < 433; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 7.91f, 0), Quaternion.identity);
        }

        for (int i = 442; i < 446; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 4.1f, 0), Quaternion.identity);
            Instantiate(_CoinObject, new Vector3(i, 10.96f, 0), Quaternion.identity);
        }

        for (int i = 526; i < 530; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 9.25f, 0), Quaternion.identity);
        }

        for (int i = 613; i < 618; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 5.96f, 0), Quaternion.identity);
        }

        for (int i = 656; i < 661; i++)
        {
            Instantiate(_CoinObject, new Vector3(i, 1.03f, 0), Quaternion.identity);
        }

        Instantiate(_CoinObject, new Vector3(342f, 0.18f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(343f, 0.18f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(360f, 5.49f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(359f, 5.49f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
