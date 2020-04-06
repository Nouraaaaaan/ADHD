using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
namespace Valve.VR.InteractionSystem.Sample
{
    /// <summary>
    /// This Class is the Parent class 
    /// </summary>
    public class System_Structure : MonoBehaviour
    {
        [Header("Text")]
        public List<Text> textDisplay;

        [Header("Audio")]
        public AudioSource audiosource;

        [Header("Image")]
        public List<Sprite> list_sprite;
        public List<Image> list_image;

        [Header("Magic Board")]
        public Animator anim;
        public List<Material> boardMaterials;

        [Header("SpriteSheets")]
        public GameObject SpriteSheetManager;
        public SpriteRenderer SpriteRenderer;
        public Animator SpriteSheet_Anim;
        public List<AnimationClip> AnimationClips_List;
        public Sprite emptySprite;

        [Header("Timeline")]
        public PlayableDirector playableDirector;
        public List<PlayableAsset> playableAssets;

        [Header("Characters")]
        public List<GameObject> Helper_characters;
        public List<GameObject> lookAtPositions;
        public static int moveIndex;

        [Header("Characters Animation")]
        public AnimationClip[] Animation_Clips;
        public List<AnimationClip> Idle_Animations;
        public List<AnimationClip> Walk_Animations;

        public List<Animator> charactersAnimators;

        public List<AnimatorOverrideController> animatoroveridecharacter;

        public string overrideClipsNames;

        [Header("Questions")]
        public GameObject RightAnswer;
        public GameObject WrongAnswer;
        public static bool nextquestion, CanClick;
        public static bool IsAnswerTrue;
        public static GameObject Obj;

        [Header("3D Models")]
        public List<GameObject> Model3d;
        public List<GameObject> classModel3d;
        public List<GameObject> instantiated3DModels;
        public List<GameObject> charactersHandPos;

        [Header("Waypoints")]
        public List<GameObject> waypoints;

        [Header("Element Field")]
        public static List<Element> Element;

        [Header("Index")]
        public static int lessonIndex;
        public static int elementIndex;

        [Header("Cheating Test")]
        public static int cheatingIndex;

        public static System_Structure Ins
        {
            get;
            set;
        }

        private void Awake()
        {
            // Singlton
            Ins = this;
        }

    }
}