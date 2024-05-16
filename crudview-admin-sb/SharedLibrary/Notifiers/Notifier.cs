/*  Copyright [2018] [Invincible Technologies]
 *  
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *    
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

using System;
using System.Runtime.Serialization;

namespace SharedLibrary.Core.Notifiers
{
    /// <summary>
    /// Delegate for notifications.
    /// </summary>
    /// <param name="source"></param>
    /// <param name="arguments"></param>
    public delegate void Notifications(Object source, EventArgs arguments);

    /// <summary>
    /// Base class for extending or integrating event based messages notifications support in inheriting classes.
    /// </summary>
    [DataContract]
    public class Notifier
    {
        /// <summary>
        /// Notifications event.
        /// </summary>
        public event Notifications notifications;

        /// <summary>
        /// Makes message notification event call.
        /// </summary>
        /// <param name="message"></param>
        public void notify(String message)
        {
            if (notifications != null)
            {
                notifications(message, null);
            }
        }

        /// <summary>
        /// Makes exception notification event call.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="message"></param>
        public void notifyException(Object source, String message)
        {
            if (notifications != null)
            {
                notifications(message, new NotificationObject(source));
            }
        }
    }
}
