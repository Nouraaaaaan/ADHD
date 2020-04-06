using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using UnityEditor;
using UnityEngine;
using System;
namespace Valve.VR.InteractionSystem.Sample
{
    /// <summary>
    /// Manage Save and load data using xml file.
    /// </summary>
    public class Xml_Manager : MonoBehaviour
    {
        // singleton pattern 
        public static Xml_Manager ins;

        public Subject subject = new Subject();

        private void Awake()
        {
            ins = this;
            Loaditems();
        }

        public void SaveItems()
        {
            XmlSerializer serilizer = new XmlSerializer(typeof(Subject));
            FileStream stream = new FileStream(Application.dataPath + "/StreamingAssets/XML/ADHD_Demo.xml", FileMode.Create);
            serilizer.Serialize(stream, subject);
            stream.Close();
        }

        public void Loaditems()
        {
            XmlSerializer serilizer = new XmlSerializer(typeof(Subject));
            FileStream stream = new FileStream(Application.dataPath + "/StreamingAssets/XML/ADHD_Demo.xml", FileMode.Open);
            subject = serilizer.Deserialize(stream) as Subject;
            stream.Close();
        }

        public static void Serialize(object item)
        {
            XmlSerializer Serializer = new XmlSerializer(item.GetType());
            StreamWriter writer = new StreamWriter(Application.dataPath + "/StreamingAssets/XML/ADHDSaver.xml");
            Serializer.Serialize(writer.BaseStream, item);
            writer.Close();
        }

        public static T Deserialize<T>()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamReader Reader = new StreamReader(Application.dataPath + "/StreamingAssets/XML/ADHDSaver.xml");
            T Deserializer = (T)serializer.Deserialize(Reader.BaseStream);
            Reader.Close();
            return Deserializer;

        }

    }

    [System.Serializable]
    public class Subject
    {
        public List<Lesson> lessons = new List<Lesson>();
    }

    [System.Serializable]
    public class Lesson
    {
        public List<Element> elements = new List<Element>();
    }

    [System.Serializable]
    public class Element
    {
        public TextManager textManager;
        public AudioManager audioManager;
        public ImageManager imageManager;
        public CharacterManager characterManager;
        public TimelineManager timelineManager;
        public QuestionManager questionManager;
        //public AnimationBoard animationBoard;
        public SpriteSheetManager spriteSheetsManager;
        public Model3DManager model3DManager;

        public TransitionType transitionType;
    }

    [System.Serializable]
    public struct TextManager
    {
        public bool exist;
        public List<TextItem> textItems;
        public float delayTime;
        public bool reset; // if this text is the last text of this group of texts , you have to remove all the text elements 

        //[SerializeField]
        //public List<Color> textColors;

        //[SerializeField]
        //public TextAnimationManager textAnimation;
    }

    [System.Serializable]
    public class TextItem
    {
        public string text;
        public TextPosition position;
        public Vector4 color;
    }

    //[System.Serializable]
    //public struct TextAnimationManager
    //{
    //    public bool exist;
    //    public TextAnimation textAnimation; // here i can choose the text animation from the list of animations i have 
    //    public TextPosition startingPoint;
    //}

    [System.Serializable]
    public struct ImageManager
    {
        public bool exist;
        //public string imageName;// here i can select which image i need to display with a specific text 
        [XmlIgnore]
        public Sprite sprite;
        public ImagePosition imagePosition;
        public float delayTime;
    }

    [System.Serializable]
    public struct AudioManager
    {
        public bool exist;
        public string audio;
        public float delayTime;
    }

    [System.Serializable]
    public struct CharacterManager
    {
        public bool exist;
        public Characters character;
        public CharactersAnimations animation;
        public CharacterLookAt lookAt;
        public AudioManager audio;
        public CharacterMovement characterMovement;
        public float delayTime;
    }

    [System.Serializable]
    public struct CharacterMovement
    {
        public bool move;

        [SerializeField]
        public List<AnimationPoints> waypoints;
    }

    [System.Serializable]
    public struct AnimationPoints
    {
        public Waypoints waypoint;
        public CharactersAnimations animation;
        public AudioManager audio;
        public CharacterLookAt lookAt;
    }

    [System.Serializable]
    public struct TimelineManager
    {
        public bool exist;
        public List<Timelines> timelines;
    }

    [System.Serializable]
    public struct QuestionManager
    {
        public bool exist;
        public string URL;
        public OperationType Operationtype;
        public string[] buttonName;

        [SerializeField]
        public List<string> Answers;

        public QuestionExplanation questionExplanation;

        public Vector3 instantiationPoint;
    }

    [System.Serializable]
    public class QuestionExplanation
    {
        public TextManager textManager;
        public AudioManager audioManager;
    }

    [System.Serializable]
    public struct AnimationBoard
    {
        public bool exist;
        public BoardStyle style;
    }

    [System.Serializable]
    public struct SpriteSheetManager
    {
        public bool exist;
        public SpritesNames spriteName;
        public float delayTime;
        public bool reset;
    }

    [System.Serializable]
    public struct Model3DManager
    {
        public bool exist;
        public Models3D model3d;
        public List<Model3dColor> modelColor;
        public Waypoints modelsPosition;
        public Vector3 distanceBetweenObjects;
        public bool catchObject;
        public bool Runtime;
        public ObjectsToCatch objectToCatch;
        public float delayTime;
        public bool reset;
    }

    [System.Serializable]
    public struct Model3dColor
    {
        public Color Color;
    }

}