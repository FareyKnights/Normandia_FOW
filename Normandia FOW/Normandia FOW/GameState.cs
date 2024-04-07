using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normandia_FOW
{
    public class GameState
    {
        public enum SceneType
        {
            Mainmenu,
            MainMap,
            CombatMap,
            Combat,
            GameOver
        }

        protected MainGame mainGame;

        public Scene currentScene { get; set; }

        public GameState(MainGame pGame)
        {
            mainGame = pGame;
        }

        public void ChangeScene(SceneType pSceneType)
        {
            if (currentScene  != null)
            {
                currentScene.UnLoad();
                currentScene = null;
            }

            switch (pSceneType)
            {
                case SceneType.Mainmenu:
                    currentScene = new SceneMainMenu(mainGame); 
                    break;
                case SceneType.MainMap:
                    currentScene = new SceneMainMap(mainGame);
                    break;
                case SceneType.CombatMap:
                    currentScene = new SceneCombatMap(mainGame);
                    break;
                case SceneType.Combat:
                    currentScene = new SceneCombat(mainGame);
                    break;
                case SceneType.GameOver:
                    currentScene = new SceneGameOver(mainGame);
                    break;
                default:
                    break;

            }
            currentScene.Load();
        }

    }
}
