using System.Collections;
using System.Collections.Generic;
#if UNITY_IOS
using Unity.Notifications.iOS;
#endif
using UnityEngine;

public class IOSNotificationHandler : MonoBehaviour
{
#if UNITY_IOS
    public void ScheduleNotification(int minutes)
    {
        iOSNotification notification = new iOSNotification
        {
            Title = "Energy Recharged!",
            Subtitle = "Your energy has been recharged",
            Body = "Your energy has been recharged, come back to play again!",
            ShowInForeground = true,
            ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound),
            CategoryIdentifier = "category_a", //Yani birden fazla bildirim varsa ayn� kategoriye koyabilir veya grupland�rabiliriz.
            ThreadIdentifier = "thread1", //Default de�er. 
            Trigger = new iOSNotificationTimeIntervalTrigger
            {
                TimeInterval = new System.TimeSpan(0, minutes, 0),
                Repeats = false
            }
            //Trigger -> bildirimin ortaya ��kmas�na neyin sebep oldu�unu burada anlat�r�z. Ve bizim durumumuzda: bunu belli bir s�re ge�tikten sonra yapaca��z. 
        };

        iOSNotificationCenter.ScheduleNotification(notification);
    }
#endif
}
