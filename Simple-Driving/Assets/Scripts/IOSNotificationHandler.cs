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
            CategoryIdentifier = "category_a", //Yani birden fazla bildirim varsa ayný kategoriye koyabilir veya gruplandýrabiliriz.
            ThreadIdentifier = "thread1", //Default deðer. 
            Trigger = new iOSNotificationTimeIntervalTrigger
            {
                TimeInterval = new System.TimeSpan(0, minutes, 0),
                Repeats = false
            }
            //Trigger -> bildirimin ortaya çýkmasýna neyin sebep olduðunu burada anlatýrýz. Ve bizim durumumuzda: bunu belli bir süre geçtikten sonra yapacaðýz. 
        };

        iOSNotificationCenter.ScheduleNotification(notification);
    }
#endif
}
