using UnityEngine;

namespace Assets
{
    public class BackgroundMusic : MonoBehaviour
    {
        [SerializeField] private GameObject backgroundMusic;
        private void Awake()
        {
            var musics = GameObject.FindGameObjectsWithTag("Sound");
            if(musics.Length == 0)
            {
                var music = Instantiate(backgroundMusic);
                DontDestroyOnLoad(music);
            }
        }
    }
}
