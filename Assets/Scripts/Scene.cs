using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets
{
    public class Scene : MonoBehaviour
    {
        private static int SceneMenu = 1;
        private static int SceneGame = 2;
        private static int SceneShop = 3;
        public static void Game()
        {
            SceneManager.LoadScene(SceneGame);
        }
        public static void Menu()
        {
            SceneManager.LoadScene(SceneMenu);
        }
        public static void Shop()
        {
            SceneManager.LoadScene(SceneShop);
        }
    }
}
