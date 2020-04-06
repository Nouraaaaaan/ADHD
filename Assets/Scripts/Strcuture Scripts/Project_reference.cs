using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public enum TextPosition
    {
        topMiddle, middleRight1, middleRight2, middleMiddle, middleLeft1, middleLeft2, middleRightBig, middleMiddleBig, middleLeftBig
    }

    /// <summary>
    /// Contain Text possible Animations. 
    /// </summary>
    public enum TextAnimation
    {
        move, scaleUp, scaleDown, rotate
    }

    public enum ImagePosition
    {
        topLeft,
        topMiddle,
        topRight,
        middleLeft,
        middle,
        middleRight,
        bottomLeft,
        bottomMiddle,
        bottomRight,
        bigRight,
        bigMiddle,
        bigLeft
    }

    public enum CharactersAnimations
    {
        A_Catch, A_Consult, A_Eat, A_Idle, A_SayNo, A_SayYes, A_Sitdown, A_Standup, A_Talk, A_TurnLeft, A_Walk, A_Write, A_WriteInBlackboard,
        G_Eat, G_Idle, G_SayNo, G_SayYes, G_Talk, G_Walk, G_Write, G_WriteInBlackboard,
        B_Consult, B_Eat, B_Idle, B_SayNo, B_SayYes, B_Talk, B_Write, B_WriteInBlackboard,
        T_ExplainLong, T_ExplainMiddle, T_ExplainShort, T_Idle, T_PointTo, T_Walk
    }

    public enum SpritesNames
    {
        bicycle,
        blocks,
        bucket,
        butterfly,
        car,
        cat,
        doll,
        flowerAndBee,
        football,
        hairPin,
        leafAndInsect,
        monkeyAndBanana,
        robot,
        ship,
        shipAndBeach,
        skate,
        swan,
        train
    }

    public enum CharacterLookAt
    {
        Player, Abkareno, Giraffe, Butterfly, Teacher, Board
    }

    public enum Models3D
    {
        Cube, Sphere, Cylinder, Ball, Cherry, Pen, Hat
    }

    public enum Catch_Time
    {
        Runtime, Pre_runtime
    }

    public enum ObjectsToCatch
    {
        Book
    }

    public enum TransitionType
    {
        Auto, Manual
    }

    public enum BoardStyle
    {
        Normal, Sea, Grass, Desert
    }

    public enum Characters
    {
        Abkareno, Giraffe, Butterfly, Teacher
    }

    public enum Waypoints
    {
        abkarenoIdlePos,
        giraffeIdlePos,
        butterflyIdlePos,
        deskRight_Characters,
        giraffePoint1,
        giraffePoint2,
        abkarenoPoint1,
        abkarenoPoint2,
        abkarenoPoint3,
        aboveDeskRight,
        aboveDeskMiddle,
        aboveDeskLeft,
        onboardRight1,
        onboardRight2,
        onboardMiddle,
        onboardLeft1_Teacher,
        onboardLeft2,
        deskFront,
        aboveTeacherDeskRight_Butterfly,
        aboveTeacherDeskMiddle_Butterfly,
        aboveTeacherDeskLeft_Butterfly
    }

    public enum Timelines
    {
        Timeline1, CutScene2
    }

    public enum OperationType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    public class Project_reference : MonoBehaviour { }
}