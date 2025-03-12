#if CMPSETUP_COMPLETE
using TMPro;
using UnityEngine;

namespace AvocadoShark
{
    public class Menu : MonoBehaviour
    {
        [Header("Game Stats")]
        public TextMeshProUGUI Players_In_Rooms;
        public TextMeshProUGUI RoomsMade;
        [HideInInspector]
        public int characterchosen;
        public TextMeshProUGUI optionchosentext;
        private void Start()
        {
            characterchosen = PlayerPrefs.GetInt("ChosenCharacter");

            if (characterchosen == 0)
                optionchosentext.text = "Choose your character: \n <b>Red Chosen</b>";

            if (characterchosen == 1)
                optionchosentext.text = "Choose your character: \n <b>Yellow Chosen</b>";
        }
        void Update()
        {
            RoomsMade.text = "Total Rooms: " + FusionConnection.Instance.nRooms;
            Players_In_Rooms.text = "Players In Rooms: " + FusionConnection.Instance.nPPLOnline;
        }
        public void ExitGame()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
        public void OpenProVersion()
        {
            Application.OpenURL("https://assetstore.unity.com/packages/slug/264984");
        }
        public void OpenSupport()
        {
            Application.OpenURL("https://discord.gg/mP4yfHxXPa");
        }
        public void OpenAvocadoShark()
        {
            Application.OpenURL("https://avocadoshark.com/");
        }
        public void ChooseCharacter(string option)
        {
            if (option == "Red")
            {
                PlayerPrefs.SetInt("ChosenCharacter", 0);
                optionchosentext.text = "Choose your character: \n <b>Red Chosen</b>";
            }

            if (option == "Yellow")
            {
                PlayerPrefs.SetInt("ChosenCharacter", 1);
                optionchosentext.text = "Choose your character: \n <b>Yellow Chosen</b>";
            }
        }
    }
}
#endif