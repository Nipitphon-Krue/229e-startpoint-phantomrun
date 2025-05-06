using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Platformer
{
    public class GameManager : MonoBehaviour
    {
        public int coinsCounter = 0;

        public GameObject playerGameObject;
        private PlayerController player;
        public GameObject deathPlayerPrefab;
        public Text coinText;

        void Start()
        {
            player = GameObject.Find("Player").GetComponent<PlayerController>();
        }

      
        private void ReloadLevel()
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        void Update()
        {
            coinText.text = coinsCounter.ToString();

            if (player.deathState == true)
            {
                playerGameObject.SetActive(false);
                GameObject deathPlayer = (GameObject)Instantiate(deathPlayerPrefab, playerGameObject.transform.position, playerGameObject.transform.rotation);
                deathPlayer.transform.localScale = new Vector3(playerGameObject.transform.localScale.x, playerGameObject.transform.localScale.y, playerGameObject.transform.localScale.z);
                player.deathState = false;
                Invoke("ReloadLevel", 3);
                Invoke("LoadLoseScene", 1);

            }

            if (coinsCounter >= 9)
            {
                Invoke("LoadWinScene", 0.5f);
            }


        }

        private void LoadWinScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("WinScene");
        }
        private void LoadLoseScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("LoseScene");
        }

    }
}